namespace Oracles
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (qubit: Qubit, desired: Result) : Unit
    {
        if (M (qubit) != desired)
        {
            X (qubit);
        }
    }

    operation BernsteinVarzani(input: Qubit[], target: Qubit, bits: Bool[]) : Unit
    {
        for (i in 0..len(input)-1)
        {
            if (bits[i])
            {
                CNOT (input[i], target);
            }
        }
    }

    operation isPalindrome(input: Qubit[], target: Qubit) : Unit
    {
        let n = Length(input);
        for (i in 0..n/2-1)
        {
            CNOT (input[n-1-i], input[i]);
            X (input[i]);
        }

        Controlled X (input[0..n/2-1], target);

        for (i in 0..n/2-1)
        {
            X (input[i]);
            CNOT (input[n-1-i], input[i]);
        }
    }

    operation BernsteinVarzaniChecker(oracle: (Qubit[], Qubit)=>(Qubit[], Qubit)) : Bool[]
    {
    }
}
