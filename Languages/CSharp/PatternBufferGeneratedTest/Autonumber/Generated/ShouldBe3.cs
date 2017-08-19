
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class ShouldBe3 : IAutonumberTestObject, IEquatable<ShouldBe3> {

        public const ushort TYPE_ID = 3;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int Value; // (required)

        public ShouldBe3() {
            this.Value = default(int);
        }

        public ShouldBe3(
            int value
        ) {
            this.Value = value;
        }

        public bool Equals(ShouldBe3 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ShouldBe3)) { return false; }
            ShouldBe3 that = (ShouldBe3)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Value (required)
            if (this.Value != that.Value) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Value.GetHashCode();
                return hash;
            }
        }
    }
}
