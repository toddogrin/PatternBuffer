
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Enum {
    public class DefaultEnumTestInstantiator : IEnumTestInstantiator {
        public EnumObject AcquireEnumObject() {
            return new EnumObject();
        }
        public void DiscardEnumObject(EnumObject o) {
            // Dispose?
        }
        public EnumListObject AcquireEnumListObject() {
            return new EnumListObject();
        }
        public void DiscardEnumListObject(EnumListObject o) {
            // Dispose?
        }
        public EnumMapObject AcquireEnumMapObject() {
            return new EnumMapObject();
        }
        public void DiscardEnumMapObject(EnumMapObject o) {
            // Dispose?
        }
        public EnumMap2Object AcquireEnumMap2Object() {
            return new EnumMap2Object();
        }
        public void DiscardEnumMap2Object(EnumMap2Object o) {
            // Dispose?
        }
        public EnumSetObject AcquireEnumSetObject() {
            return new EnumSetObject();
        }
        public void DiscardEnumSetObject(EnumSetObject o) {
            // Dispose?
        }

        public List<SomeEnum> AcquireListOfSomeEnum() {
            return new List<SomeEnum>();
        }
        public void DiscardListOfSomeEnum(List<SomeEnum> o) {
            // Dispose?
        }
        public Dictionary<int,SomeEnum> AcquireDictionaryOfIntToSomeEnum() {
            return new Dictionary<int,SomeEnum>();
        }
        public void DiscardDictionaryOfIntToSomeEnum(Dictionary<int,SomeEnum> o) {
            // Dispose?
        }
        public List<int> AcquireListOfInt() {
            return new List<int>();
        }
        public void DiscardListOfInt(List<int> o) {
            // Dispose?
        }
        public Dictionary<SomeEnum,int> AcquireDictionaryOfSomeEnumToInt() {
            return new Dictionary<SomeEnum,int>();
        }
        public void DiscardDictionaryOfSomeEnumToInt(Dictionary<SomeEnum,int> o) {
            // Dispose?
        }
        public HashSet<SomeEnum> AcquireHashSetOfSomeEnum() {
            return new HashSet<SomeEnum>();
        }
        public void DiscardHashSetOfSomeEnum(HashSet<SomeEnum> o) {
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
