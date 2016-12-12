using System.IO;

namespace PatternBuffer {

    public interface IPatternBuffer {

        byte[] Energize(object o);

        object Energize(byte[] bytes);

        TYPE Energize<TYPE>(byte[] bytes);

        void EnergizeTo(object o, BinaryWriter writer);

        object EnergizeFrom(BinaryReader reader);

        IPatternBufferSerializer GetSerializerByTypeId(ushort typeId);
        IPatternBufferSerializer GetSerializerFor(object o);
        IPatternBufferSerializer GetSerializerByTypeName(string typeName);

        bool IsSupportedType(ushort typeId);
        bool IsSupportedType(object o);

        string GetEnumValue(string enumName, byte index);

        byte GetEnumIndex(string enumName, string value);
    }
}
