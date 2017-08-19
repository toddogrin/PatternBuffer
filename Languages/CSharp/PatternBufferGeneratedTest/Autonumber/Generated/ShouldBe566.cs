
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class ShouldBe566 : IAutonumberTestObject, IEquatable<ShouldBe566> {

        public const ushort TYPE_ID = 566;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno566; // (required)

        public ShouldBe566() {
            this.Dunno566 = default(bool);
        }

        public ShouldBe566(
            bool dunno566
        ) {
            this.Dunno566 = dunno566;
        }

        public bool Equals(ShouldBe566 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ShouldBe566)) { return false; }
            ShouldBe566 that = (ShouldBe566)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno566 (required)
            if (this.Dunno566 != that.Dunno566) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno566.GetHashCode();
                return hash;
            }
        }
    }
}
