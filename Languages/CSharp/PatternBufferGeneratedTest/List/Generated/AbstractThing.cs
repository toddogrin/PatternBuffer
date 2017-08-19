
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class AbstractThing : IListTestObject, IEquatable<AbstractThing> {

        public const ushort TYPE_ID = 9;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue1; // (required)

        public AbstractThing() {
            this.IntValue1 = default(int);
        }

        public AbstractThing(
            int intValue1
        ) {
            this.IntValue1 = intValue1;
        }

        public bool Equals(AbstractThing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThing)) { return false; }
            AbstractThing that = (AbstractThing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue1 (required)
            if (this.IntValue1 != that.IntValue1) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IntValue1.GetHashCode();
                return hash;
            }
        }
    }
}
