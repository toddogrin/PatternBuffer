
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class VUShortObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VUShortObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 114;
            this.TypeName = "VUShortObject";
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
            VUShortObject item = new VUShortObject();
            // PRIMITIVE: vushortValue
            item.vushortValue = (ushort)reader.ReadVUInt16();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VUShortObject item = (VUShortObject)o;
            // PRIMITIVE: vushortValue
            writer.WriteVUInt16(item.vushortValue);
        }
        public uint SizeOf(object o) {
            if (!(o is VUShortObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VUShortObject item = (VUShortObject)o;
            uint size = 0;
            // vushortValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vushortValue);
            // all primitives = 0 bytes
            return size;
        }
    }
}
