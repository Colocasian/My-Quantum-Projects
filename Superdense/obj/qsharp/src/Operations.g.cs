#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Superdense\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Superdense\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Superdense\",\"Name\":\"SuperdenseCode\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit0\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit1\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"reps\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Superdense\",\"Name\":\"SuperdenseCode\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Superdense
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
        String ICallable.FullName => "Superdense.Set";
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
#line 8 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            var current = M.Apply(qubit);
#line 9 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            if ((current != desired))
            {
#line 11 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
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

    public class SuperdenseCode : Operation<(Boolean,Boolean,Int64), Boolean>, ICallable
    {
        public SuperdenseCode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Int64)>, IApplyData
        {
            public In((Boolean,Boolean,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SuperdenseCode";
        String ICallable.FullName => "Superdense.SuperdenseCode";
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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Result), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Boolean,Boolean,Int64), Boolean> Body => (__in__) =>
        {
            var (bit0,bit1,reps) = __in__;
#line 17 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            var success = true;
#line 18 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            var required = new QArray<Result>(2L);
#line 19 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            required[0L] = (bit0 ? Result.One : Result.Zero);
#line 20 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            required[1L] = (bit1 ? Result.One : Result.Zero);
#line 22 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            var got = new QArray<Result>(2L);
#line hidden
            {
#line 24 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                var qubit = Allocate.Apply(2L);
#line 26 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                foreach (var i in new Range(1L, reps))
#line hidden
                {
#line 29 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    Set.Apply((qubit[0L], Result.Zero));
#line 30 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    Set.Apply((qubit[1L], Result.Zero));
#line 31 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubit[0L]);
#line 32 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubit[0L], qubit[1L]));
#line 36 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    if (bit1)
                    {
#line 38 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qubit[0L]);
                    }

#line 40 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    if (bit0)
                    {
#line 42 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                        MicrosoftQuantumPrimitiveZ.Apply(qubit[0L]);
                    }

#line 46 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubit[0L], qubit[1L]));
#line 47 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubit[0L]);
#line 48 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    got[0L] = M.Apply(qubit[0L]);
#line 49 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    got[1L] = M.Apply(qubit[1L]);
#line 51 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                    if (((got[0L] != required[0L]) || (got[1L] != required[1L])))
                    {
#line 53 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                        success = false;
                    }
                }

#line 57 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                Set.Apply((qubit[0L], Result.Zero));
#line 58 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
                Set.Apply((qubit[1L], Result.Zero));
#line hidden
                Release.Apply(qubit);
            }

#line 61 "/home/rishvic/Documents/Dev/Quany/Superdense/Operations.qs"
            return success;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
            this.Set = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Boolean,Boolean,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean bit0, Boolean bit1, Int64 reps)
        {
            return __m__.Run<SuperdenseCode, (Boolean,Boolean,Int64), Boolean>((bit0, bit1, reps));
        }
    }
}