
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Map {
    public class VIntVLongMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VIntVLongMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 16;
            this.TypeName = "VIntVLongMapObject";
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
            VIntVLongMapObject item = new VIntVLongMapObject();
            // MAP: vintVlongMap
            IList<int> vintVlongMapKeys = new List<int>();
            IList<long> vintVlongMapValues = new List<long>();
            int count_ff49ad222f = (int)reader.ReadVUInt64();
            if (count_ff49ad222f > 0) {
                vintVlongMapKeys = new List<int>();
                for (int i = 0; i < count_ff49ad222f; i++) {
                    vintVlongMapKeys.Add((int)reader.ReadVInt32());
                }
            }
            int count_003fc0f7b1 = (int)reader.ReadVUInt64();
            if (count_003fc0f7b1 > 0) {
                vintVlongMapValues = new List<long>();
                for (int i = 0; i < count_003fc0f7b1; i++) {
                    vintVlongMapValues.Add((long)reader.ReadVInt64());
                }
            }
            item.vintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
            for (int i = 0; i < vintVlongMapKeys.Count; i++) {
                item.vintVlongMap[vintVlongMapKeys[i]] = vintVlongMapValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VIntVLongMapObject item = (VIntVLongMapObject)o;
            // MAP: vintVlongMap
            if (item.vintVlongMap.Keys != null) {
                writer.WriteVUInt64((ulong)item.vintVlongMap.Keys.Count);
                foreach (int primitive in item.vintVlongMap.Keys) {
                    writer.WriteVInt32(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
            if (item.vintVlongMap.Values != null) {
                writer.WriteVUInt64((ulong)item.vintVlongMap.Values.Count);
                foreach (long primitive in item.vintVlongMap.Values) {
                    writer.WriteVInt64(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is VIntVLongMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VIntVLongMapObject item = (VIntVLongMapObject)o;
            uint size = 0;
            // vintVlongMap
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vintVlongMap.Keys.Count);
            foreach (int variant in item.vintVlongMap.Keys) {
                size += (uint)PatternBufferUtil.GetSignedVariantSize(variant);
            }
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.vintVlongMap.Values.Count);
            foreach (long variant in item.vintVlongMap.Values) {
                size += (uint)PatternBufferUtil.GetSignedVariantSize(variant);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
