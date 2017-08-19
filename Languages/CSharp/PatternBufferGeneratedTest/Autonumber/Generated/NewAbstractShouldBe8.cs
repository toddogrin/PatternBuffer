
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class NewAbstractShouldBe8 : IAutonumberTestObject, IEquatable<NewAbstractShouldBe8> {

        public const ushort TYPE_ID = 8;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno8; // (required)

        public NewAbstractShouldBe8() {
            this.Dunno8 = default(bool);
        }

        public NewAbstractShouldBe8(
            bool dunno8
        ) {
            this.Dunno8 = dunno8;
        }

        public bool Equals(NewAbstractShouldBe8 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is NewAbstractShouldBe8)) { return false; }
            NewAbstractShouldBe8 that = (NewAbstractShouldBe8)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno8 (required)
            if (this.Dunno8 != that.Dunno8) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno8.GetHashCode();
                return hash;
            }
        }
    }
}
