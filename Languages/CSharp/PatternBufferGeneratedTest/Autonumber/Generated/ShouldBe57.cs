
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class ShouldBe57 : BaseThingShouldBe5, IAutonumberTestObject, IEquatable<ShouldBe57> {

        public new const ushort TYPE_ID = 57;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno5; // (required)

        public ShouldBe57() {
            this.Dunno1 = default(bool);
            this.Dunno4 = default(bool);
            this.Dunno5 = default(bool);
        }

        public ShouldBe57(
            bool dunno1,
            bool dunno4,
            bool dunno5
        ) {
            this.Dunno1 = dunno1;
            this.Dunno4 = dunno4;
            this.Dunno5 = dunno5;
        }

        public bool Equals(ShouldBe57 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ShouldBe57)) { return false; }
            ShouldBe57 that = (ShouldBe57)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno5 (required)
            if (this.Dunno5 != that.Dunno5) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno1.GetHashCode();
                hash = (13*hash) + this.Dunno4.GetHashCode();
                hash = (13*hash) + this.Dunno5.GetHashCode();
                return hash;
            }
        }
    }
}
