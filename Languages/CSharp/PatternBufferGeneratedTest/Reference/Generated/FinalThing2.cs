
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class FinalThing2 : AbstractThing, IReferenceTestObject, IEquatable<FinalThing2> {

        public const ushort TYPE_ID = 23;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue2a;

        public FinalThing2() {
            this.IntValue1 = default(int);
            this.IntValue2a = default(int);
        }

        public FinalThing2(
            int intValue1,
            int intValue2a
        ) {
            this.IntValue1 = intValue1;
            this.IntValue2a = intValue2a;
        }

        public bool Equals(FinalThing2 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is FinalThing2)) { return false; }
            FinalThing2 that = (FinalThing2)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue2a
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
