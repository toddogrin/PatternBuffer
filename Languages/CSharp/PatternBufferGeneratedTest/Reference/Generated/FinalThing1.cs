
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class FinalThing1 : AbstractThing, IEquatable <FinalThing1>, IFinalThing1 {
        public FinalThing1() {
            this.intValue1 = default(int);
            this.intValue2a = default(int);
        }

        public FinalThing1(
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

        public bool Equals(FinalThing1 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is FinalThing1)) { return false; }
            FinalThing1 that = (FinalThing1)other;
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
