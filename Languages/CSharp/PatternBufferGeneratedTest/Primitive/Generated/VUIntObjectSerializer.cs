
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class VUIntObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VUIntObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 115;
            this.TypeName = "VUIntObject";
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
            VUIntObject item = new VUIntObject();
            // PRIMITIVE: vuintValue
            item.vuintValue = (uint)reader.ReadVUInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VUIntObject item = (VUIntObject)o;
            // PRIMITIVE: vuintValue
            writer.WriteVUInt32(item.vuintValue);
        }
        public uint SizeOf(object o) {
            if (!(o is VUIntObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VUIntObject item = (VUIntObject)o;
            uint size = 0;
            // vuintValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vuintValue);
            // all primitives = 0 bytes
            return size;
        }
    }
}
