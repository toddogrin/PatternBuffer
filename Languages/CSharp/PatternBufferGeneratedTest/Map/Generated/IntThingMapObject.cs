
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class IntThingMapObject : IMapTestObject, IEquatable<IntThingMapObject> {

        public const ushort TYPE_ID = 11;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,Thing> IntThingMap;

        public IntThingMapObject() {
            this.IntThingMap = default(Dictionary<int,Thing>);
        }

        public IntThingMapObject(
            Dictionary<int,Thing> intThingMap
        ) {
            this.IntThingMap = intThingMap;
        }

        public bool Equals(IntThingMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntThingMapObject)) { return false; }
            IntThingMapObject that = (IntThingMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntThingMap
            if (this.IntThingMap == null && that.IntThingMap != null) { return false; }
            if (that.IntThingMap != null && this.IntThingMap == null) { return false; }
            if (that.IntThingMap.Count != this.IntThingMap.Count) { return false; }
            foreach (int key in this.IntThingMap.Keys) {
                if ( ! that.IntThingMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntThingMap == null ? 0 : this.IntThingMap.GetHashCode());
                return hash;
            }
        }
    }
}
