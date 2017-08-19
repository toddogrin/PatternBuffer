
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Enum {
    public interface IEnumTestInstantiator {
        EnumObject AcquireEnumObject();
        void DiscardEnumObject(EnumObject o);
        EnumListObject AcquireEnumListObject();
        void DiscardEnumListObject(EnumListObject o);
        EnumMapObject AcquireEnumMapObject();
        void DiscardEnumMapObject(EnumMapObject o);
        EnumMap2Object AcquireEnumMap2Object();
        void DiscardEnumMap2Object(EnumMap2Object o);
        EnumSetObject AcquireEnumSetObject();
        void DiscardEnumSetObject(EnumSetObject o);

        List<SomeEnum> AcquireListOfSomeEnum();
        void DiscardListOfSomeEnum(List<SomeEnum> o);
        Dictionary<int,SomeEnum> AcquireDictionaryOfIntToSomeEnum();
        void DiscardDictionaryOfIntToSomeEnum(Dictionary<int,SomeEnum> o);
        List<int> AcquireListOfInt();
        void DiscardListOfInt(List<int> o);
        Dictionary<SomeEnum,int> AcquireDictionaryOfSomeEnumToInt();
        void DiscardDictionaryOfSomeEnumToInt(Dictionary<SomeEnum,int> o);
        HashSet<SomeEnum> AcquireHashSetOfSomeEnum();
        void DiscardHashSetOfSomeEnum(HashSet<SomeEnum> o);

        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
