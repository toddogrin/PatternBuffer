
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing2 : AbstractThing, IEquatable <Thing2>, IThing2 {
        public Thing2() {
            this.intValue1 = default(int);
            this.intValue3 = default(int);
        }

        public Thing2(
            int intValue1,
            int intValue3
        ) {
            this.intValue1 = intValue1;
            this.intValue3 = intValue3;
        }

        internal int intValue3;
        public int IntValue3 {
            get { return this.intValue3; }
            set { this.intValue3 = value; }
        }

        public bool Equals(Thing2 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing2)) { return false; }
            Thing2 that = (Thing2)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intValue3
            if (this.intValue3 != that.intValue3) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + intValue1.GetHashCode();
                hash = (13*hash) + intValue3.GetHashCode();
                return hash;
            }
        }
    }
}
