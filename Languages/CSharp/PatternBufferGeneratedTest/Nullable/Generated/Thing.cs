
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class Thing : INullableTestObject, IEquatable<Thing> {

        public const ushort TYPE_ID = 7;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int Value; // (required)

        public Thing() {
            this.Value = default(int);
        }

        public Thing(
            int value
        ) {
            this.Value = value;
        }

        public bool Equals(Thing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is Thing)) { return false; }
            Thing that = (Thing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Value (required)
            if (this.Value != that.Value) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Value.GetHashCode();
                return hash;
            }
        }
    }
}
