
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Reference {
    public class AbstractReferenceObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public AbstractReferenceObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 24;
            this.TypeName = "AbstractReferenceObject";
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
            AbstractReferenceObject item = new AbstractReferenceObject();
            // REFERENCE: thing
            item.thing = reader.ReadAbstractReference<IAbstractThing>(this.patternBuffer, "AbstractThing");
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            AbstractReferenceObject item = (AbstractReferenceObject)o;
            // REFERENCE: thing
            IPatternBufferSerializer serializer_0e492f9583 = this.patternBuffer.GetSerializerFor(item.thing);
            writer.WriteAbstractReference<IAbstractThing>(this.patternBuffer, serializer_0e492f9583.TypeName, item.thing);
        }
        public uint SizeOf(object o) {
            if (!(o is AbstractReferenceObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            AbstractReferenceObject item = (AbstractReferenceObject)o;
            uint size = 0;
            // thing
            IPatternBufferSerializer serializer_251f25c4f5 = this.patternBuffer.GetSerializerFor(item.Thing);
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)serializer_251f25c4f5.TypeId);
            size += (uint)serializer_251f25c4f5.SizeOf(item.thing);
            // all primitives = 0 bytes
            return size;
        }
    }
}
