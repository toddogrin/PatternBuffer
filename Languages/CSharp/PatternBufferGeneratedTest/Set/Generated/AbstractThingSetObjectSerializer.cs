
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Set {
    public class AbstractThingSetObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public AbstractThingSetObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 15;
            this.TypeName = "AbstractThingSetObject";
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
            AbstractThingSetObject item = new AbstractThingSetObject();
            // SET: abstractThingSetValue
            item.abstractThingSetValue = reader.ReadAbstractObjectCollection<HashSet<IAbstractThing>,IAbstractThing>(this.patternBuffer);
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            AbstractThingSetObject item = (AbstractThingSetObject)o;
            // SET: abstractThingSetValue
            writer.WriteAbstractObjectCollection<IAbstractThing>(this.patternBuffer, item.abstractThingSetValue);
        }
        public uint SizeOf(object o) {
            if (!(o is AbstractThingSetObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            AbstractThingSetObject item = (AbstractThingSetObject)o;
            uint size = 0;
            // abstractThingSetValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.abstractThingSetValue.Count);
            foreach (AbstractThing a in item.abstractThingSetValue) {
                IPatternBufferSerializer serializer_0a08bac518 = this.patternBuffer.GetSerializerFor(a);
                size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)serializer_0a08bac518.TypeId);
                size += (uint)serializer_0a08bac518.SizeOf(a);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
