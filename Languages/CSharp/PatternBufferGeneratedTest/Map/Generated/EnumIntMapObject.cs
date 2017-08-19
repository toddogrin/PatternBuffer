
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class EnumIntMapObject : IMapTestObject, IEquatable<EnumIntMapObject> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<MyEnum,int> EnumIntMap; // (required)

        public EnumIntMapObject() {
            this.EnumIntMap = default(Dictionary<MyEnum,int>);
        }

        public EnumIntMapObject(
            Dictionary<MyEnum,int> enumIntMap
        ) {
            this.EnumIntMap = enumIntMap;
        }

        public bool Equals(EnumIntMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is EnumIntMapObject)) { return false; }
            EnumIntMapObject that = (EnumIntMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // EnumIntMap (required)
                if (this.EnumIntMap == null && that.EnumIntMap != null) { return false; }
                if (that.EnumIntMap != null && this.EnumIntMap == null) { return false; }
            if (that.EnumIntMap.Count != this.EnumIntMap.Count) { return false; }
            foreach (MyEnum key in this.EnumIntMap.Keys) {
                if ( ! that.EnumIntMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.EnumIntMap == null ? 0 : this.EnumIntMap.GetHashCode());
                return hash;
            }
        }
    }
}
