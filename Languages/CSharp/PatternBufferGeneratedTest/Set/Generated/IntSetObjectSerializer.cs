
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Set {
    public class IntSetObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public IntSetObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 12;
            this.TypeName = "IntSetObject";
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
            IntSetObject item = new IntSetObject();
            // SET: intSetValue
            int count_ac40e1da8f = (int)reader.ReadVUInt64();
            if (count_ac40e1da8f > 0) {
                item.intSetValue = new HashSet<int>();
                for (int i = 0; i < count_ac40e1da8f; i++) {
                    item.intSetValue.Add(reader.ReadInt32());
                }
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            IntSetObject item = (IntSetObject)o;
            // SET: intSetValue
            if (item.intSetValue != null) {
                writer.WriteVUInt64((ulong)item.intSetValue.Count);
                foreach (int primitive in item.intSetValue) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is IntSetObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            IntSetObject item = (IntSetObject)o;
            uint size = 0;
            // intSetValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intSetValue.Count);
            size += (uint)(item.intSetValue.Count * 4);
            // all primitives = 0 bytes
            return size;
        }
    }
}
