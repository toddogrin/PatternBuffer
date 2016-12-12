
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class VIntListObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VIntListObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 16;
            this.TypeName = "VIntListObject";
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
            VIntListObject item = new VIntListObject();
            // LIST: vintListValue
            int count_758babf5a8 = (int)reader.ReadVUInt64();
            if (count_758babf5a8 > 0) {
                item.vintListValue = new List<int>();
                for (int i = 0; i < count_758babf5a8; i++) {
                    item.vintListValue.Add((int)reader.ReadVInt32());
                }
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VIntListObject item = (VIntListObject)o;
            // LIST: vintListValue
            if (item.vintListValue != null) {
                writer.WriteVUInt64((ulong)item.vintListValue.Count);
                foreach (int primitive in item.vintListValue) {
                    writer.WriteVInt32(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is VIntListObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VIntListObject item = (VIntListObject)o;
            uint size = 0;
            // vintListValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vintListValue.Count);
            foreach (int variant in item.vintListValue) {
                size += (uint)PatternBufferUtil.GetSignedVariantSize(variant);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
