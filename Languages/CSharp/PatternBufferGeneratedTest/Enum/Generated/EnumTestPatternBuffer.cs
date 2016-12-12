
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;

using System.Collections.Generic;

namespace Test.Enum {
    public class EnumTestPatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {

            EnumObjectSerializer serializer_a63854973b = new EnumObjectSerializer(this);
            this.typeIdSerializerMap[11] = serializer_a63854973b;
            this.typeSerializerMap[typeof(EnumObject)] = serializer_a63854973b;
            this.typeNameSerializerMap["EnumObject"] = serializer_a63854973b;

            EnumListObjectSerializer serializer_8b6ea3236c = new EnumListObjectSerializer(this);
            this.typeIdSerializerMap[12] = serializer_8b6ea3236c;
            this.typeSerializerMap[typeof(EnumListObject)] = serializer_8b6ea3236c;
            this.typeNameSerializerMap["EnumListObject"] = serializer_8b6ea3236c;

            EnumMapObjectSerializer serializer_082c6ec14b = new EnumMapObjectSerializer(this);
            this.typeIdSerializerMap[13] = serializer_082c6ec14b;
            this.typeSerializerMap[typeof(EnumMapObject)] = serializer_082c6ec14b;
            this.typeNameSerializerMap["EnumMapObject"] = serializer_082c6ec14b;

            EnumMap2ObjectSerializer serializer_83a3e67b34 = new EnumMap2ObjectSerializer(this);
            this.typeIdSerializerMap[14] = serializer_83a3e67b34;
            this.typeSerializerMap[typeof(EnumMap2Object)] = serializer_83a3e67b34;
            this.typeNameSerializerMap["EnumMap2Object"] = serializer_83a3e67b34;

            EnumSetObjectSerializer serializer_bbb5aa66cb = new EnumSetObjectSerializer(this);
            this.typeIdSerializerMap[15] = serializer_bbb5aa66cb;
            this.typeSerializerMap[typeof(EnumSetObject)] = serializer_bbb5aa66cb;
            this.typeNameSerializerMap["EnumSetObject"] = serializer_bbb5aa66cb;

        }
        protected override void RegisterEnums() {

            this.enumIndexValueMap["SomeEnum"] = new Dictionary<byte,string>();
            this.enumValueIndexMap["SomeEnum"] = new Dictionary<string,byte>();
            this.enumIndexValueMap["SomeEnum"][1] = "value1";
            this.enumValueIndexMap["SomeEnum"]["value1"] = 1;
            this.enumIndexValueMap["SomeEnum"][2] = "value2";
            this.enumValueIndexMap["SomeEnum"]["value2"] = 2;
            this.enumIndexValueMap["SomeEnum"][3] = "value3";
            this.enumValueIndexMap["SomeEnum"]["value3"] = 3;

        }
    }
}
