
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Set {
    public class VIntSetObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VIntSetObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 16;
            this.TypeName = "VIntSetObject";
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
            VIntSetObject item = new VIntSetObject();
            // SET: vintSetValue
            int count_2b3c1d8ea5 = (int)reader.ReadVUInt64();
            if (count_2b3c1d8ea5 > 0) {
                item.vintSetValue = new HashSet<int>();
                for (int i = 0; i < count_2b3c1d8ea5; i++) {
                    item.vintSetValue.Add((int)reader.ReadVInt32());
                }
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VIntSetObject item = (VIntSetObject)o;
            // SET: vintSetValue
            if (item.vintSetValue != null) {
                writer.WriteVUInt64((ulong)item.vintSetValue.Count);
                foreach (int primitive in item.vintSetValue) {
                    writer.WriteVInt32(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is VIntSetObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VIntSetObject item = (VIntSetObject)o;
            uint size = 0;
            // vintSetValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vintSetValue.Count);
            foreach (int variant in item.vintSetValue) {
                size += (uint)PatternBufferUtil.GetSignedVariantSize(variant);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
