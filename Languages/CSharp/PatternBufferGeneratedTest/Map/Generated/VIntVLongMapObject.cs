
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class VIntVLongMapObject : IMapTestObject, IEquatable<VIntVLongMapObject> {

        public const ushort TYPE_ID = 16;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,long> VintVlongMap; // (required)

        public VIntVLongMapObject() {
            this.VintVlongMap = default(Dictionary<int,long>);
        }

        public VIntVLongMapObject(
            Dictionary<int,long> vintVlongMap
        ) {
            this.VintVlongMap = vintVlongMap;
        }

        public bool Equals(VIntVLongMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is VIntVLongMapObject)) { return false; }
            VIntVLongMapObject that = (VIntVLongMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VintVlongMap (required)
                if (this.VintVlongMap == null && that.VintVlongMap != null) { return false; }
                if (that.VintVlongMap != null && this.VintVlongMap == null) { return false; }
            if (that.VintVlongMap.Count != this.VintVlongMap.Count) { return false; }
            foreach (int key in this.VintVlongMap.Keys) {
                if ( ! that.VintVlongMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.VintVlongMap == null ? 0 : this.VintVlongMap.GetHashCode());
                return hash;
            }
        }
    }
}
