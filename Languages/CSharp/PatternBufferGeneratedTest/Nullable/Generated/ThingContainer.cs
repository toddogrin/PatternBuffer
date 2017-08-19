
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class ThingContainer : INullableTestObject, IEquatable<ThingContainer> {

        public const ushort TYPE_ID = 8;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Thing Thing1; // (optional)
        public Thing Thing2; // (optional)
        public Thing Thing3; // (optional)
        public Thing Thing4; // (optional)
        public Thing Thing5; // (optional)
        public int IntValue1; // (required)
        public Thing Thing6; // (optional)
        public Thing Thing7; // (optional)
        public Thing Thing8; // (optional)
        public Thing Thing9; // (optional)
        public int IntValue2; // (required)
        public Thing Thing10; // (optional)

        public ThingContainer() {
            this.Thing1 = default(Thing);
            this.Thing2 = default(Thing);
            this.Thing3 = default(Thing);
            this.Thing4 = default(Thing);
            this.Thing5 = default(Thing);
            this.IntValue1 = default(int);
            this.Thing6 = default(Thing);
            this.Thing7 = default(Thing);
            this.Thing8 = default(Thing);
            this.Thing9 = default(Thing);
            this.IntValue2 = default(int);
            this.Thing10 = default(Thing);
        }

        public ThingContainer(
            Thing thing1,
            Thing thing2,
            Thing thing3,
            Thing thing4,
            Thing thing5,
            int intValue1,
            Thing thing6,
            Thing thing7,
            Thing thing8,
            Thing thing9,
            int intValue2,
            Thing thing10
        ) {
            this.Thing1 = thing1;
            this.Thing2 = thing2;
            this.Thing3 = thing3;
            this.Thing4 = thing4;
            this.Thing5 = thing5;
            this.IntValue1 = intValue1;
            this.Thing6 = thing6;
            this.Thing7 = thing7;
            this.Thing8 = thing8;
            this.Thing9 = thing9;
            this.IntValue2 = intValue2;
            this.Thing10 = thing10;
        }

        public bool Equals(ThingContainer other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ThingContainer)) { return false; }
            ThingContainer that = (ThingContainer)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Thing1 (optional)
            if ( ! (this.Thing1 == null && that.Thing1 == null)) {
                if (this.Thing1 == null && that.Thing1 != null) { return false; }
                if (that.Thing1 != null && this.Thing1 == null) { return false; }
            if ( ! this.Thing1.Equals(that.Thing1)) { return false; }
            }
            // Thing2 (optional)
            if ( ! (this.Thing2 == null && that.Thing2 == null)) {
                if (this.Thing2 == null && that.Thing2 != null) { return false; }
                if (that.Thing2 != null && this.Thing2 == null) { return false; }
            if ( ! this.Thing2.Equals(that.Thing2)) { return false; }
            }
            // Thing3 (optional)
            if ( ! (this.Thing3 == null && that.Thing3 == null)) {
                if (this.Thing3 == null && that.Thing3 != null) { return false; }
                if (that.Thing3 != null && this.Thing3 == null) { return false; }
            if ( ! this.Thing3.Equals(that.Thing3)) { return false; }
            }
            // Thing4 (optional)
            if ( ! (this.Thing4 == null && that.Thing4 == null)) {
                if (this.Thing4 == null && that.Thing4 != null) { return false; }
                if (that.Thing4 != null && this.Thing4 == null) { return false; }
            if ( ! this.Thing4.Equals(that.Thing4)) { return false; }
            }
            // Thing5 (optional)
            if ( ! (this.Thing5 == null && that.Thing5 == null)) {
                if (this.Thing5 == null && that.Thing5 != null) { return false; }
                if (that.Thing5 != null && this.Thing5 == null) { return false; }
            if ( ! this.Thing5.Equals(that.Thing5)) { return false; }
            }
            // IntValue1 (required)
            if (this.IntValue1 != that.IntValue1) { return false; }
            // Thing6 (optional)
            if ( ! (this.Thing6 == null && that.Thing6 == null)) {
                if (this.Thing6 == null && that.Thing6 != null) { return false; }
                if (that.Thing6 != null && this.Thing6 == null) { return false; }
            if ( ! this.Thing6.Equals(that.Thing6)) { return false; }
            }
            // Thing7 (optional)
            if ( ! (this.Thing7 == null && that.Thing7 == null)) {
                if (this.Thing7 == null && that.Thing7 != null) { return false; }
                if (that.Thing7 != null && this.Thing7 == null) { return false; }
            if ( ! this.Thing7.Equals(that.Thing7)) { return false; }
            }
            // Thing8 (optional)
            if ( ! (this.Thing8 == null && that.Thing8 == null)) {
                if (this.Thing8 == null && that.Thing8 != null) { return false; }
                if (that.Thing8 != null && this.Thing8 == null) { return false; }
            if ( ! this.Thing8.Equals(that.Thing8)) { return false; }
            }
            // Thing9 (optional)
            if ( ! (this.Thing9 == null && that.Thing9 == null)) {
                if (this.Thing9 == null && that.Thing9 != null) { return false; }
                if (that.Thing9 != null && this.Thing9 == null) { return false; }
            if ( ! this.Thing9.Equals(that.Thing9)) { return false; }
            }
            // IntValue2 (required)
            if (this.IntValue2 != that.IntValue2) { return false; }
            // Thing10 (optional)
            if ( ! (this.Thing10 == null && that.Thing10 == null)) {
                if (this.Thing10 == null && that.Thing10 != null) { return false; }
                if (that.Thing10 != null && this.Thing10 == null) { return false; }
            if ( ! this.Thing10.Equals(that.Thing10)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.Thing1 == null ? 0 : this.Thing1.GetHashCode());
                hash = (13*hash) + (this.Thing2 == null ? 0 : this.Thing2.GetHashCode());
                hash = (13*hash) + (this.Thing3 == null ? 0 : this.Thing3.GetHashCode());
                hash = (13*hash) + (this.Thing4 == null ? 0 : this.Thing4.GetHashCode());
                hash = (13*hash) + (this.Thing5 == null ? 0 : this.Thing5.GetHashCode());
                hash = (13*hash) + this.IntValue1.GetHashCode();
                hash = (13*hash) + (this.Thing6 == null ? 0 : this.Thing6.GetHashCode());
                hash = (13*hash) + (this.Thing7 == null ? 0 : this.Thing7.GetHashCode());
                hash = (13*hash) + (this.Thing8 == null ? 0 : this.Thing8.GetHashCode());
                hash = (13*hash) + (this.Thing9 == null ? 0 : this.Thing9.GetHashCode());
                hash = (13*hash) + this.IntValue2.GetHashCode();
                hash = (13*hash) + (this.Thing10 == null ? 0 : this.Thing10.GetHashCode());
                return hash;
            }
        }
    }
}
