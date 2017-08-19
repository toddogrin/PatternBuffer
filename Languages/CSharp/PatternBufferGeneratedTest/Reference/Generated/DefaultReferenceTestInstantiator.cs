
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Reference {
    public class DefaultReferenceTestInstantiator : IReferenceTestInstantiator {
        public Thing AcquireThing() {
            return new Thing();
        }
        public void DiscardThing(Thing o) {
            // Dispose?
        }
        public FinalObject AcquireFinalObject() {
            return new FinalObject();
        }
        public void DiscardFinalObject(FinalObject o) {
            // Dispose?
        }
        public AbstractThing AcquireAbstractThing() {
            return new AbstractThing();
        }
        public void DiscardAbstractThing(AbstractThing o) {
            // Dispose?
        }
        public FinalThing1 AcquireFinalThing1() {
            return new FinalThing1();
        }
        public void DiscardFinalThing1(FinalThing1 o) {
            // Dispose?
        }
        public FinalThing2 AcquireFinalThing2() {
            return new FinalThing2();
        }
        public void DiscardFinalThing2(FinalThing2 o) {
            // Dispose?
        }
        public AbstractReferenceObject AcquireAbstractReferenceObject() {
            return new AbstractReferenceObject();
        }
        public void DiscardAbstractReferenceObject(AbstractReferenceObject o) {
            // Dispose?
        }


        public byte[] AcquireByteArray(int size) {
            return new byte[size];
        }
        public void DiscardByteArray(byte[] bytes) {
            // Dispose?
        }
    }
}
