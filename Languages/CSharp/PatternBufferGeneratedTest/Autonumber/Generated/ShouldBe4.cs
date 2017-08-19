
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class ShouldBe4 : BaseThingShouldBe17, IAutonumberTestObject, IEquatable<ShouldBe4> {

        public new const ushort TYPE_ID = 4;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno3; // (required)

        public ShouldBe4() {
            this.Dunno1 = default(bool);
            this.Dunno2 = default(bool);
            this.Dunno3 = default(bool);
        }

        public ShouldBe4(
            bool dunno1,
            bool dunno2,
            bool dunno3
        ) {
            this.Dunno1 = dunno1;
            this.Dunno2 = dunno2;
            this.Dunno3 = dunno3;
        }

        public bool Equals(ShouldBe4 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ShouldBe4)) { return false; }
            ShouldBe4 that = (ShouldBe4)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno3 (required)
            if (this.Dunno3 != that.Dunno3) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno1.GetHashCode();
                hash = (13*hash) + this.Dunno2.GetHashCode();
                hash = (13*hash) + this.Dunno3.GetHashCode();
                return hash;
            }
        }
    }
}
