
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class IntListObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public IntListObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 12;
            this.TypeName = "IntListObject";
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
            IntListObject item = new IntListObject();
            // LIST: intListValue
            int count_c7bda5398a = (int)reader.ReadVUInt64();
            if (count_c7bda5398a > 0) {
                item.intListValue = new List<int>();
                for (int i = 0; i < count_c7bda5398a; i++) {
                    item.intListValue.Add(reader.ReadInt32());
                }
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            IntListObject item = (IntListObject)o;
            // LIST: intListValue
            if (item.intListValue != null) {
                writer.WriteVUInt64((ulong)item.intListValue.Count);
                foreach (int primitive in item.intListValue) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is IntListObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            IntListObject item = (IntListObject)o;
            uint size = 0;
            // intListValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intListValue.Count);
            size += (uint)(item.intListValue.Count * 4);
            // all primitives = 0 bytes
            return size;
        }
    }
}
