
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;

using System.Collections.Generic;

namespace Test.Reference {
    public class ReferenceTestPatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {

            ThingSerializer serializer_5957978786 = new ThingSerializer(this);
            this.typeIdSerializerMap[11] = serializer_5957978786;
            this.typeSerializerMap[typeof(Thing)] = serializer_5957978786;
            this.typeNameSerializerMap["Thing"] = serializer_5957978786;

            FinalObjectSerializer serializer_58bddbda16 = new FinalObjectSerializer(this);
            this.typeIdSerializerMap[12] = serializer_58bddbda16;
            this.typeSerializerMap[typeof(FinalObject)] = serializer_58bddbda16;
            this.typeNameSerializerMap["FinalObject"] = serializer_58bddbda16;

            FinalThing1Serializer serializer_d647e91074 = new FinalThing1Serializer(this);
            this.typeIdSerializerMap[22] = serializer_d647e91074;
            this.typeSerializerMap[typeof(FinalThing1)] = serializer_d647e91074;
            this.typeNameSerializerMap["FinalThing1"] = serializer_d647e91074;

            FinalThing2Serializer serializer_d324fe0e3e = new FinalThing2Serializer(this);
            this.typeIdSerializerMap[23] = serializer_d324fe0e3e;
            this.typeSerializerMap[typeof(FinalThing2)] = serializer_d324fe0e3e;
            this.typeNameSerializerMap["FinalThing2"] = serializer_d324fe0e3e;

            AbstractReferenceObjectSerializer serializer_7899f72247 = new AbstractReferenceObjectSerializer(this);
            this.typeIdSerializerMap[24] = serializer_7899f72247;
            this.typeSerializerMap[typeof(AbstractReferenceObject)] = serializer_7899f72247;
            this.typeNameSerializerMap["AbstractReferenceObject"] = serializer_7899f72247;

        }
        protected override void RegisterEnums() {

        }
    }
}
