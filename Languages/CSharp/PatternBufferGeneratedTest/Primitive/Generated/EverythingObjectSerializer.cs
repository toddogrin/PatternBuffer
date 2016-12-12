
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class EverythingObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public EverythingObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 22;
            this.TypeName = "EverythingObject";
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
            EverythingObject item = new EverythingObject();
            // PRIMITIVE: shortValue
            item.shortValue = reader.ReadInt16();
            // PRIMITIVE: intValue
            item.intValue = reader.ReadInt32();
            // PRIMITIVE: longValue
            item.longValue = reader.ReadInt64();
            // PRIMITIVE: ushortValue
            item.ushortValue = reader.ReadUInt16();
            // PRIMITIVE: uintValue
            item.uintValue = reader.ReadUInt32();
            // PRIMITIVE: ulongValue
            item.ulongValue = reader.ReadUInt64();
            // PRIMITIVE: stringValue
            item.stringValue = reader.ReadString();
            // PRIMITIVE: doubleValue
            item.doubleValue = reader.ReadDouble();
            // PRIMITIVE: floatValue
            item.floatValue = reader.ReadSingle();
            // PRIMITIVE: boolValue
            item.boolValue = reader.ReadBoolean();
            // PRIMITIVE: byteValue
            item.byteValue = reader.ReadByte();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            EverythingObject item = (EverythingObject)o;
            // PRIMITIVE: shortValue
            writer.Write((short)item.shortValue);
            // PRIMITIVE: intValue
            writer.Write((int)item.intValue);
            // PRIMITIVE: longValue
            writer.Write((long)item.longValue);
            // PRIMITIVE: ushortValue
            writer.Write((ushort)item.ushortValue);
            // PRIMITIVE: uintValue
            writer.Write((uint)item.uintValue);
            // PRIMITIVE: ulongValue
            writer.Write((ulong)item.ulongValue);
            // PRIMITIVE: stringValue
            writer.Write((string)item.stringValue);
            // PRIMITIVE: doubleValue
            writer.Write((double)item.doubleValue);
            // PRIMITIVE: floatValue
            writer.Write((float)item.floatValue);
            // PRIMITIVE: boolValue
            writer.Write((bool)item.boolValue);
            // PRIMITIVE: byteValue
            writer.Write((byte)item.byteValue);
        }
        public uint SizeOf(object o) {
            if (!(o is EverythingObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            EverythingObject item = (EverythingObject)o;
            uint size = 0;
            // shortValue = 2 bytes
            // intValue = 4 bytes
            // longValue = 8 bytes
            // ushortValue = 2 bytes
            // uintValue = 4 bytes
            // ulongValue = 8 bytes
            // stringValue
            size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)item.stringValue.Length) + item.stringValue.Length);
            // doubleValue = 8 bytes
            // floatValue = 4 bytes
            // boolValue = 1 bytes
            // byteValue = 1 bytes
            size += 42; // all primitives
            return size;
        }
    }
}
