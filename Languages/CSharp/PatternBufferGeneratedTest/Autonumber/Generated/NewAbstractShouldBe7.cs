
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Autonumber {
    public class NewAbstractShouldBe7 : IAutonumberTestObject, IEquatable<NewAbstractShouldBe7> {

        public const ushort TYPE_ID = 7;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool Dunno7; // (required)

        public NewAbstractShouldBe7() {
            this.Dunno7 = default(bool);
        }

        public NewAbstractShouldBe7(
            bool dunno7
        ) {
            this.Dunno7 = dunno7;
        }

        public bool Equals(NewAbstractShouldBe7 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is NewAbstractShouldBe7)) { return false; }
            NewAbstractShouldBe7 that = (NewAbstractShouldBe7)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Dunno7 (required)
            if (this.Dunno7 != that.Dunno7) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Dunno7.GetHashCode();
                return hash;
            }
        }
    }
}
