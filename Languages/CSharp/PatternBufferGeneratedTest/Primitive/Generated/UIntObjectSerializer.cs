
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class UIntObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public UIntObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 15;
            this.TypeName = "UIntObject";
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
            UIntObject item = new UIntObject();
            // PRIMITIVE: uintValue
            item.uintValue = reader.ReadUInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            UIntObject item = (UIntObject)o;
            // PRIMITIVE: uintValue
            writer.Write((uint)item.uintValue);
        }
        public uint SizeOf(object o) {
            if (!(o is UIntObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            UIntObject item = (UIntObject)o;
            uint size = 0;
            // uintValue = 4 bytes
            size += 4; // all primitives
            return size;
        }
    }
}
