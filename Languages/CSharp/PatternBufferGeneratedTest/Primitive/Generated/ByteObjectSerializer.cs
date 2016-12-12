
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class ByteObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public ByteObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 21;
            this.TypeName = "ByteObject";
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
            ByteObject item = new ByteObject();
            // PRIMITIVE: byteValue
            item.byteValue = reader.ReadByte();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            ByteObject item = (ByteObject)o;
            // PRIMITIVE: byteValue
            writer.Write((byte)item.byteValue);
        }
        public uint SizeOf(object o) {
            if (!(o is ByteObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            ByteObject item = (ByteObject)o;
            uint size = 0;
            // byteValue = 1 bytes
            size += 1; // all primitives
            return size;
        }
    }
}
