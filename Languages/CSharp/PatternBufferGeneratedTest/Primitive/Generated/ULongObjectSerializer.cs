
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class ULongObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public ULongObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 16;
            this.TypeName = "ULongObject";
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
            ULongObject item = new ULongObject();
            // PRIMITIVE: ulongValue
            item.ulongValue = reader.ReadUInt64();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            ULongObject item = (ULongObject)o;
            // PRIMITIVE: ulongValue
            writer.Write((ulong)item.ulongValue);
        }
        public uint SizeOf(object o) {
            if (!(o is ULongObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            ULongObject item = (ULongObject)o;
            uint size = 0;
            // ulongValue = 8 bytes
            size += 8; // all primitives
            return size;
        }
    }
}
