
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class UShortObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public UShortObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 14;
            this.TypeName = "UShortObject";
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
            UShortObject item = new UShortObject();
            // PRIMITIVE: ushortValue
            item.ushortValue = reader.ReadUInt16();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            UShortObject item = (UShortObject)o;
            // PRIMITIVE: ushortValue
            writer.Write((ushort)item.ushortValue);
        }
        public uint SizeOf(object o) {
            if (!(o is UShortObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            UShortObject item = (UShortObject)o;
            uint size = 0;
            // ushortValue = 2 bytes
            size += 2; // all primitives
            return size;
        }
    }
}
