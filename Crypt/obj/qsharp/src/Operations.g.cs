#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Crypt\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Crypt\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Crypt\",\"Name\":\"CryptSend\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"sz\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eaves\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Crypt\",\"Name\":\"CryptSend\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
#line hidden
namespace Crypt
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
        String ICallable.FullName => "Crypt.Set";
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
#line 8 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
            var measure = M.Apply(qubit);
#line 10 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
            if ((measure != desired))
            {
#line 12 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
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

    public class CryptSend : Operation<(Int64,Boolean), QArray<Int64>>, ICallable
    {
        public CryptSend(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Boolean)>, IApplyData
        {
            public In((Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CryptSend";
        String ICallable.FullName => "Crypt.CryptSend";
        protected ICallable<(Qubit,Result), QVoid> Set
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        protected ICallable<QArray<Double>, Int64> Random
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,Boolean), QArray<Int64>> Body => (__in__) =>
        {
            var (sz,eaves) = __in__;
#line 18 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
            var pad = new QArray<Int64>(sz);
#line hidden
            {
#line 20 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                var qubit = Allocate.Apply((2L * sz));
#line 23 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                var boi = new QArray<Double>(2L);
#line 24 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                boi[0L] = 0.5D;
#line 25 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                boi[1L] = 0.5D;
#line 29 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                foreach (var i in new Range(0L, (sz - 1L)))
#line hidden
                {
#line 32 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    Set.Apply((qubit[i], Result.Zero));
#line 33 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    Set.Apply((qubit[(sz + i)], Result.Zero));
#line 35 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubit[i]);
#line 36 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubit[i], qubit[(sz + i)]));
                }

#line 41 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                var eavesRead = new QArray<Result>(sz);
#line 42 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                var eavesState = new QArray<Boolean>(sz);
#line 43 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                if (eaves)
                {
#line 45 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    foreach (var i in new Range(0L, (sz - 1L)))
#line hidden
                    {
#line 47 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                        eavesState[i] = (Random.Apply(boi?.Copy()) == 1L);
#line 48 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                        if (eavesState[i])
                        {
#line 50 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                            MicrosoftQuantumPrimitiveH.Apply(qubit[(sz + i)]);
                        }

#line 52 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                        eavesRead[i] = M.Apply(qubit[(sz + i)]);
                    }
                }

#line 57 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                var basis = new QArray<Boolean>((2L * sz));
#line 58 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                var results = new QArray<Result>((2L * sz));
#line 61 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                foreach (var i in new Range(0L, ((2L * sz) - 1L)))
#line hidden
                {
#line 63 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    basis[i] = (Random.Apply(boi?.Copy()) == 1L);
#line 64 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    if (basis[i])
                    {
#line 66 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubit[i]);
                    }

#line 68 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    results[i] = M.Apply(qubit[i]);
                }

#line 73 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                foreach (var i in new Range(0L, (sz - 1L)))
#line hidden
                {
#line 74 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    if ((basis[i] != basis[(sz + i)]))
                    {
#line 76 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                        pad[i] = -(1L);
                    }
                    else
                    {
#line 80 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                        if ((results[i] != results[(sz + i)]))
                        {
#line 82 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                            pad[i] = -(2L);
                        }
                        else
                        {
#line 86 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                            pad[i] = ((results[i] == Result.Zero) ? 0L : 1L);
                        }
                    }

#line 89 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    Set.Apply((qubit[i], Result.Zero));
#line 90 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
                    Set.Apply((qubit[(sz + i)], Result.Zero));
                }

#line hidden
                Release.Apply(qubit);
            }

#line 94 "/home/rishvic/Documents/Dev/Quany/Crypt/Operations.qs"
            return pad;
        }

        ;
        public override void Init()
        {
            this.Set = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Set));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Random = this.Factory.Get<ICallable<QArray<Double>, Int64>>(typeof(Microsoft.Quantum.Primitive.Random));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 sz, Boolean eaves)
        {
            return __m__.Run<CryptSend, (Int64,Boolean), QArray<Int64>>((sz, eaves));
        }
    }
}