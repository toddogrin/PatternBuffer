
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Enum {
    public class EnumMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EnumMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 13;
            this.TypeName = "EnumMapObject";
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
            EnumMapObject item = new EnumMapObject();
            // MAP: intSomeEnumMapValue
            IList<int> intSomeEnumMapValueKeys = new List<int>();
            IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            int count_689f5d7d88 = (int)reader.ReadVUInt64();
            if (count_689f5d7d88 > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                for (int i = 0; i < count_689f5d7d88; i++) {
                    intSomeEnumMapValueKeys.Add(reader.ReadInt32());
                }
            }
            intSomeEnumMapValueValues = reader.ReadEnumCollection<List<SomeEnum>,SomeEnum>(this.patternBuffer, "SomeEnum");
            item.intSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
            for (int i = 0; i < intSomeEnumMapValueKeys.Count; i++) {
                item.intSomeEnumMapValue[intSomeEnumMapValueKeys[i]] = intSomeEnumMapValueValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EnumMapObject item = (EnumMapObject)o;
            // MAP: intSomeEnumMapValue
            if (item.intSomeEnumMapValue.Keys != null) {
                writer.WriteVUInt64((ulong)item.intSomeEnumMapValue.Keys.Count);
                foreach (int primitive in item.intSomeEnumMapValue.Keys) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
            writer.WriteEnumCollection<SomeEnum>(this.patternBuffer, "SomeEnum", item.intSomeEnumMapValue.Values);
        }
        public uint SizeOf(object o) {
            if (!(o is EnumMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EnumMapObject item = (EnumMapObject)o;
            uint size = 0;
            // intSomeEnumMapValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intSomeEnumMapValue.Keys.Count);
            size += (uint)(item.intSomeEnumMapValue.Keys.Count * 4);
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intSomeEnumMapValue.Values.Count);
            size += (uint)item.intSomeEnumMapValue.Values.Count;
            // all primitives = 0 bytes
            return size;
        }
    }
}
