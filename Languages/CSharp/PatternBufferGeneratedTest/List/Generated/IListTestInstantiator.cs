
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.List {
    public interface IListTestInstantiator {
        AbstractThing AcquireAbstractThing();
        void DiscardAbstractThing(AbstractThing o);
        Thing1 AcquireThing1();
        void DiscardThing1(Thing1 o);
        Thing2 AcquireThing2();
        void DiscardThing2(Thing2 o);
        IntListObject AcquireIntListObject();
        void DiscardIntListObject(IntListObject o);
        StringListObject AcquireStringListObject();
        void DiscardStringListObject(StringListObject o);
        Thing1ListObject AcquireThing1ListObject();
        void DiscardThing1ListObject(Thing1ListObject o);
        AbstractThingListObject AcquireAbstractThingListObject();
        void DiscardAbstractThingListObject(AbstractThingListObject o);
        VIntListObject AcquireVIntListObject();
        void DiscardVIntListObject(VIntListObject o);

        List<int> AcquireListOfInt();
        void DiscardListOfInt(List<int> o);
        List<string> AcquireListOfString();
        void DiscardListOfString(List<string> o);
        List<Thing1> AcquireListOfThing1();
        void DiscardListOfThing1(List<Thing1> o);
        List<AbstractThing> AcquireListOfAbstractThing();
        void DiscardListOfAbstractThing(List<AbstractThing> o);

        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
