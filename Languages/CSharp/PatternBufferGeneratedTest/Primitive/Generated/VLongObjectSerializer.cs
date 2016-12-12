
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class VLongObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VLongObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 113;
            this.TypeName = "VLongObject";
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
            VLongObject item = new VLongObject();
            // PRIMITIVE: vlongValue
            item.vlongValue = (long)reader.ReadVInt64();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VLongObject item = (VLongObject)o;
            // PRIMITIVE: vlongValue
            writer.WriteVInt64(item.vlongValue);
        }
        public uint SizeOf(object o) {
            if (!(o is VLongObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VLongObject item = (VLongObject)o;
            uint size = 0;
            // vlongValue
            size += (uint)PatternBufferUtil.GetSignedVariantSize(item.vlongValue);
            // all primitives = 0 bytes
            return size;
        }
    }
}
