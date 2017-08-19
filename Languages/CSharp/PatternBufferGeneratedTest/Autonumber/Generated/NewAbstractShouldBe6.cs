
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class NewAbstractShouldBe6 : IAutonumberTestObject, IEquatable<NewAbstractShouldBe6> {

        public const ushort TYPE_ID = 6;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno6; // (required)

        public NewAbstractShouldBe6() {
            this.Dunno6 = default(bool);
        }

        public NewAbstractShouldBe6(
            bool dunno6
        ) {
            this.Dunno6 = dunno6;
        }

        public bool Equals(NewAbstractShouldBe6 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is NewAbstractShouldBe6)) { return false; }
            NewAbstractShouldBe6 that = (NewAbstractShouldBe6)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno6 (required)
            if (this.Dunno6 != that.Dunno6) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno6.GetHashCode();
                return hash;
            }
        }
    }
}
