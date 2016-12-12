
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class Thing1ListObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public Thing1ListObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 14;
            this.TypeName = "Thing1ListObject";
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
            Thing1ListObject item = new Thing1ListObject();
            // LIST: thingListValue
            item.thingListValue = reader.ReadFinalObjectCollection<List<IThing1>,IThing1>(this.patternBuffer.GetSerializerByTypeName("Thing1"));
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            Thing1ListObject item = (Thing1ListObject)o;
            // LIST: thingListValue
            writer.WriteFinalObjectCollection<IThing1>(this.patternBuffer.GetSerializerByTypeName("Thing1"), item.thingListValue);
        }
        public uint SizeOf(object o) {
            if (!(o is Thing1ListObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            Thing1ListObject item = (Thing1ListObject)o;
            uint size = 0;
            // thingListValue
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.thingListValue.Count);
            IPatternBufferSerializer serializer_1c552eb852 = this.patternBuffer.GetSerializerByTypeName("Thing1");
            foreach (Thing1 s in item.thingListValue) {
                size += (uint)serializer_1c552eb852.SizeOf(s);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
