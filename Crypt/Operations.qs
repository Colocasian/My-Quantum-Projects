namespace Crypt
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (qubit: Qubit, desired: Result) : Unit
    {
        let measure = M (qubit);

        if (measure != desired)
        {
            X (qubit);
        }
    }

    operation CryptSend(sz: Int, eaves: Bool) : Int[]
    {
        mutable pad = new Int[sz];

        using (qubit = Qubit[2 * sz])
        {
            // RNG start | Could do with qubit, but doubles space & time req.
            mutable boi = new Double[2];
            set boi[0] = 0.5;
            set boi[1] = 0.5;
            // RNG end

            // Generating message
            for (i in 0..(sz-1))
            {
                // Random(boi) == 1? One |
                Set (qubit[i], Zero);
                Set (qubit[sz + i], Zero);

                H (qubit[i]);
                CNOT (qubit[i], qubit[sz + i]);
            }
            // Generated & "sent" message

            // If eavesdropper was present
            mutable eavesRead = new Result[sz];
            mutable eavesState = new Bool[sz];
            if (eaves)
            {
                for (i in 0..(sz-1))
                {
                    set eavesState[i] = Random(boi) == 1;
                    if (eavesState[i])
                    {
                        H (qubit[sz + i]);
                    }
                    set eavesRead[i] = M (qubit[sz + i]);
                }
            }
            // Eavesdropper has read qubits

            mutable basis = new Bool[2 * sz];
            mutable results = new Result[2 * sz];

            // Reading message
            for (i in 0..(2 * sz - 1))
            {
                set basis[i] = (Random (boi) == 1);
                if (basis[i])
                {
                    H (qubit[i]);
                }
                set results[i] = M (qubit[i]);
            }
            // Read message

            // Checking bases
            for (i in 0..sz-1) {
                if (basis[i] != basis[sz + i])
                {
                    set pad[i] = -1;
                }
                else
                {
                    if (results[i] != results[sz + i])
                    {
                        set pad[i] = -2;
                    }
                    else
                    {
                        set pad[i] = results[i] == Zero? 0 | 1;
                    }
                }
                Set (qubit[i], Zero);
                Set (qubit[sz + i], Zero);
            }
            // Checked bases
        }
        return pad;
    }
}
