#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Teleportation\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Teleportation\",\"Name\":\"Set\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Teleportation\",\"Name\":\"Teleport\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"toSend\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bridge\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Teleportation\",\"Name\":\"Teleport\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Teleportation\",\"Name\":\"doTeleport\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hadaBasis\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"reps\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Bool\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Teleportation\",\"Name\":\"doTeleport\"},\"SourceFile\":\"/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace Teleportation
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
        String ICallable.FullName => "Teleportation.Set";
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
#line 8 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
            if ((M.Apply(qubit) != desired))
            {
#line 10 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
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

    public class Teleport : Operation<(Qubit,Qubit), (Result,Result)>, ICallable
    {
        public Teleport(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        public class Out : QTuple<(Result,Result)>, IApplyData
        {
            public Out((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Teleport";
        String ICallable.FullName => "Teleportation.Teleport";
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

        public override Func<(Qubit,Qubit), (Result,Result)> Body => (__in__) =>
        {
            var (toSend,bridge) = __in__;
#line 17 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((toSend, bridge));
#line 18 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
            MicrosoftQuantumPrimitiveH.Apply(toSend);
#line 20 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
            return (M.Apply(toSend), M.Apply(bridge));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut((Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result)> Run(IOperationFactory __m__, Qubit toSend, Qubit bridge)
        {
            return __m__.Run<Teleport, (Qubit,Qubit), (Result,Result)>((toSend, bridge));
        }
    }

    public class doTeleport : Operation<(Result,Boolean,Int64), Boolean>, ICallable
    {
        public doTeleport(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Boolean,Int64)>, IApplyData
        {
            public In((Result,Boolean,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "doTeleport";
        String ICallable.FullName => "Teleportation.doTeleport";
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

        protected ICallable<(Qubit,Qubit), (Result,Result)> Teleport
        {
            get;
            set;
        }

        public override Func<(Result,Boolean,Int64), Boolean> Body => (__in__) =>
        {
            var (state,hadaBasis,reps) = __in__;
#line 25 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
            var success = true;
#line hidden
            {
#line 27 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                var qubit = Allocate.Apply(3L);
#line 29 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                foreach (var i in new Range(1L, reps))
#line hidden
                {
#line 31 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    Set.Apply((qubit[0L], state));
#line 32 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    Set.Apply((qubit[1L], Result.Zero));
#line 33 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    Set.Apply((qubit[2L], Result.Zero));
#line 35 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    if (hadaBasis)
                    {
#line 37 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubit[0L]);
                    }

#line 40 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubit[1L]);
#line 41 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubit[1L], qubit[2L]));
#line 44 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    var (ARes,BRes) = Teleport.Apply((qubit[0L], qubit[1L]));
#line 45 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    if ((BRes == Result.One))
                    {
#line 47 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qubit[2L]);
                    }

#line 49 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    if ((ARes == Result.One))
                    {
#line 51 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                        MicrosoftQuantumPrimitiveZ.Apply(qubit[2L]);
                    }

#line 54 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    if (hadaBasis)
                    {
#line 56 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubit[2L]);
                    }

#line 59 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                    if ((M.Apply(qubit[2L]) != state))
                    {
#line 61 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                        success = false;
                    }
                }

#line 64 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                Set.Apply((qubit[0L], Result.Zero));
#line 65 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                Set.Apply((qubit[1L], Result.Zero));
#line 66 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
                Set.Apply((qubit[2L], Result.Zero));
#line hidden
                Release.Apply(qubit);
            }

#line 68 "/home/rishvic/Documents/Dev/Quany/Teleportation/Operations.qs"
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
            this.Teleport = this.Factory.Get<ICallable<(Qubit,Qubit), (Result,Result)>>(typeof(Teleport));
        }

        public override IApplyData __dataIn((Result,Boolean,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Result state, Boolean hadaBasis, Int64 reps)
        {
            return __m__.Run<doTeleport, (Result,Boolean,Int64), Boolean>((state, hadaBasis, reps));
        }
    }
}