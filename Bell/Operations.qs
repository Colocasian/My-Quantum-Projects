namespace Bell
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (desired: Result, q1: Qubit) : Unit
    {
        let current = M(q1);
        if (current != desired)
        {
            X(q1);
        }
    }

    operation BellTest(count: Int, initial: Result) : (Int, Int, Int)
    {
        mutable numOnes = 0;
        mutable agree = 0;
        using (qubit = Qubit[2])
        {
            for (test in 1..count)
            {
                Set (initial, qubit[0]);
                Set (Zero, qubit[1]);

                H(qubit[0]);
                CNOT(qubit[0], qubit[1]);
                let res = M(qubit[0]);

                if (M (qubit[1]) == res)
                {
                    set agree = agree + 1;
                }

                // Count the number of ones we saw
                if (res == One)
                {
                    set numOnes = numOnes + 1;
                }
            }

            Set (Zero, qubit[0]);
            Set (Zero, qubit[1]);
        }

        // Return number of times we saw a |0> and number of times we saw |1>
        return (count-numOnes, numOnes, agree);
    }
}
