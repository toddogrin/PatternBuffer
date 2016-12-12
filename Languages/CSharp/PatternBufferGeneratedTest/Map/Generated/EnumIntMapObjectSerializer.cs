
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Map {
    public class EnumIntMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EnumIntMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 15;
            this.TypeName = "EnumIntMapObject";
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
            EnumIntMapObject item = new EnumIntMapObject();
            // MAP: enumIntMap
            IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
            IList<int> enumIntMapValues = new List<int>();
            enumIntMapKeys = reader.ReadEnumCollection<List<MyEnum>,MyEnum>(this.patternBuffer, "MyEnum");
            int count_f564e1f748 = (int)reader.ReadVUInt64();
            if (count_f564e1f748 > 0) {
                enumIntMapValues = new List<int>();
                for (int i = 0; i < count_f564e1f748; i++) {
                    enumIntMapValues.Add(reader.ReadInt32());
                }
            }
            item.enumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
            for (int i = 0; i < enumIntMapKeys.Count; i++) {
                item.enumIntMap[enumIntMapKeys[i]] = enumIntMapValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EnumIntMapObject item = (EnumIntMapObject)o;
            // MAP: enumIntMap
            writer.WriteEnumCollection<MyEnum>(this.patternBuffer, "MyEnum", item.enumIntMap.Keys);
            if (item.enumIntMap.Values != null) {
                writer.WriteVUInt64((ulong)item.enumIntMap.Values.Count);
                foreach (int primitive in item.enumIntMap.Values) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is EnumIntMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EnumIntMapObject item = (EnumIntMapObject)o;
            uint size = 0;
            // enumIntMap
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.enumIntMap.Keys.Count);
            size += (uint)item.enumIntMap.Keys.Count;
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.enumIntMap.Values.Count);
            size += (uint)(item.enumIntMap.Values.Count * 4);
            // all primitives = 0 bytes
            return size;
        }
    }
}
