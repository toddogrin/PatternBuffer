
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class IntObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public IntObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 12;
            this.TypeName = "IntObject";
        }
        private ushort typeId;
        public ushort TypeId {
            get { return this.typeId; }
            protected set { this.typeId = value; }
        }
        private string typeName;
        public string TypeName {
            get { return this.typeName; }
            protected set { this.typeName = value; }
        }
        public object FromBytes(BinaryReader reader) {
            IntObject item = new IntObject();
            // PRIMITIVE: intValue
            item.intValue = reader.ReadInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            IntObject item = (IntObject)o;
            // PRIMITIVE: intValue
            writer.Write((int)item.intValue);
        }
        public uint SizeOf(object o) {
            if (!(o is IntObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            IntObject item = (IntObject)o;
            uint size = 0;
            // intValue = 4 bytes
            size += 4; // all primitives
            return size;
        }
    }
}
