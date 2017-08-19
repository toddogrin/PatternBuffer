
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Map {
    public interface IMapTestInstantiator {
        AbstractThing AcquireAbstractThing();
        void DiscardAbstractThing(AbstractThing o);
        Thing AcquireThing();
        void DiscardThing(Thing o);
        IntThingMapObject AcquireIntThingMapObject();
        void DiscardIntThingMapObject(IntThingMapObject o);
        ThingIntMapObject AcquireThingIntMapObject();
        void DiscardThingIntMapObject(ThingIntMapObject o);
        IntStringMapObject AcquireIntStringMapObject();
        void DiscardIntStringMapObject(IntStringMapObject o);
        ThingThingMapObject AcquireThingThingMapObject();
        void DiscardThingThingMapObject(ThingThingMapObject o);
        EnumIntMapObject AcquireEnumIntMapObject();
        void DiscardEnumIntMapObject(EnumIntMapObject o);
        VIntVLongMapObject AcquireVIntVLongMapObject();
        void DiscardVIntVLongMapObject(VIntVLongMapObject o);
        IntAbstractThingMapObject AcquireIntAbstractThingMapObject();
        void DiscardIntAbstractThingMapObject(IntAbstractThingMapObject o);

        Dictionary<int,Thing> AcquireDictionaryOfIntToThing();
        void DiscardDictionaryOfIntToThing(Dictionary<int,Thing> o);
        List<int> AcquireListOfInt();
        void DiscardListOfInt(List<int> o);
        List<Thing> AcquireListOfThing();
        void DiscardListOfThing(List<Thing> o);
        Dictionary<Thing,int> AcquireDictionaryOfThingToInt();
        void DiscardDictionaryOfThingToInt(Dictionary<Thing,int> o);
        Dictionary<int,string> AcquireDictionaryOfIntToString();
        void DiscardDictionaryOfIntToString(Dictionary<int,string> o);
        List<string> AcquireListOfString();
        void DiscardListOfString(List<string> o);
        Dictionary<Thing,Thing> AcquireDictionaryOfThingToThing();
        void DiscardDictionaryOfThingToThing(Dictionary<Thing,Thing> o);
        Dictionary<MyEnum,int> AcquireDictionaryOfMyEnumToInt();
        void DiscardDictionaryOfMyEnumToInt(Dictionary<MyEnum,int> o);
        List<MyEnum> AcquireListOfMyEnum();
        void DiscardListOfMyEnum(List<MyEnum> o);
        Dictionary<int,long> AcquireDictionaryOfIntToLong();
        void DiscardDictionaryOfIntToLong(Dictionary<int,long> o);
        List<long> AcquireListOfLong();
        void DiscardListOfLong(List<long> o);
        Dictionary<int,AbstractThing> AcquireDictionaryOfIntToAbstractThing();
        void DiscardDictionaryOfIntToAbstractThing(Dictionary<int,AbstractThing> o);
        List<AbstractThing> AcquireListOfAbstractThing();
        void DiscardListOfAbstractThing(List<AbstractThing> o);

        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
