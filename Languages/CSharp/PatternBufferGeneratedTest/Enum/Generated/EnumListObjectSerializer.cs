
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Enum {
    public class EnumListObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EnumListObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 12;
            this.TypeName = "EnumListObject";
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
            EnumListObject item = new EnumListObject();
            // LIST: someEnumListValue
            item.someEnumListValue = reader.ReadEnumCollection<List<SomeEnum>,SomeEnum>(this.patternBuffer, "SomeEnum");
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EnumListObject item = (EnumListObject)o;
            // LIST: someEnumListValue
            writer.WriteEnumCollection<SomeEnum>(this.patternBuffer, "SomeEnum", item.someEnumListValue);
        }
        public uint SizeOf(object o) {
            if (!(o is EnumListObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EnumListObject item = (EnumListObject)o;
            uint size = 0;
            // someEnumListValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.someEnumListValue.Count);
            size += (uint)item.someEnumListValue.Count;
            // all primitives = 0 bytes
            return size;
        }
    }
}
