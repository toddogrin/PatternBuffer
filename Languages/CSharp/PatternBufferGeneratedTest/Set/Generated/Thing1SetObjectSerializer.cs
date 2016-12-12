
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Set {
    public class Thing1SetObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public Thing1SetObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 14;
            this.TypeName = "Thing1SetObject";
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
            Thing1SetObject item = new Thing1SetObject();
            // SET: thingSetValue
            item.thingSetValue = reader.ReadFinalObjectCollection<HashSet<IThing1>,IThing1>(this.patternBuffer.GetSerializerByTypeName("Thing1"));
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            Thing1SetObject item = (Thing1SetObject)o;
            // SET: thingSetValue
            writer.WriteFinalObjectCollection<IThing1>(this.patternBuffer.GetSerializerByTypeName("Thing1"), item.thingSetValue);
        }
        public uint SizeOf(object o) {
            if (!(o is Thing1SetObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            Thing1SetObject item = (Thing1SetObject)o;
            uint size = 0;
            // thingSetValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.thingSetValue.Count);
            IPatternBufferSerializer serializer_71469ea50d = this.patternBuffer.GetSerializerByTypeName("Thing1");
            foreach (Thing1 s in item.thingSetValue) {
                size += (uint)serializer_71469ea50d.SizeOf(s);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
