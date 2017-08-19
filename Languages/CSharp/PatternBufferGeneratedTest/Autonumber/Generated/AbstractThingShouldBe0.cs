
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class AbstractThingShouldBe0 : IAutonumberTestObject, IEquatable<AbstractThingShouldBe0> {

        public const ushort TYPE_ID = 0;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno1; // (required)

        public AbstractThingShouldBe0() {
            this.Dunno1 = default(bool);
        }

        public AbstractThingShouldBe0(
            bool dunno1
        ) {
            this.Dunno1 = dunno1;
        }

        public bool Equals(AbstractThingShouldBe0 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThingShouldBe0)) { return false; }
            AbstractThingShouldBe0 that = (AbstractThingShouldBe0)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno1 (required)
            if (this.Dunno1 != that.Dunno1) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno1.GetHashCode();
                return hash;
            }
        }
    }
}
