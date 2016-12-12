
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Enum {
    public class EnumSetObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EnumSetObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 15;
            this.TypeName = "EnumSetObject";
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
            EnumSetObject item = new EnumSetObject();
            // SET: someEnumSetValue
            item.someEnumSetValue = reader.ReadEnumCollection<HashSet<SomeEnum>,SomeEnum>(this.patternBuffer, "SomeEnum");
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EnumSetObject item = (EnumSetObject)o;
            // SET: someEnumSetValue
            writer.WriteEnumCollection<SomeEnum>(this.patternBuffer, "SomeEnum", item.someEnumSetValue);
        }
        public uint SizeOf(object o) {
            if (!(o is EnumSetObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EnumSetObject item = (EnumSetObject)o;
            uint size = 0;
            // someEnumSetValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.someEnumSetValue.Count);
            size += (uint)item.someEnumSetValue.Count;
            // all primitives = 0 bytes
            return size;
        }
    }
}
