
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class IntStringMapObject : IMapTestObject, IEquatable<IntStringMapObject> {

        public const ushort TYPE_ID = 13;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,string> IntStringMap; // (required)

        public IntStringMapObject() {
            this.IntStringMap = default(Dictionary<int,string>);
        }

        public IntStringMapObject(
            Dictionary<int,string> intStringMap
        ) {
            this.IntStringMap = intStringMap;
        }

        public bool Equals(IntStringMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is IntStringMapObject)) { return false; }
            IntStringMapObject that = (IntStringMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntStringMap (required)
                if (this.IntStringMap == null && that.IntStringMap != null) { return false; }
                if (that.IntStringMap != null && this.IntStringMap == null) { return false; }
            if (that.IntStringMap.Count != this.IntStringMap.Count) { return false; }
            foreach (int key in this.IntStringMap.Keys) {
                if ( ! that.IntStringMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntStringMap == null ? 0 : this.IntStringMap.GetHashCode());
                return hash;
            }
        }
    }
}
