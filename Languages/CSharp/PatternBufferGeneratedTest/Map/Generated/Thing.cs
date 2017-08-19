
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class Thing : AbstractThing, IMapTestObject, IEquatable<Thing> {

        public new const ushort TYPE_ID = 10;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue; // (required)

        public Thing() {
            this.IsSomething = default(bool);
            this.IntValue = default(int);
        }

        public Thing(
            bool isSomething,
            int intValue
        ) {
            this.IsSomething = isSomething;
            this.IntValue = intValue;
        }

        public bool Equals(Thing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is Thing)) { return false; }
            Thing that = (Thing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue (required)
            if (this.IntValue != that.IntValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IsSomething.GetHashCode();
                hash = (13*hash) + this.IntValue.GetHashCode();
                return hash;
            }
        }
    }
}
