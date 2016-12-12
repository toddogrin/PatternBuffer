
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class EnumIntMapObject : IEquatable <EnumIntMapObject>, IEnumIntMapObject {
        public EnumIntMapObject() {
            this.enumIntMap = default(Dictionary<MyEnum,int>);
        }

        public EnumIntMapObject(
            Dictionary<MyEnum,int> enumIntMap
        ) {
            this.enumIntMap = enumIntMap;
        }

        internal Dictionary<MyEnum,int> enumIntMap;
        public Dictionary<MyEnum,int> EnumIntMap {
            get { return this.enumIntMap; }
            set { this.enumIntMap = value; }
        }

        public bool Equals(EnumIntMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumIntMapObject)) { return false; }
            EnumIntMapObject that = (EnumIntMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // enumIntMap
            if (this.enumIntMap == null && that.enumIntMap != null) { return false; }
            if (that.enumIntMap != null && this.enumIntMap == null) { return false; }
            if (that.enumIntMap.Count != this.enumIntMap.Count) { return false; }
            foreach (MyEnum key in this.enumIntMap.Keys) {
                if ( ! that.enumIntMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (enumIntMap == null ? 0 : enumIntMap.GetHashCode());
                return hash;
            }
        }
    }
}
