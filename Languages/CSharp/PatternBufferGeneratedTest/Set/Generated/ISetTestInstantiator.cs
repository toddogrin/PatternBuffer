
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Set {
    public interface ISetTestInstantiator {
        AbstractThing AcquireAbstractThing();
        void DiscardAbstractThing(AbstractThing o);
        Thing1 AcquireThing1();
        void DiscardThing1(Thing1 o);
        Thing2 AcquireThing2();
        void DiscardThing2(Thing2 o);
        IntSetObject AcquireIntSetObject();
        void DiscardIntSetObject(IntSetObject o);
        StringSetObject AcquireStringSetObject();
        void DiscardStringSetObject(StringSetObject o);
        Thing1SetObject AcquireThing1SetObject();
        void DiscardThing1SetObject(Thing1SetObject o);
        AbstractThingSetObject AcquireAbstractThingSetObject();
        void DiscardAbstractThingSetObject(AbstractThingSetObject o);
        VIntSetObject AcquireVIntSetObject();
        void DiscardVIntSetObject(VIntSetObject o);

        HashSet<int> AcquireHashSetOfInt();
        void DiscardHashSetOfInt(HashSet<int> o);
        HashSet<string> AcquireHashSetOfString();
        void DiscardHashSetOfString(HashSet<string> o);
        HashSet<Thing1> AcquireHashSetOfThing1();
        void DiscardHashSetOfThing1(HashSet<Thing1> o);
        HashSet<AbstractThing> AcquireHashSetOfAbstractThing();
        void DiscardHashSetOfAbstractThing(HashSet<AbstractThing> o);

        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
