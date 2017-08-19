
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class ThingThingMapObject : IMapTestObject, IEquatable<ThingThingMapObject> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<Thing,Thing> ThingThingMap; // (required)

        public ThingThingMapObject() {
            this.ThingThingMap = default(Dictionary<Thing,Thing>);
        }

        public ThingThingMapObject(
            Dictionary<Thing,Thing> thingThingMap
        ) {
            this.ThingThingMap = thingThingMap;
        }

        public bool Equals(ThingThingMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ThingThingMapObject)) { return false; }
            ThingThingMapObject that = (ThingThingMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingThingMap (required)
                if (this.ThingThingMap == null && that.ThingThingMap != null) { return false; }
                if (that.ThingThingMap != null && this.ThingThingMap == null) { return false; }
            if (that.ThingThingMap.Count != this.ThingThingMap.Count) { return false; }
            foreach (Thing key in this.ThingThingMap.Keys) {
                if ( ! that.ThingThingMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.ThingThingMap == null ? 0 : this.ThingThingMap.GetHashCode());
                return hash;
            }
        }
    }
}
