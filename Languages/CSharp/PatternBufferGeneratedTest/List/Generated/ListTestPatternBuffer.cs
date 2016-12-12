
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;

using System.Collections.Generic;

namespace Test.List {
    public class ListTestPatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {

            AbstractThingSerializer serializer_881f6b078f = new AbstractThingSerializer(this);
            this.typeIdSerializerMap[9] = serializer_881f6b078f;
            this.typeSerializerMap[typeof(AbstractThing)] = serializer_881f6b078f;
            this.typeNameSerializerMap["AbstractThing"] = serializer_881f6b078f;

            Thing1Serializer serializer_6b972cf9bf = new Thing1Serializer(this);
            this.typeIdSerializerMap[10] = serializer_6b972cf9bf;
            this.typeSerializerMap[typeof(Thing1)] = serializer_6b972cf9bf;
            this.typeNameSerializerMap["Thing1"] = serializer_6b972cf9bf;

            Thing2Serializer serializer_98896389b7 = new Thing2Serializer(this);
            this.typeIdSerializerMap[11] = serializer_98896389b7;
            this.typeSerializerMap[typeof(Thing2)] = serializer_98896389b7;
            this.typeNameSerializerMap["Thing2"] = serializer_98896389b7;

            IntListObjectSerializer serializer_e0bd4e0ad2 = new IntListObjectSerializer(this);
            this.typeIdSerializerMap[12] = serializer_e0bd4e0ad2;
            this.typeSerializerMap[typeof(IntListObject)] = serializer_e0bd4e0ad2;
            this.typeNameSerializerMap["IntListObject"] = serializer_e0bd4e0ad2;

            StringListObjectSerializer serializer_a138333cfb = new StringListObjectSerializer(this);
            this.typeIdSerializerMap[13] = serializer_a138333cfb;
            this.typeSerializerMap[typeof(StringListObject)] = serializer_a138333cfb;
            this.typeNameSerializerMap["StringListObject"] = serializer_a138333cfb;

            Thing1ListObjectSerializer serializer_10b01e4ddc = new Thing1ListObjectSerializer(this);
            this.typeIdSerializerMap[14] = serializer_10b01e4ddc;
            this.typeSerializerMap[typeof(Thing1ListObject)] = serializer_10b01e4ddc;
            this.typeNameSerializerMap["Thing1ListObject"] = serializer_10b01e4ddc;

            AbstractThingListObjectSerializer serializer_2bec486766 = new AbstractThingListObjectSerializer(this);
            this.typeIdSerializerMap[15] = serializer_2bec486766;
            this.typeSerializerMap[typeof(AbstractThingListObject)] = serializer_2bec486766;
            this.typeNameSerializerMap["AbstractThingListObject"] = serializer_2bec486766;

            VIntListObjectSerializer serializer_dd61b61839 = new VIntListObjectSerializer(this);
            this.typeIdSerializerMap[16] = serializer_dd61b61839;
            this.typeSerializerMap[typeof(VIntListObject)] = serializer_dd61b61839;
            this.typeNameSerializerMap["VIntListObject"] = serializer_dd61b61839;

        }
        protected override void RegisterEnums() {

        }
    }
}
