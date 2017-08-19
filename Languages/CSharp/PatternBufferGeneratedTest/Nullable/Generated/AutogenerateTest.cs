
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class AutogenerateTest : INullableTestObject, IEquatable<AutogenerateTest> {

        public const ushort TYPE_ID = 1;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int Value; // (required)

        public AutogenerateTest() {
            this.Value = default(int);
        }

        public AutogenerateTest(
            int value
        ) {
            this.Value = value;
        }

        public bool Equals(AutogenerateTest other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AutogenerateTest)) { return false; }
            AutogenerateTest that = (AutogenerateTest)other;
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
