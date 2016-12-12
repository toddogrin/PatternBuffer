
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class Thing : IEquatable <Thing>, IThing {
        public Thing() {
            this.intValue = default(int);
        }

        public Thing(
            int intValue
        ) {
            this.intValue = intValue;
        }

        internal int intValue;
        public int IntValue {
            get { return this.intValue; }
            set { this.intValue = value; }
        }

        public bool Equals(Thing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing)) { return false; }
            Thing that = (Thing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intValue
            if (this.intValue != that.intValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + intValue.GetHashCode();
                return hash;
            }
        }
    }
}
