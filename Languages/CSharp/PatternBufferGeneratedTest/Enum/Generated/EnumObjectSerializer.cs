
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Enum {
    public class EnumObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EnumObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 11;
            this.TypeName = "EnumObject";
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
            EnumObject item = new EnumObject();
            // REFERENCE: someEnumValue
            item.someEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), this.patternBuffer.GetEnumValue("SomeEnum", reader.ReadByte()));
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EnumObject item = (EnumObject)o;
            // REFERENCE: someEnumValue
            writer.Write(this.patternBuffer.GetEnumIndex("SomeEnum", item.someEnumValue.ToString()));
        }
        public uint SizeOf(object o) {
            if (!(o is EnumObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EnumObject item = (EnumObject)o;
            uint size = 0;
            // someEnumValue
            size += (uint)1;
            // all primitives = 0 bytes
            return size;
        }
    }
}
