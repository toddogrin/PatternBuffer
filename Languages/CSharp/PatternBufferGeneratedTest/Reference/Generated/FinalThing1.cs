
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class FinalThing1 : AbstractThing, IReferenceTestObject, IEquatable<FinalThing1> {

        public new const ushort TYPE_ID = 22;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue2a; // (required)

        public FinalThing1() {
            this.IntValue1 = default(int);
            this.IntValue2a = default(int);
        }

        public FinalThing1(
            int intValue1,
            int intValue2a
        ) {
            this.IntValue1 = intValue1;
            this.IntValue2a = intValue2a;
        }

        public bool Equals(FinalThing1 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is FinalThing1)) { return false; }
            FinalThing1 that = (FinalThing1)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue2a (required)
            if (this.IntValue2a != that.IntValue2a) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IntValue1.GetHashCode();
                hash = (13*hash) + this.IntValue2a.GetHashCode();
                return hash;
            }
        }
    }
}
