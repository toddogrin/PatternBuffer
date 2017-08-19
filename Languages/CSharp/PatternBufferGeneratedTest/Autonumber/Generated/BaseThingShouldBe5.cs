
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class BaseThingShouldBe5 : AbstractThingShouldBe0, IAutonumberTestObject, IEquatable<BaseThingShouldBe5> {

        public new const ushort TYPE_ID = 5;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno4; // (required)

        public BaseThingShouldBe5() {
            this.Dunno1 = default(bool);
            this.Dunno4 = default(bool);
        }

        public BaseThingShouldBe5(
            bool dunno1,
            bool dunno4
        ) {
            this.Dunno1 = dunno1;
            this.Dunno4 = dunno4;
        }

        public bool Equals(BaseThingShouldBe5 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is BaseThingShouldBe5)) { return false; }
            BaseThingShouldBe5 that = (BaseThingShouldBe5)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno4 (required)
            if (this.Dunno4 != that.Dunno4) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno1.GetHashCode();
                hash = (13*hash) + this.Dunno4.GetHashCode();
                return hash;
            }
        }
    }
}
