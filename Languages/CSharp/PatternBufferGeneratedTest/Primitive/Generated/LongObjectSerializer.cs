
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class LongObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public LongObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 13;
            this.TypeName = "LongObject";
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
            LongObject item = new LongObject();
            // PRIMITIVE: longValue
            item.longValue = reader.ReadInt64();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            LongObject item = (LongObject)o;
            // PRIMITIVE: longValue
            writer.Write((long)item.longValue);
        }
        public uint SizeOf(object o) {
            if (!(o is LongObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            LongObject item = (LongObject)o;
            uint size = 0;
            // longValue = 8 bytes
            size += 8; // all primitives
            return size;
        }
    }
}
