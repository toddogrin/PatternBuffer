
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing2 : AbstractThing, IListTestObject, IEquatable<Thing2> {

        public const ushort TYPE_ID = 11;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue3;

        public Thing2() {
            this.IntValue1 = default(int);
            this.IntValue3 = default(int);
        }

        public Thing2(
            int intValue1,
            int intValue3
        ) {
            this.IntValue1 = intValue1;
            this.IntValue3 = intValue3;
        }

        public bool Equals(Thing2 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing2)) { return false; }
            Thing2 that = (Thing2)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue3
            if (this.IntValue3 != that.IntValue3) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IntValue1.GetHashCode();
                hash = (13*hash) + this.IntValue3.GetHashCode();
                return hash;
            }
        }
    }
}
