namespace Superdense
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (qubit: Qubit, desired: Result) : Unit
    {
        let current = M (qubit);
        if (current != desired)
        {
            X(qubit);
        }
    }

    operation SuperdenseCode (bit0: Bool, bit1: Bool, reps: Int) : Bool
    {
        mutable success = true;
        mutable required = new Result[2];
        set required[0] = bit0? One | Zero;
        set required[1] = bit1? One | Zero;

        mutable got = new Result[2];

        using (qubit = Qubit[2])
        {
            for (i in 1..reps)
            {
                // Pre-preparing the qubits
                Set (qubit[0], Zero);
                Set (qubit[1], Zero);
                H (qubit[0]);
                CNOT (qubit[0], qubit[1]);

                // Encoding message (only on qubit[0])...
                // Person 2 already has qubit[1]
                if (bit1)
                {
                    X (qubit[0]);
                }
                if (bit0)
                {
                    Z (qubit[0]);
                }

                // Now send only qubit[0], for reading the qubit...
                CNOT (qubit[0], qubit[1]);
                H (qubit[0]);
                set got[0] = M (qubit[0]);
                set got[1] = M (qubit[1]);

                if (got[0] != required[0] || got[1] != required[1])
                {
                    set success = false;
                }
            }

            Set (qubit[0], Zero);
            Set (qubit[1], Zero);
        }

        return success;
    }
}
