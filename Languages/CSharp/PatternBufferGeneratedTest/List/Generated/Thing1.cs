
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing1 : AbstractThing, IEquatable <Thing1>, IThing1 {
        public Thing1() {
            this.intValue1 = default(int);
            this.intValue2 = default(int);
        }

        public Thing1(
            int intValue1,
            int intValue2
        ) {
            this.intValue1 = intValue1;
            this.intValue2 = intValue2;
        }

        internal int intValue2;
        public int IntValue2 {
            get { return this.intValue2; }
            set { this.intValue2 = value; }
        }

        public bool Equals(Thing1 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing1)) { return false; }
            Thing1 that = (Thing1)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intValue2
            if (this.intValue2 != that.intValue2) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + intValue1.GetHashCode();
                hash = (13*hash) + intValue2.GetHashCode();
                return hash;
            }
        }
    }
}
