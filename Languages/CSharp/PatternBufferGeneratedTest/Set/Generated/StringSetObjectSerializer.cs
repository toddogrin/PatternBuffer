
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Set {
    public class StringSetObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public StringSetObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 13;
            this.TypeName = "StringSetObject";
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
            StringSetObject item = new StringSetObject();
            // SET: stringSetValue
            int count_581badc59d = (int)reader.ReadVUInt64();
            if (count_581badc59d > 0) {
                item.stringSetValue = new HashSet<string>();
                for (int i = 0; i < count_581badc59d; i++) {
                    item.stringSetValue.Add(reader.ReadString());
                }
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            StringSetObject item = (StringSetObject)o;
            // SET: stringSetValue
            if (item.stringSetValue != null) {
                writer.WriteVUInt64((ulong)item.stringSetValue.Count);
                foreach (string primitive in item.stringSetValue) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is StringSetObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            StringSetObject item = (StringSetObject)o;
            uint size = 0;
            // stringSetValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.stringSetValue.Count);
            foreach (string s in item.stringSetValue) {
                size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)s.Length) + s.Length);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
