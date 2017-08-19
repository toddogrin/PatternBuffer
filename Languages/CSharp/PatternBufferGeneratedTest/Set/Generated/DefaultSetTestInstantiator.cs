
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Set {
    public class DefaultSetTestInstantiator : ISetTestInstantiator {
        public AbstractThing AcquireAbstractThing() {
            return new AbstractThing();
        }
        public void DiscardAbstractThing(AbstractThing o) {
            // Dispose?
        }
        public Thing1 AcquireThing1() {
            return new Thing1();
        }
        public void DiscardThing1(Thing1 o) {
            // Dispose?
        }
        public Thing2 AcquireThing2() {
            return new Thing2();
        }
        public void DiscardThing2(Thing2 o) {
            // Dispose?
        }
        public IntSetObject AcquireIntSetObject() {
            return new IntSetObject();
        }
        public void DiscardIntSetObject(IntSetObject o) {
            // Dispose?
        }
        public StringSetObject AcquireStringSetObject() {
            return new StringSetObject();
        }
        public void DiscardStringSetObject(StringSetObject o) {
            // Dispose?
        }
        public Thing1SetObject AcquireThing1SetObject() {
            return new Thing1SetObject();
        }
        public void DiscardThing1SetObject(Thing1SetObject o) {
            // Dispose?
        }
        public AbstractThingSetObject AcquireAbstractThingSetObject() {
            return new AbstractThingSetObject();
        }
        public void DiscardAbstractThingSetObject(AbstractThingSetObject o) {
            // Dispose?
        }
        public VIntSetObject AcquireVIntSetObject() {
            return new VIntSetObject();
        }
        public void DiscardVIntSetObject(VIntSetObject o) {
            // Dispose?
        }

        public HashSet<int> AcquireHashSetOfInt() {
            return new HashSet<int>();
        }
        public void DiscardHashSetOfInt(HashSet<int> o) {
            // Dispose?
        }
        public HashSet<string> AcquireHashSetOfString() {
            return new HashSet<string>();
        }
        public void DiscardHashSetOfString(HashSet<string> o) {
            // Dispose?
        }
        public HashSet<Thing1> AcquireHashSetOfThing1() {
            return new HashSet<Thing1>();
        }
        public void DiscardHashSetOfThing1(HashSet<Thing1> o) {
            // Dispose?
        }
        public HashSet<AbstractThing> AcquireHashSetOfAbstractThing() {
            return new HashSet<AbstractThing>();
        }
        public void DiscardHashSetOfAbstractThing(HashSet<AbstractThing> o) {
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
