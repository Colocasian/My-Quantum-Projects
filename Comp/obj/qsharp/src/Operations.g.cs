#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Comp\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Comp\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Comp\",\"Name\":\"isFSA\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Comp\",\"Name\":\"isFSA\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Comp\",\"Name\":\"oracle\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Comp\",\"Name\":\"oracle\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Comp\",\"Name\":\"BernsteinVarzani\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Comp\",\"Name\":\"BernsteinVarzani\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
#line hidden
namespace Comp
{
    public class Set : Operation<(Qubit,Result), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Result)>, IApplyData
        {
            public In((Qubit,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Comp.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Result), QVoid> Body => (__in__) =>
        {
            var (qubit,desired) = __in__;
#line 8 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            if ((M.Apply(qubit) != desired))
            {
#line 10 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Result) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit, Result desired)
        {
            return __m__.Run<Set, (Qubit,Result), QVoid>((qubit, desired));
        }
    }

    public class isFSA : Operation<Int64, Boolean>, ICallable
    {
        public isFSA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "isFSA";
        String ICallable.FullName => "Comp.isFSA";
        public override Func<Int64, Boolean> Body => (__in__) =>
        {
            var x = __in__;
#line 16 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            var sum1 = 0L;
#line 17 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            var num = x;
#line 19 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            while (true)
            {
#line 21 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                sum1 = (sum1 + (num % 2L));
#line 22 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                num = (num / 2L);
                if ((num == 0L))
                {
                    break;
                }
                else
                {
                }
            }

#line 26 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            return ((sum1 % 2L) == 0L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 x)
        {
            return __m__.Run<isFSA, Int64, Boolean>(x);
        }
    }

    public class oracle : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public oracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "oracle";
        String ICallable.FullName => "Comp.oracle";
        protected ICallable<Int64, Boolean> isFSA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 31 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            foreach (var i in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 33 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                if (isFSA.Apply(i))
                {
#line 35 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.isFSA = this.Factory.Get<ICallable<Int64, Boolean>>(typeof(isFSA));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<oracle, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class BernsteinVarzani : Operation<Int64, QArray<Boolean>>, ICallable
    {
        public BernsteinVarzani(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BernsteinVarzani";
        String ICallable.FullName => "Comp.BernsteinVarzani";
        protected ICallable<(Qubit,Result), QVoid> Set
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Qubit), QVoid> oracle
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<Int64, QArray<Boolean>> Body => (__in__) =>
        {
            var n = __in__;
#line 42 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            var ans = new QArray<Boolean>(n);
#line hidden
            {
#line 43 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                var qs = Allocate.Apply((n + 1L));
#line 45 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                foreach (var i in new Range(0L, (n - 1L)))
#line hidden
                {
#line 47 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                    Set.Apply((qs[i], Result.Zero));
#line 48 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qs[i]);
                }

#line 51 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                Set.Apply((qs[n], Result.One));
#line 52 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[n]);
#line 54 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                oracle.Apply((qs?.Slice(new Range(0L, (n - 1L))), qs[n]));
#line 56 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                foreach (var i in new Range(0L, (n - 1L)))
#line hidden
                {
#line 58 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qs[i]);
#line 59 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                    ans[i] = (M.Apply(qs[i]) == Result.One);
#line 60 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                    Set.Apply((qs[i], Result.Zero));
                }

#line 62 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
                Set.Apply((qs[n], Result.Zero));
#line hidden
                Release.Apply(qs);
            }

#line 64 "/home/rishvic/Documents/Dev/Quany/Comp/Operations.qs"
            return ans;
        }

        ;
        public override void Init()
        {
            this.Set = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Set));
            this.oracle = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit), QVoid>>(typeof(oracle));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, Int64 n)
        {
            return __m__.Run<BernsteinVarzani, Int64, QArray<Boolean>>(n);
        }
    }
}