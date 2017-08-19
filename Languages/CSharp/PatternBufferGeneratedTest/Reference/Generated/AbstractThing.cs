
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class AbstractThing : IReferenceTestObject, IEquatable<AbstractThing> {

        public const ushort TYPE_ID = 0;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue1;

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
            if (other == null) { return false; }
            if ( ! (other is AbstractThing)) { return false; }
            AbstractThing that = (AbstractThing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue1
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
