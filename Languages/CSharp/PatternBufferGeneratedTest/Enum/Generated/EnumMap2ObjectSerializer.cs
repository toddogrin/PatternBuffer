
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Enum {
    public class EnumMap2ObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EnumMap2ObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 14;
            this.TypeName = "EnumMap2Object";
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
            EnumMap2Object item = new EnumMap2Object();
            // MAP: someEnumIntMapValue
            IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
            IList<int> someEnumIntMapValueValues = new List<int>();
            someEnumIntMapValueKeys = reader.ReadEnumCollection<List<SomeEnum>,SomeEnum>(this.patternBuffer, "SomeEnum");
            int count_0d3fa93f39 = (int)reader.ReadVUInt64();
            if (count_0d3fa93f39 > 0) {
                someEnumIntMapValueValues = new List<int>();
                for (int i = 0; i < count_0d3fa93f39; i++) {
                    someEnumIntMapValueValues.Add(reader.ReadInt32());
                }
            }
            item.someEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
            for (int i = 0; i < someEnumIntMapValueKeys.Count; i++) {
                item.someEnumIntMapValue[someEnumIntMapValueKeys[i]] = someEnumIntMapValueValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EnumMap2Object item = (EnumMap2Object)o;
            // MAP: someEnumIntMapValue
            writer.WriteEnumCollection<SomeEnum>(this.patternBuffer, "SomeEnum", item.someEnumIntMapValue.Keys);
            if (item.someEnumIntMapValue.Values != null) {
                writer.WriteVUInt64((ulong)item.someEnumIntMapValue.Values.Count);
                foreach (int primitive in item.someEnumIntMapValue.Values) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is EnumMap2Object)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EnumMap2Object item = (EnumMap2Object)o;
            uint size = 0;
            // someEnumIntMapValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.someEnumIntMapValue.Keys.Count);
            size += (uint)item.someEnumIntMapValue.Keys.Count;
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.someEnumIntMapValue.Values.Count);
            size += (uint)(item.someEnumIntMapValue.Values.Count * 4);
            // all primitives = 0 bytes
            return size;
        }
    }
}
