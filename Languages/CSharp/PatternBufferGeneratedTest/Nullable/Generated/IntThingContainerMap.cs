
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class IntThingContainerMap : INullableTestObject, IEquatable<IntThingContainerMap> {

        public const ushort TYPE_ID = 16;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,ThingContainer> TheMap; // (required)

        public IntThingContainerMap() {
            this.TheMap = default(Dictionary<int,ThingContainer>);
        }

        public IntThingContainerMap(
            Dictionary<int,ThingContainer> theMap
        ) {
            this.TheMap = theMap;
        }

        public bool Equals(IntThingContainerMap other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is IntThingContainerMap)) { return false; }
            IntThingContainerMap that = (IntThingContainerMap)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // TheMap (required)
                if (this.TheMap == null && that.TheMap != null) { return false; }
                if (that.TheMap != null && this.TheMap == null) { return false; }
            if (that.TheMap.Count != this.TheMap.Count) { return false; }
            foreach (int key in this.TheMap.Keys) {
                if ( ! that.TheMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.TheMap == null ? 0 : this.TheMap.GetHashCode());
                return hash;
            }
        }
    }
}
