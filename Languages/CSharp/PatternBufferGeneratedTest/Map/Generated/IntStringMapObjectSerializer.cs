
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Map {
    public class IntStringMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public IntStringMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 13;
            this.TypeName = "IntStringMapObject";
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
            IntStringMapObject item = new IntStringMapObject();
            // MAP: intStringMap
            IList<int> intStringMapKeys = new List<int>();
            IList<string> intStringMapValues = new List<string>();
            int count_6e16d3c916 = (int)reader.ReadVUInt64();
            if (count_6e16d3c916 > 0) {
                intStringMapKeys = new List<int>();
                for (int i = 0; i < count_6e16d3c916; i++) {
                    intStringMapKeys.Add(reader.ReadInt32());
                }
            }
            int count_9d4468da1e = (int)reader.ReadVUInt64();
            if (count_9d4468da1e > 0) {
                intStringMapValues = new List<string>();
                for (int i = 0; i < count_9d4468da1e; i++) {
                    intStringMapValues.Add(reader.ReadString());
                }
            }
            item.intStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
            for (int i = 0; i < intStringMapKeys.Count; i++) {
                item.intStringMap[intStringMapKeys[i]] = intStringMapValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            IntStringMapObject item = (IntStringMapObject)o;
            // MAP: intStringMap
            if (item.intStringMap.Keys != null) {
                writer.WriteVUInt64((ulong)item.intStringMap.Keys.Count);
                foreach (int primitive in item.intStringMap.Keys) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
            if (item.intStringMap.Values != null) {
                writer.WriteVUInt64((ulong)item.intStringMap.Values.Count);
                foreach (string primitive in item.intStringMap.Values) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is IntStringMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            IntStringMapObject item = (IntStringMapObject)o;
            uint size = 0;
            // intStringMap
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intStringMap.Keys.Count);
            size += (uint)(item.intStringMap.Keys.Count * 4);
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intStringMap.Values.Count);
            foreach (string s in item.intStringMap.Values) {
                size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)s.Length) + s.Length);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
