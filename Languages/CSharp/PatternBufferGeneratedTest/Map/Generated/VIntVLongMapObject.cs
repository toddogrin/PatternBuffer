
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class VIntVLongMapObject : IEquatable <VIntVLongMapObject>, IVIntVLongMapObject {
        public VIntVLongMapObject() {
            this.vintVlongMap = default(Dictionary<int,long>);
        }

        public VIntVLongMapObject(
            Dictionary<int,long> vintVlongMap
        ) {
            this.vintVlongMap = vintVlongMap;
        }

        internal Dictionary<int,long> vintVlongMap;
        public Dictionary<int,long> VintVlongMap {
            get { return this.vintVlongMap; }
            set { this.vintVlongMap = value; }
        }

        public bool Equals(VIntVLongMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntVLongMapObject)) { return false; }
            VIntVLongMapObject that = (VIntVLongMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vintVlongMap
            if (this.vintVlongMap == null && that.vintVlongMap != null) { return false; }
            if (that.vintVlongMap != null && this.vintVlongMap == null) { return false; }
            if (that.vintVlongMap.Count != this.vintVlongMap.Count) { return false; }
            foreach (int key in this.vintVlongMap.Keys) {
                if ( ! that.vintVlongMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (vintVlongMap == null ? 0 : vintVlongMap.GetHashCode());
                return hash;
            }
        }
    }
}
