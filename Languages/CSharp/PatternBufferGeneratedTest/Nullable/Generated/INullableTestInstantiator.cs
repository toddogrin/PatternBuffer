
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Nullable {
    public interface INullableTestInstantiator {
        Thing AcquireThing();
        void DiscardThing(Thing o);
        ThingContainer AcquireThingContainer();
        void DiscardThingContainer(ThingContainer o);
        AbstractThingContainer1 AcquireAbstractThingContainer1();
        void DiscardAbstractThingContainer1(AbstractThingContainer1 o);
        AbstractThingContainer2 AcquireAbstractThingContainer2();
        void DiscardAbstractThingContainer2(AbstractThingContainer2 o);
        ThingContainer3 AcquireThingContainer3();
        void DiscardThingContainer3(ThingContainer3 o);
        BaseType AcquireBaseType();
        void DiscardBaseType(BaseType o);
        DerivedType1 AcquireDerivedType1();
        void DiscardDerivedType1(DerivedType1 o);
        DerivedType2 AcquireDerivedType2();
        void DiscardDerivedType2(DerivedType2 o);
        BaseTypeContainer AcquireBaseTypeContainer();
        void DiscardBaseTypeContainer(BaseTypeContainer o);
        ListContainer AcquireListContainer();
        void DiscardListContainer(ListContainer o);
        SetContainer AcquireSetContainer();
        void DiscardSetContainer(SetContainer o);
        MapContainer AcquireMapContainer();
        void DiscardMapContainer(MapContainer o);
        IntThingContainerMap AcquireIntThingContainerMap();
        void DiscardIntThingContainerMap(IntThingContainerMap o);
        AutogenerateTest AcquireAutogenerateTest();
        void DiscardAutogenerateTest(AutogenerateTest o);

        List<int> AcquireListOfInt();
        void DiscardListOfInt(List<int> o);
        HashSet<int> AcquireHashSetOfInt();
        void DiscardHashSetOfInt(HashSet<int> o);
        Dictionary<int,short> AcquireDictionaryOfIntToShort();
        void DiscardDictionaryOfIntToShort(Dictionary<int,short> o);
        List<short> AcquireListOfShort();
        void DiscardListOfShort(List<short> o);
        Dictionary<int,ThingContainer> AcquireDictionaryOfIntToThingContainer();
        void DiscardDictionaryOfIntToThingContainer(Dictionary<int,ThingContainer> o);
        List<ThingContainer> AcquireListOfThingContainer();
        void DiscardListOfThingContainer(List<ThingContainer> o);

        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
