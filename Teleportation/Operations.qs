namespace Teleportation
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (qubit: Qubit, desired: Result) : Unit
    {
        if (M (qubit) != desired)
        {
            X(qubit);
        }
    }

    operation Teleport (toSend: Qubit, bridge: Qubit) : (Result, Result)
    {
        // Bridge and the final qubit must be in Bell state ( |00> + |11> )
        CNOT (toSend, bridge);
        H (toSend);

        return (M (toSend), M(bridge));
    }

    operation doTeleport (state: Result, hadaBasis: Bool, reps: Int) : Bool
    {
        mutable success = true;

        using (qubit = Qubit[3])
        {
            for (i in 1..reps)
            {
                Set (qubit[0], state);
                Set (qubit[1], Zero);
                Set (qubit[2], Zero);

                if (hadaBasis)
                {
                    H (qubit[0]);
                }

                H (qubit[1]);
                CNOT (qubit[1], qubit[2]);

                // Teleportation part...
                let (ARes, BRes) = Teleport(qubit[0], qubit[1]);
                if (BRes == One)
                {
                    X (qubit[2]);
                }
                if (ARes == One)
                {
                    Z (qubit[2]);
                }

                if (hadaBasis)
                {
                    H (qubit[2]);
                }

                if (M (qubit[2]) != state)
                {
                    set success = false;
                }
            }
            Set (qubit[0], Zero);
            Set (qubit[1], Zero);
            Set (qubit[2], Zero);
        }
        return success;
    }
}
