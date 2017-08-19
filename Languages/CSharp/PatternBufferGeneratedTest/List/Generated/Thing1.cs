
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing1 : AbstractThing, IListTestObject, IEquatable<Thing1> {

        public new const ushort TYPE_ID = 10;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue2; // (required)

        public Thing1() {
            this.IntValue1 = default(int);
            this.IntValue2 = default(int);
        }

        public Thing1(
            int intValue1,
            int intValue2
        ) {
            this.IntValue1 = intValue1;
            this.IntValue2 = intValue2;
        }

        public bool Equals(Thing1 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is Thing1)) { return false; }
            Thing1 that = (Thing1)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue2 (required)
            if (this.IntValue2 != that.IntValue2) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IntValue1.GetHashCode();
                hash = (13*hash) + this.IntValue2.GetHashCode();
                return hash;
            }
        }
    }
}
