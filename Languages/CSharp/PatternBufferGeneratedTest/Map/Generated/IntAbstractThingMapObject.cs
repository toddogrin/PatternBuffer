
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class IntAbstractThingMapObject : IMapTestObject, IEquatable<IntAbstractThingMapObject> {

        public const ushort TYPE_ID = 17;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,AbstractThing> IntAbstractThingMap; // (required)

        public IntAbstractThingMapObject() {
            this.IntAbstractThingMap = default(Dictionary<int,AbstractThing>);
        }

        public IntAbstractThingMapObject(
            Dictionary<int,AbstractThing> intAbstractThingMap
        ) {
            this.IntAbstractThingMap = intAbstractThingMap;
        }

        public bool Equals(IntAbstractThingMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is IntAbstractThingMapObject)) { return false; }
            IntAbstractThingMapObject that = (IntAbstractThingMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntAbstractThingMap (required)
                if (this.IntAbstractThingMap == null && that.IntAbstractThingMap != null) { return false; }
                if (that.IntAbstractThingMap != null && this.IntAbstractThingMap == null) { return false; }
            if (that.IntAbstractThingMap.Count != this.IntAbstractThingMap.Count) { return false; }
            foreach (int key in this.IntAbstractThingMap.Keys) {
                if ( ! that.IntAbstractThingMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntAbstractThingMap == null ? 0 : this.IntAbstractThingMap.GetHashCode());
                return hash;
            }
        }
    }
}
