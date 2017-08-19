
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class HighScoreObject : IPrimitiveTestObject, IEquatable<HighScoreObject> {

        public const ushort TYPE_ID = 117;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public string Name;
        public uint HighScore;

        public HighScoreObject() {
            this.Name = default(string);
            this.HighScore = default(uint);
        }

        public HighScoreObject(
            string name,
            uint highScore
        ) {
            this.Name = name;
            this.HighScore = highScore;
        }

        public bool Equals(HighScoreObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is HighScoreObject)) { return false; }
            HighScoreObject that = (HighScoreObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Name
            if (this.Name == null && this.Name != null) { return false; }
            if (this.Name != null && this.Name == null) { return false; }
            if ( ! this.Name.Equals(that.Name)) { return false; }
            // HighScore
            if (this.HighScore != that.HighScore) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.Name.GetHashCode();
                hash = (13*hash) + this.HighScore.GetHashCode();
                return hash;
            }
        }
    }
}
