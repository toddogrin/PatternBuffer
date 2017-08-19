
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class BaseThingShouldBe17 : AbstractThingShouldBe0, IAutonumberTestObject, IEquatable<BaseThingShouldBe17> {

        public new const ushort TYPE_ID = 17;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno2; // (required)

        public BaseThingShouldBe17() {
            this.Dunno1 = default(bool);
            this.Dunno2 = default(bool);
        }

        public BaseThingShouldBe17(
            bool dunno1,
            bool dunno2
        ) {
            this.Dunno1 = dunno1;
            this.Dunno2 = dunno2;
        }

        public bool Equals(BaseThingShouldBe17 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is BaseThingShouldBe17)) { return false; }
            BaseThingShouldBe17 that = (BaseThingShouldBe17)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno2 (required)
            if (this.Dunno2 != that.Dunno2) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno1.GetHashCode();
                hash = (13*hash) + this.Dunno2.GetHashCode();
                return hash;
            }
        }
    }
}
