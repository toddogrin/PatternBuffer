
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class FinalThing2 : AbstractThing, IEquatable <FinalThing2>, IFinalThing2 {
        public FinalThing2() {
            this.intValue1 = default(int);
            this.intValue2a = default(int);
        }

        public FinalThing2(
            int intValue1,
            int intValue2a
        ) {
            this.intValue1 = intValue1;
            this.intValue2a = intValue2a;
        }

        internal int intValue2a;
        public int IntValue2a {
            get { return this.intValue2a; }
            set { this.intValue2a = value; }
        }

        public bool Equals(FinalThing2 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is FinalThing2)) { return false; }
            FinalThing2 that = (FinalThing2)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intValue2a
            if (this.intValue2a != that.intValue2a) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + intValue1.GetHashCode();
                hash = (13*hash) + intValue2a.GetHashCode();
                return hash;
            }
        }
    }
}
