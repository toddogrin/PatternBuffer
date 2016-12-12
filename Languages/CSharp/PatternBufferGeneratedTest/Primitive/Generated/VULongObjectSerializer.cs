
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class VULongObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VULongObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 116;
            this.TypeName = "VULongObject";
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
            VULongObject item = new VULongObject();
            // PRIMITIVE: vulongValue
            item.vulongValue = (ulong)reader.ReadVUInt64();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VULongObject item = (VULongObject)o;
            // PRIMITIVE: vulongValue
            writer.WriteVUInt64(item.vulongValue);
        }
        public uint SizeOf(object o) {
            if (!(o is VULongObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VULongObject item = (VULongObject)o;
            uint size = 0;
            // vulongValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vulongValue);
            // all primitives = 0 bytes
            return size;
        }
    }
}
