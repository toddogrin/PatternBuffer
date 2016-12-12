
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class StringListObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public StringListObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 13;
            this.TypeName = "StringListObject";
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
            StringListObject item = new StringListObject();
            // LIST: stringListValue
            int count_1a2e61ce4a = (int)reader.ReadVUInt64();
            if (count_1a2e61ce4a > 0) {
                item.stringListValue = new List<string>();
                for (int i = 0; i < count_1a2e61ce4a; i++) {
                    item.stringListValue.Add(reader.ReadString());
                }
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            StringListObject item = (StringListObject)o;
            // LIST: stringListValue
            if (item.stringListValue != null) {
                writer.WriteVUInt64((ulong)item.stringListValue.Count);
                foreach (string primitive in item.stringListValue) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is StringListObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            StringListObject item = (StringListObject)o;
            uint size = 0;
            // stringListValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.stringListValue.Count);
            foreach (string s in item.stringListValue) {
                size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)s.Length) + s.Length);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
