
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Reference {
    public interface IReferenceTestInstantiator {
        Thing AcquireThing();
        void DiscardThing(Thing o);
        FinalObject AcquireFinalObject();
        void DiscardFinalObject(FinalObject o);
        AbstractThing AcquireAbstractThing();
        void DiscardAbstractThing(AbstractThing o);
        FinalThing1 AcquireFinalThing1();
        void DiscardFinalThing1(FinalThing1 o);
        FinalThing2 AcquireFinalThing2();
        void DiscardFinalThing2(FinalThing2 o);
        AbstractReferenceObject AcquireAbstractReferenceObject();
        void DiscardAbstractReferenceObject(AbstractReferenceObject o);


        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
