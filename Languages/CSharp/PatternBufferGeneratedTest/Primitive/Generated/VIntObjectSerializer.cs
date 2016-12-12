
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class VIntObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public VIntObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 112;
            this.TypeName = "VIntObject";
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
            VIntObject item = new VIntObject();
            // PRIMITIVE: vintValue
            item.vintValue = (int)reader.ReadVInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            VIntObject item = (VIntObject)o;
            // PRIMITIVE: vintValue
            writer.WriteVInt32(item.vintValue);
        }
        public uint SizeOf(object o) {
            if (!(o is VIntObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            VIntObject item = (VIntObject)o;
            uint size = 0;
            // vintValue
            size += (uint)PatternBufferUtil.GetSignedVariantSize(item.vintValue);
            // all primitives = 0 bytes
            return size;
        }
    }
}
