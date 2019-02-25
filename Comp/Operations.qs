namespace Comp
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (qubit : Qubit, desired : Result) : Unit
    {
        if (M(qubit) != desired)
        {
            X (qubit);
        }
    }

    operation isFSA(x: Int) : Bool
    {
        mutable sum1 = 0;
        mutable num = x;

        repeat
        {
            set sum1 = sum1 + (num % 2);
            set num = num / 2;
        } until (num == 0)
        fixup {}

        return (sum1 % 2 == 0);
    }

    operation oracle (x : Qubit[], y : Qubit) : Unit
    {
        for (i in 0..Length(x)-1)
        {
            if (isFSA(i))
            {
                CNOT (x[i], y);
            }
        }
    }

    operation BernsteinVarzani(n : Int) : Bool[]
    {
        mutable ans = new Bool[n];
        using (qs = Qubit[n+1])
        {
            for (i in 0..n-1)
            {
                Set (qs[i], Zero);
                H (qs[i]);
            }

            Set (qs[n], One);
            H (qs[n]);

            oracle (qs[0..n-1], qs[n]);

            for (i in 0..n-1)
            {
                H (qs[i]);
                set ans[i] = (M (qs[i]) == One);
                Set (qs[i], Zero);
            }
            Set (qs[n], Zero);
        }
        return ans;
    }
}
