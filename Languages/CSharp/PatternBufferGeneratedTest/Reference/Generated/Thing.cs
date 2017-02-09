
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class Thing : IReferenceTestObject, IEquatable<Thing> {

        public const ushort TYPE_ID = 11;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue;

        public Thing() {
            this.IntValue = default(int);
        }

        public Thing(
            int intValue
        ) {
            this.IntValue = intValue;
        }

        public bool Equals(Thing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing)) { return false; }
            Thing that = (Thing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue
            if (this.IntValue != that.IntValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IntValue.GetHashCode();
                return hash;
            }
        }
    }
}
