
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class AbstractThingListObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public AbstractThingListObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 15;
            this.TypeName = "AbstractThingListObject";
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
            AbstractThingListObject item = new AbstractThingListObject();
            // LIST: abstractThingListValue
            item.abstractThingListValue = reader.ReadAbstractObjectCollection<List<IAbstractThing>,IAbstractThing>(this.patternBuffer);
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            AbstractThingListObject item = (AbstractThingListObject)o;
            // LIST: abstractThingListValue
            writer.WriteAbstractObjectCollection<IAbstractThing>(this.patternBuffer, item.abstractThingListValue);
        }
        public uint SizeOf(object o) {
            if (!(o is AbstractThingListObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            AbstractThingListObject item = (AbstractThingListObject)o;
            uint size = 0;
            // abstractThingListValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.abstractThingListValue.Count);
            foreach (AbstractThing a in item.abstractThingListValue) {
                IPatternBufferSerializer serializer_b86faaf87e = this.patternBuffer.GetSerializerFor(a);
                size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)serializer_b86faaf87e.TypeId);
                size += (uint)serializer_b86faaf87e.SizeOf(a);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
