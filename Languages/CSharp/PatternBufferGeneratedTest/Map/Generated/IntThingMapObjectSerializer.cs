
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Map {
    public class IntThingMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public IntThingMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 11;
            this.TypeName = "IntThingMapObject";
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
            IntThingMapObject item = new IntThingMapObject();
            // MAP: intThingMap
            IList<int> intThingMapKeys = new List<int>();
            IList<IThing> intThingMapValues = new List<IThing>();
            int count_5aac912e02 = (int)reader.ReadVUInt64();
            if (count_5aac912e02 > 0) {
                intThingMapKeys = new List<int>();
                for (int i = 0; i < count_5aac912e02; i++) {
                    intThingMapKeys.Add(reader.ReadInt32());
                }
            }
            intThingMapValues = reader.ReadFinalObjectCollection<List<IThing>,IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"));
            item.intThingMap = new Dictionary<int,IThing>(intThingMapKeys.Count);
            for (int i = 0; i < intThingMapKeys.Count; i++) {
                item.intThingMap[intThingMapKeys[i]] = intThingMapValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            IntThingMapObject item = (IntThingMapObject)o;
            // MAP: intThingMap
            if (item.intThingMap.Keys != null) {
                writer.WriteVUInt64((ulong)item.intThingMap.Keys.Count);
                foreach (int primitive in item.intThingMap.Keys) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
            writer.WriteFinalObjectCollection<IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"), item.intThingMap.Values);
        }
        public uint SizeOf(object o) {
            if (!(o is IntThingMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            IntThingMapObject item = (IntThingMapObject)o;
            uint size = 0;
            // intThingMap
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intThingMap.Keys.Count);
            size += (uint)(item.intThingMap.Keys.Count * 4);
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.intThingMap.Values.Count);
            IPatternBufferSerializer serializer_9d94128b48 = this.patternBuffer.GetSerializerByTypeName("Thing");
            foreach (Thing s in item.intThingMap.Values) {
                size += (uint)serializer_9d94128b48.SizeOf(s);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
