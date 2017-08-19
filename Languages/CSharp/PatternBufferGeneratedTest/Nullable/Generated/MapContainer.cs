
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class MapContainer : INullableTestObject, IEquatable<MapContainer> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,short> IntShortMap; // (required)

        public MapContainer() {
            this.IntShortMap = default(Dictionary<int,short>);
        }

        public MapContainer(
            Dictionary<int,short> intShortMap
        ) {
            this.IntShortMap = intShortMap;
        }

        public bool Equals(MapContainer other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is MapContainer)) { return false; }
            MapContainer that = (MapContainer)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntShortMap (required)
                if (this.IntShortMap == null && that.IntShortMap != null) { return false; }
                if (that.IntShortMap != null && this.IntShortMap == null) { return false; }
            if (that.IntShortMap.Count != this.IntShortMap.Count) { return false; }
            foreach (int key in this.IntShortMap.Keys) {
                if ( ! that.IntShortMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntShortMap == null ? 0 : this.IntShortMap.GetHashCode());
                return hash;
            }
        }
    }
}
