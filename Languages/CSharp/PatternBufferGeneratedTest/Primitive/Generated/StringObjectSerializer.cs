
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class StringObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public StringObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 17;
            this.TypeName = "StringObject";
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
            StringObject item = new StringObject();
            // PRIMITIVE: stringValue
            item.stringValue = reader.ReadString();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            StringObject item = (StringObject)o;
            // PRIMITIVE: stringValue
            writer.Write((string)item.stringValue);
        }
        public uint SizeOf(object o) {
            if (!(o is StringObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            StringObject item = (StringObject)o;
            uint size = 0;
            // stringValue
            size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)item.stringValue.Length) + item.stringValue.Length);
            // all primitives = 0 bytes
            return size;
        }
    }
}
