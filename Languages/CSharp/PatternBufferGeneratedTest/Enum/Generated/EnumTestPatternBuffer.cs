
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Enum {
    public class EnumTestPatternBuffer {
        private static readonly ulong[] vuBoundaries = new ulong[] {
            128,
            16384,
            2097152,
            268435456,
            34359738368,
            4398046511104,
            562949953421312,
            72057594037927936,
            9223372036854775808
        };
        public static readonly Dictionary<string, Dictionary<byte, string>> enumIndexValueMap = new Dictionary<string, Dictionary<byte, string>>() {            {
                "SomeEnum",
                new Dictionary<byte,string>() {
                    {(byte)1, "value1"},
                    {(byte)2, "value2"},
                    {(byte)3, "value3"}
                }
            },
            {
                "SomeEnum2",
                new Dictionary<byte,string>() {
                    {(byte)1, "value4"},
                    {(byte)2, "value5"},
                    {(byte)3, "value6"}
                }
            }
        };
        public static readonly Dictionary<string, Dictionary<string, byte>> enumValueIndexMap = new Dictionary<string, Dictionary<string, byte>> {
            {
                "SomeEnum",
                new Dictionary<string,byte>() {
                    {"value1", (byte)1},
                    {"value2", (byte)2},
                    {"value3", (byte)3}
                }
            },
            {
                "SomeEnum2",
                new Dictionary<string,byte>() {
                    {"value4", (byte)1},
                    {"value5", (byte)2},
                    {"value6", (byte)3}
                }
            }
        };
        private byte[] bytes;
        private IEnumTestInstantiator instantiator;
        public EnumTestPatternBuffer() : this(4096, new DefaultEnumTestInstantiator()) { }
        public EnumTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultEnumTestInstantiator()) { }
        public EnumTestPatternBuffer(IEnumTestInstantiator instantiator) : this (4096, instantiator) { }
        public EnumTestPatternBuffer(uint bufferSize, IEnumTestInstantiator instantiator) {
            this.bytes = new byte[bufferSize];
            this.instantiator = instantiator;
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(EnumObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumMap2Object o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(EnumObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // REFERENCE: SomeEnumValue
                bytes[index++] = enumValueIndexMap["SomeEnum"][o.SomeEnumValue.ToString()];
;
        }
        public void Energize(EnumListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: SomeEnumListValue
                if (o.SomeEnumListValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.SomeEnumListValue == null || o.SomeEnumListValue == null || o.SomeEnumListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumListValue.Count;
                int i_vxqVMwooIKPT;
                for (i_vxqVMwooIKPT = 0; i_vxqVMwooIKPT < 2; i_vxqVMwooIKPT++) {
                    if ((ulong)o.SomeEnumListValue.Count < vuBoundaries[i_vxqVMwooIKPT]) {
                       byteCount = (int)(i_vxqVMwooIKPT + 1);
                       goto guvsgoto_hZt6GSimdLFQ;
                    }
                }
                byteCount = (int)i_vxqVMwooIKPT + 1;
                guvsgoto_hZt6GSimdLFQ:
                    for (int i_ceHGCHHOzSMw = 0; i_ceHGCHHOzSMw < byteCount; i_ceHGCHHOzSMw++) {
                        if (i_ceHGCHHOzSMw < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ceHGCHHOzSMw < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (SomeEnum enumValue in o.SomeEnumListValue) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
                }
        }
        public void Energize(EnumMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: IntSomeEnumMapValue
                if (o.IntSomeEnumMapValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntSomeEnumMapValue == null || o.IntSomeEnumMapValue.Keys == null || o.IntSomeEnumMapValue.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSomeEnumMapValue.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSomeEnumMapValue.Keys.Count;
                int i_fdOorHlQjJ0C;
                for (i_fdOorHlQjJ0C = 0; i_fdOorHlQjJ0C < 2; i_fdOorHlQjJ0C++) {
                    if ((ulong)o.IntSomeEnumMapValue.Keys.Count < vuBoundaries[i_fdOorHlQjJ0C]) {
                       byteCount = (int)(i_fdOorHlQjJ0C + 1);
                       goto guvsgoto_d98MGshsUiMz;
                    }
                }
                byteCount = (int)i_fdOorHlQjJ0C + 1;
                guvsgoto_d98MGshsUiMz:
                    for (int i_eLTFd0qgU3NN = 0; i_eLTFd0qgU3NN < byteCount; i_eLTFd0qgU3NN++) {
                        if (i_eLTFd0qgU3NN < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_eLTFd0qgU3NN < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.IntSomeEnumMapValue.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntSomeEnumMapValue == null || o.IntSomeEnumMapValue.Values == null || o.IntSomeEnumMapValue.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSomeEnumMapValue.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSomeEnumMapValue.Values.Count;
                int i_xtx2H6mIiGB4;
                for (i_xtx2H6mIiGB4 = 0; i_xtx2H6mIiGB4 < 2; i_xtx2H6mIiGB4++) {
                    if ((ulong)o.IntSomeEnumMapValue.Values.Count < vuBoundaries[i_xtx2H6mIiGB4]) {
                       byteCount = (int)(i_xtx2H6mIiGB4 + 1);
                       goto guvsgoto_jLSqDx97Biuz;
                    }
                }
                byteCount = (int)i_xtx2H6mIiGB4 + 1;
                guvsgoto_jLSqDx97Biuz:
                    for (int i_oLo31GOsAa0Q = 0; i_oLo31GOsAa0Q < byteCount; i_oLo31GOsAa0Q++) {
                        if (i_oLo31GOsAa0Q < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_oLo31GOsAa0Q < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (SomeEnum enumValue in o.IntSomeEnumMapValue.Values) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
                }
        }
        public void Energize(EnumMap2Object o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: SomeEnumIntMapValue
                if (o.SomeEnumIntMapValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.SomeEnumIntMapValue == null || o.SomeEnumIntMapValue.Keys == null || o.SomeEnumIntMapValue.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumIntMapValue.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumIntMapValue.Keys.Count;
                int i_myJYReE1jXR2;
                for (i_myJYReE1jXR2 = 0; i_myJYReE1jXR2 < 2; i_myJYReE1jXR2++) {
                    if ((ulong)o.SomeEnumIntMapValue.Keys.Count < vuBoundaries[i_myJYReE1jXR2]) {
                       byteCount = (int)(i_myJYReE1jXR2 + 1);
                       goto guvsgoto_v5mWK2acrtMU;
                    }
                }
                byteCount = (int)i_myJYReE1jXR2 + 1;
                guvsgoto_v5mWK2acrtMU:
                    for (int i_dgg5Eb92CQdL = 0; i_dgg5Eb92CQdL < byteCount; i_dgg5Eb92CQdL++) {
                        if (i_dgg5Eb92CQdL < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dgg5Eb92CQdL < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (SomeEnum enumValue in o.SomeEnumIntMapValue.Keys) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
            if (o.SomeEnumIntMapValue == null || o.SomeEnumIntMapValue.Values == null || o.SomeEnumIntMapValue.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumIntMapValue.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumIntMapValue.Values.Count;
                int i_yZLvG8GbouOD;
                for (i_yZLvG8GbouOD = 0; i_yZLvG8GbouOD < 2; i_yZLvG8GbouOD++) {
                    if ((ulong)o.SomeEnumIntMapValue.Values.Count < vuBoundaries[i_yZLvG8GbouOD]) {
                       byteCount = (int)(i_yZLvG8GbouOD + 1);
                       goto guvsgoto_tz8pGzMp8EzD;
                    }
                }
                byteCount = (int)i_yZLvG8GbouOD + 1;
                guvsgoto_tz8pGzMp8EzD:
                    for (int i_ueHquUrXu7fs = 0; i_ueHquUrXu7fs < byteCount; i_ueHquUrXu7fs++) {
                        if (i_ueHquUrXu7fs < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ueHquUrXu7fs < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.SomeEnumIntMapValue.Values) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
                }
        }
        public void Energize(EnumSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: SomeEnumSetValue
                if (o.SomeEnumSetValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.SomeEnumSetValue == null || o.SomeEnumSetValue == null || o.SomeEnumSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumSetValue.Count;
                int i_lNvDkbxyVEDB;
                for (i_lNvDkbxyVEDB = 0; i_lNvDkbxyVEDB < 2; i_lNvDkbxyVEDB++) {
                    if ((ulong)o.SomeEnumSetValue.Count < vuBoundaries[i_lNvDkbxyVEDB]) {
                       byteCount = (int)(i_lNvDkbxyVEDB + 1);
                       goto guvsgoto_covUkB3NRM8P;
                    }
                }
                byteCount = (int)i_lNvDkbxyVEDB + 1;
                guvsgoto_covUkB3NRM8P:
                    for (int i_ww4nmMi9Ttpr = 0; i_ww4nmMi9Ttpr < byteCount; i_ww4nmMi9Ttpr++) {
                        if (i_ww4nmMi9Ttpr < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ww4nmMi9Ttpr < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (SomeEnum enumValue in o.SomeEnumSetValue) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
                }
        }
        public void Energize(IEnumTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 11:
                    Energize((EnumObject)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((EnumListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((EnumMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((EnumMap2Object)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((EnumSetObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_qW0WAaWjg1ZQ = 0;
                    for (int i_kXMtKQHLV31Y = 0; i_kXMtKQHLV31Y < 9; i_kXMtKQHLV31Y++) {
                        byte b = bytes[index++];
                        if (i_kXMtKQHLV31Y < 8) {
                            vuread_qW0WAaWjg1ZQ += (((ulong)b & (ulong)127) << (7 * i_kXMtKQHLV31Y));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qW0WAaWjg1ZQ += (ulong)b << (7 * i_kXMtKQHLV31Y);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_qW0WAaWjg1ZQ;
            switch (typeId) {
            case 11:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumObject o = this.instantiator.AcquireEnumObject();
                nullFlagsIndex++;
                // REFERENCE: SomeEnumValue
                byte enumValue_nPBeE85hye0y;
                enumValue_nPBeE85hye0y = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_nPBeE85hye0y]);
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumListObject o = this.instantiator.AcquireEnumListObject();
                nullFlagsIndex++;
                // LIST: SomeEnumListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_eK8USuvaGoYy;
                    ulong vuread_zZzdWNFU4cpV = 0;
                    for (int i_oROh6Sru7oi9 = 0; i_oROh6Sru7oi9 < 9; i_oROh6Sru7oi9++) {
                        byte b = bytes[index++];
                        if (i_oROh6Sru7oi9 < 8) {
                            vuread_zZzdWNFU4cpV += (((ulong)b & (ulong)127) << (7 * i_oROh6Sru7oi9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zZzdWNFU4cpV += (ulong)b << (7 * i_oROh6Sru7oi9);
                            break;
                        }
                    }
                    count_eK8USuvaGoYy = (ushort)vuread_zZzdWNFU4cpV;
            // Read list items
            if (count_eK8USuvaGoYy > 0) {
                o.SomeEnumListValue = this.instantiator.AcquireListOfSomeEnum();
                for (int i_sW2BI1rs0cfP = 0; i_sW2BI1rs0cfP < count_eK8USuvaGoYy; i_sW2BI1rs0cfP++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumMapObject o = this.instantiator.AcquireEnumMapObject();
                nullFlagsIndex++;
                // MAP: IntSomeEnumMapValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intSomeEnumMapValueKeys = this.instantiator.AcquireListOfInt();
                    List<SomeEnum> intSomeEnumMapValueValues = this.instantiator.AcquireListOfSomeEnum();
            // Read list item count
            ushort count_o2vUIgEiumla;
                    ulong vuread_rneY6EBVQzv9 = 0;
                    for (int i_telcU64GM9Ie = 0; i_telcU64GM9Ie < 9; i_telcU64GM9Ie++) {
                        byte b = bytes[index++];
                        if (i_telcU64GM9Ie < 8) {
                            vuread_rneY6EBVQzv9 += (((ulong)b & (ulong)127) << (7 * i_telcU64GM9Ie));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rneY6EBVQzv9 += (ulong)b << (7 * i_telcU64GM9Ie);
                            break;
                        }
                    }
                    count_o2vUIgEiumla = (ushort)vuread_rneY6EBVQzv9;
            // Read list items
            if (count_o2vUIgEiumla > 0) {
                intSomeEnumMapValueKeys = this.instantiator.AcquireListOfInt();
                int listValue_jHV1T9OFL2Vu;
                for (int i_uDwvLt8jHv9E = 0; i_uDwvLt8jHv9E < count_o2vUIgEiumla; i_uDwvLt8jHv9E++) {
                    // Read Int list item
                listValue_jHV1T9OFL2Vu =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_jHV1T9OFL2Vu);
                }
            }
            // Read list item count
            ushort count_xBxysOyPP9Bz;
                    ulong vuread_tJbRVZy2s1pr = 0;
                    for (int i_pI5tbzHbHr7s = 0; i_pI5tbzHbHr7s < 9; i_pI5tbzHbHr7s++) {
                        byte b = bytes[index++];
                        if (i_pI5tbzHbHr7s < 8) {
                            vuread_tJbRVZy2s1pr += (((ulong)b & (ulong)127) << (7 * i_pI5tbzHbHr7s));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tJbRVZy2s1pr += (ulong)b << (7 * i_pI5tbzHbHr7s);
                            break;
                        }
                    }
                    count_xBxysOyPP9Bz = (ushort)vuread_tJbRVZy2s1pr;
            // Read list items
            if (count_xBxysOyPP9Bz > 0) {
                intSomeEnumMapValueValues = this.instantiator.AcquireListOfSomeEnum();
                for (int i_pqn7EgOXc7Mb = 0; i_pqn7EgOXc7Mb < count_xBxysOyPP9Bz; i_pqn7EgOXc7Mb++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    o.IntSomeEnumMapValue = this.instantiator.AcquireDictionaryOfIntToSomeEnum();
                    for (int i_hryR7glcmgXT = 0; i_hryR7glcmgXT < intSomeEnumMapValueKeys.Count; i_hryR7glcmgXT++) {
                        o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_hryR7glcmgXT]] = intSomeEnumMapValueValues[i_hryR7glcmgXT];
                    }
                    this.instantiator.DiscardListOfInt(intSomeEnumMapValueKeys);
                    this.instantiator.DiscardListOfSomeEnum(intSomeEnumMapValueValues);
                    intSomeEnumMapValueKeys = null;
                    intSomeEnumMapValueValues = null;
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumMap2Object o = this.instantiator.AcquireEnumMap2Object();
                nullFlagsIndex++;
                // MAP: SomeEnumIntMapValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<SomeEnum> someEnumIntMapValueKeys = this.instantiator.AcquireListOfSomeEnum();
                    List<int> someEnumIntMapValueValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_seOqCz1CMTfE;
                    ulong vuread_qAymmBpN64bU = 0;
                    for (int i_aZdAg4fFDDoz = 0; i_aZdAg4fFDDoz < 9; i_aZdAg4fFDDoz++) {
                        byte b = bytes[index++];
                        if (i_aZdAg4fFDDoz < 8) {
                            vuread_qAymmBpN64bU += (((ulong)b & (ulong)127) << (7 * i_aZdAg4fFDDoz));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qAymmBpN64bU += (ulong)b << (7 * i_aZdAg4fFDDoz);
                            break;
                        }
                    }
                    count_seOqCz1CMTfE = (ushort)vuread_qAymmBpN64bU;
            // Read list items
            if (count_seOqCz1CMTfE > 0) {
                someEnumIntMapValueKeys = this.instantiator.AcquireListOfSomeEnum();
                for (int i_lyuMfkzIl3fG = 0; i_lyuMfkzIl3fG < count_seOqCz1CMTfE; i_lyuMfkzIl3fG++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_s8ZV0kXYd4pN;
                    ulong vuread_jAwROJbil9UY = 0;
                    for (int i_cNHWFDIgTGSh = 0; i_cNHWFDIgTGSh < 9; i_cNHWFDIgTGSh++) {
                        byte b = bytes[index++];
                        if (i_cNHWFDIgTGSh < 8) {
                            vuread_jAwROJbil9UY += (((ulong)b & (ulong)127) << (7 * i_cNHWFDIgTGSh));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jAwROJbil9UY += (ulong)b << (7 * i_cNHWFDIgTGSh);
                            break;
                        }
                    }
                    count_s8ZV0kXYd4pN = (ushort)vuread_jAwROJbil9UY;
            // Read list items
            if (count_s8ZV0kXYd4pN > 0) {
                someEnumIntMapValueValues = this.instantiator.AcquireListOfInt();
                int listValue_cuPtPAvHjQqP;
                for (int i_uR4M26uTobOn = 0; i_uR4M26uTobOn < count_s8ZV0kXYd4pN; i_uR4M26uTobOn++) {
                    // Read Int list item
                listValue_cuPtPAvHjQqP =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_cuPtPAvHjQqP);
                }
            }
                    o.SomeEnumIntMapValue = this.instantiator.AcquireDictionaryOfSomeEnumToInt();
                    for (int i_qbsKwi3ZSpMt = 0; i_qbsKwi3ZSpMt < someEnumIntMapValueKeys.Count; i_qbsKwi3ZSpMt++) {
                        o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_qbsKwi3ZSpMt]] = someEnumIntMapValueValues[i_qbsKwi3ZSpMt];
                    }
                    this.instantiator.DiscardListOfSomeEnum(someEnumIntMapValueKeys);
                    this.instantiator.DiscardListOfInt(someEnumIntMapValueValues);
                    someEnumIntMapValueKeys = null;
                    someEnumIntMapValueValues = null;
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumSetObject o = this.instantiator.AcquireEnumSetObject();
                nullFlagsIndex++;
                // SET: SomeEnumSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_xSCVNmPzw28X;
                    ulong vuread_o5oXl92dPCQO = 0;
                    for (int i_dVlaXB6IeKSk = 0; i_dVlaXB6IeKSk < 9; i_dVlaXB6IeKSk++) {
                        byte b = bytes[index++];
                        if (i_dVlaXB6IeKSk < 8) {
                            vuread_o5oXl92dPCQO += (((ulong)b & (ulong)127) << (7 * i_dVlaXB6IeKSk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_o5oXl92dPCQO += (ulong)b << (7 * i_dVlaXB6IeKSk);
                            break;
                        }
                    }
                    count_xSCVNmPzw28X = (ushort)vuread_o5oXl92dPCQO;
            // Read list items
            if (count_xSCVNmPzw28X > 0) {
                o.SomeEnumSetValue = this.instantiator.AcquireHashSetOfSomeEnum();
                for (int i_mJfcwo0UdFaA = 0; i_mJfcwo0UdFaA < count_xSCVNmPzw28X; i_mJfcwo0UdFaA++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_xgNSwJOBbYM1 = 0;
                    for (int i_aOM55zS9ndtM = 0; i_aOM55zS9ndtM < 9; i_aOM55zS9ndtM++) {
                        byte b = bytes[index++];
                        if (i_aOM55zS9ndtM < 8) {
                            vuread_xgNSwJOBbYM1 += (((ulong)b & (ulong)127) << (7 * i_aOM55zS9ndtM));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xgNSwJOBbYM1 += (ulong)b << (7 * i_aOM55zS9ndtM);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_xgNSwJOBbYM1;
            switch (typeId) {
            case 11:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumObject o = this.instantiator.AcquireEnumObject();
                nullFlagsIndex++;
                // REFERENCE: SomeEnumValue
                byte enumValue_x0RBL6LNUVgQ;
                enumValue_x0RBL6LNUVgQ = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_x0RBL6LNUVgQ]);
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumListObject o = this.instantiator.AcquireEnumListObject();
                nullFlagsIndex++;
                // LIST: SomeEnumListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_vomF6qjP6nbR;
                    ulong vuread_p4YOWbn1XbYG = 0;
                    for (int i_wm0en9hpI5hR = 0; i_wm0en9hpI5hR < 9; i_wm0en9hpI5hR++) {
                        byte b = bytes[index++];
                        if (i_wm0en9hpI5hR < 8) {
                            vuread_p4YOWbn1XbYG += (((ulong)b & (ulong)127) << (7 * i_wm0en9hpI5hR));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_p4YOWbn1XbYG += (ulong)b << (7 * i_wm0en9hpI5hR);
                            break;
                        }
                    }
                    count_vomF6qjP6nbR = (ushort)vuread_p4YOWbn1XbYG;
            // Read list items
            if (count_vomF6qjP6nbR > 0) {
                o.SomeEnumListValue = this.instantiator.AcquireListOfSomeEnum();
                for (int i_fnc64NPQZ9ZQ = 0; i_fnc64NPQZ9ZQ < count_vomF6qjP6nbR; i_fnc64NPQZ9ZQ++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumMapObject o = this.instantiator.AcquireEnumMapObject();
                nullFlagsIndex++;
                // MAP: IntSomeEnumMapValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intSomeEnumMapValueKeys = this.instantiator.AcquireListOfInt();
                    List<SomeEnum> intSomeEnumMapValueValues = this.instantiator.AcquireListOfSomeEnum();
            // Read list item count
            ushort count_d60SIp3XzPOT;
                    ulong vuread_leC6gViPXhBI = 0;
                    for (int i_zq6jviR1xj7q = 0; i_zq6jviR1xj7q < 9; i_zq6jviR1xj7q++) {
                        byte b = bytes[index++];
                        if (i_zq6jviR1xj7q < 8) {
                            vuread_leC6gViPXhBI += (((ulong)b & (ulong)127) << (7 * i_zq6jviR1xj7q));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_leC6gViPXhBI += (ulong)b << (7 * i_zq6jviR1xj7q);
                            break;
                        }
                    }
                    count_d60SIp3XzPOT = (ushort)vuread_leC6gViPXhBI;
            // Read list items
            if (count_d60SIp3XzPOT > 0) {
                intSomeEnumMapValueKeys = this.instantiator.AcquireListOfInt();
                int listValue_dyRtcurHJtG0;
                for (int i_eSJd1j3aFsTr = 0; i_eSJd1j3aFsTr < count_d60SIp3XzPOT; i_eSJd1j3aFsTr++) {
                    // Read Int list item
                listValue_dyRtcurHJtG0 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_dyRtcurHJtG0);
                }
            }
            // Read list item count
            ushort count_hTBr8WvqhmXR;
                    ulong vuread_bZNCZ39PUg8N = 0;
                    for (int i_oNanq6U0Ozbt = 0; i_oNanq6U0Ozbt < 9; i_oNanq6U0Ozbt++) {
                        byte b = bytes[index++];
                        if (i_oNanq6U0Ozbt < 8) {
                            vuread_bZNCZ39PUg8N += (((ulong)b & (ulong)127) << (7 * i_oNanq6U0Ozbt));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bZNCZ39PUg8N += (ulong)b << (7 * i_oNanq6U0Ozbt);
                            break;
                        }
                    }
                    count_hTBr8WvqhmXR = (ushort)vuread_bZNCZ39PUg8N;
            // Read list items
            if (count_hTBr8WvqhmXR > 0) {
                intSomeEnumMapValueValues = this.instantiator.AcquireListOfSomeEnum();
                for (int i_xaIW8pS8419b = 0; i_xaIW8pS8419b < count_hTBr8WvqhmXR; i_xaIW8pS8419b++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    o.IntSomeEnumMapValue = this.instantiator.AcquireDictionaryOfIntToSomeEnum();
                    for (int i_nAkLseHlUXSv = 0; i_nAkLseHlUXSv < intSomeEnumMapValueKeys.Count; i_nAkLseHlUXSv++) {
                        o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_nAkLseHlUXSv]] = intSomeEnumMapValueValues[i_nAkLseHlUXSv];
                    }
                    this.instantiator.DiscardListOfInt(intSomeEnumMapValueKeys);
                    this.instantiator.DiscardListOfSomeEnum(intSomeEnumMapValueValues);
                    intSomeEnumMapValueKeys = null;
                    intSomeEnumMapValueValues = null;
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumMap2Object o = this.instantiator.AcquireEnumMap2Object();
                nullFlagsIndex++;
                // MAP: SomeEnumIntMapValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<SomeEnum> someEnumIntMapValueKeys = this.instantiator.AcquireListOfSomeEnum();
                    List<int> someEnumIntMapValueValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_uhakB7dOXuJZ;
                    ulong vuread_inQEx9TQO8RZ = 0;
                    for (int i_tiIK20Igrna0 = 0; i_tiIK20Igrna0 < 9; i_tiIK20Igrna0++) {
                        byte b = bytes[index++];
                        if (i_tiIK20Igrna0 < 8) {
                            vuread_inQEx9TQO8RZ += (((ulong)b & (ulong)127) << (7 * i_tiIK20Igrna0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_inQEx9TQO8RZ += (ulong)b << (7 * i_tiIK20Igrna0);
                            break;
                        }
                    }
                    count_uhakB7dOXuJZ = (ushort)vuread_inQEx9TQO8RZ;
            // Read list items
            if (count_uhakB7dOXuJZ > 0) {
                someEnumIntMapValueKeys = this.instantiator.AcquireListOfSomeEnum();
                for (int i_gIH7Yvnm1vqf = 0; i_gIH7Yvnm1vqf < count_uhakB7dOXuJZ; i_gIH7Yvnm1vqf++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_jcXUdbQWAkzs;
                    ulong vuread_kDV7VDHhm0pZ = 0;
                    for (int i_mW2sVF8z1Dm0 = 0; i_mW2sVF8z1Dm0 < 9; i_mW2sVF8z1Dm0++) {
                        byte b = bytes[index++];
                        if (i_mW2sVF8z1Dm0 < 8) {
                            vuread_kDV7VDHhm0pZ += (((ulong)b & (ulong)127) << (7 * i_mW2sVF8z1Dm0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kDV7VDHhm0pZ += (ulong)b << (7 * i_mW2sVF8z1Dm0);
                            break;
                        }
                    }
                    count_jcXUdbQWAkzs = (ushort)vuread_kDV7VDHhm0pZ;
            // Read list items
            if (count_jcXUdbQWAkzs > 0) {
                someEnumIntMapValueValues = this.instantiator.AcquireListOfInt();
                int listValue_bXcqGnAeioIv;
                for (int i_opAxYj2HW7sr = 0; i_opAxYj2HW7sr < count_jcXUdbQWAkzs; i_opAxYj2HW7sr++) {
                    // Read Int list item
                listValue_bXcqGnAeioIv =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_bXcqGnAeioIv);
                }
            }
                    o.SomeEnumIntMapValue = this.instantiator.AcquireDictionaryOfSomeEnumToInt();
                    for (int i_eyb4l9A5q458 = 0; i_eyb4l9A5q458 < someEnumIntMapValueKeys.Count; i_eyb4l9A5q458++) {
                        o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_eyb4l9A5q458]] = someEnumIntMapValueValues[i_eyb4l9A5q458];
                    }
                    this.instantiator.DiscardListOfSomeEnum(someEnumIntMapValueKeys);
                    this.instantiator.DiscardListOfInt(someEnumIntMapValueValues);
                    someEnumIntMapValueKeys = null;
                    someEnumIntMapValueValues = null;
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumSetObject o = this.instantiator.AcquireEnumSetObject();
                nullFlagsIndex++;
                // SET: SomeEnumSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_lrK8AlQooGTF;
                    ulong vuread_cLLSKPeeFVgi = 0;
                    for (int i_fF2jXNfPuB6H = 0; i_fF2jXNfPuB6H < 9; i_fF2jXNfPuB6H++) {
                        byte b = bytes[index++];
                        if (i_fF2jXNfPuB6H < 8) {
                            vuread_cLLSKPeeFVgi += (((ulong)b & (ulong)127) << (7 * i_fF2jXNfPuB6H));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cLLSKPeeFVgi += (ulong)b << (7 * i_fF2jXNfPuB6H);
                            break;
                        }
                    }
                    count_lrK8AlQooGTF = (ushort)vuread_cLLSKPeeFVgi;
            // Read list items
            if (count_lrK8AlQooGTF > 0) {
                o.SomeEnumSetValue = this.instantiator.AcquireHashSetOfSomeEnum();
                for (int i_o4gLrddNOGYK = 0; i_o4gLrddNOGYK < count_lrK8AlQooGTF; i_o4gLrddNOGYK++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 11:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumObject o = this.instantiator.AcquireEnumObject();
                nullFlagsIndex++;
                // REFERENCE: SomeEnumValue
                byte enumValue_kSvK00DPkCW4;
                enumValue_kSvK00DPkCW4 = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_kSvK00DPkCW4]);
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumListObject o = this.instantiator.AcquireEnumListObject();
                nullFlagsIndex++;
                // LIST: SomeEnumListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_hHALBekNOekP;
                    ulong vuread_oCXBSDDQRrVf = 0;
                    for (int i_hEYD8qwfimtU = 0; i_hEYD8qwfimtU < 9; i_hEYD8qwfimtU++) {
                        byte b = bytes[index++];
                        if (i_hEYD8qwfimtU < 8) {
                            vuread_oCXBSDDQRrVf += (((ulong)b & (ulong)127) << (7 * i_hEYD8qwfimtU));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oCXBSDDQRrVf += (ulong)b << (7 * i_hEYD8qwfimtU);
                            break;
                        }
                    }
                    count_hHALBekNOekP = (ushort)vuread_oCXBSDDQRrVf;
            // Read list items
            if (count_hHALBekNOekP > 0) {
                o.SomeEnumListValue = this.instantiator.AcquireListOfSomeEnum();
                for (int i_qBlKvk6tHPcx = 0; i_qBlKvk6tHPcx < count_hHALBekNOekP; i_qBlKvk6tHPcx++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumMapObject o = this.instantiator.AcquireEnumMapObject();
                nullFlagsIndex++;
                // MAP: IntSomeEnumMapValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intSomeEnumMapValueKeys = this.instantiator.AcquireListOfInt();
                    List<SomeEnum> intSomeEnumMapValueValues = this.instantiator.AcquireListOfSomeEnum();
            // Read list item count
            ushort count_bb7R8gnaVvs7;
                    ulong vuread_gRPxReHwjdYq = 0;
                    for (int i_h3uGvBHMBBA6 = 0; i_h3uGvBHMBBA6 < 9; i_h3uGvBHMBBA6++) {
                        byte b = bytes[index++];
                        if (i_h3uGvBHMBBA6 < 8) {
                            vuread_gRPxReHwjdYq += (((ulong)b & (ulong)127) << (7 * i_h3uGvBHMBBA6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gRPxReHwjdYq += (ulong)b << (7 * i_h3uGvBHMBBA6);
                            break;
                        }
                    }
                    count_bb7R8gnaVvs7 = (ushort)vuread_gRPxReHwjdYq;
            // Read list items
            if (count_bb7R8gnaVvs7 > 0) {
                intSomeEnumMapValueKeys = this.instantiator.AcquireListOfInt();
                int listValue_hPhc9s8rjovN;
                for (int i_nIMDhPoanRAf = 0; i_nIMDhPoanRAf < count_bb7R8gnaVvs7; i_nIMDhPoanRAf++) {
                    // Read Int list item
                listValue_hPhc9s8rjovN =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_hPhc9s8rjovN);
                }
            }
            // Read list item count
            ushort count_tRPtYQFYrSec;
                    ulong vuread_yFx1eGhcHQaW = 0;
                    for (int i_vdFWmATLobqr = 0; i_vdFWmATLobqr < 9; i_vdFWmATLobqr++) {
                        byte b = bytes[index++];
                        if (i_vdFWmATLobqr < 8) {
                            vuread_yFx1eGhcHQaW += (((ulong)b & (ulong)127) << (7 * i_vdFWmATLobqr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yFx1eGhcHQaW += (ulong)b << (7 * i_vdFWmATLobqr);
                            break;
                        }
                    }
                    count_tRPtYQFYrSec = (ushort)vuread_yFx1eGhcHQaW;
            // Read list items
            if (count_tRPtYQFYrSec > 0) {
                intSomeEnumMapValueValues = this.instantiator.AcquireListOfSomeEnum();
                for (int i_qOCCTHwWDKGL = 0; i_qOCCTHwWDKGL < count_tRPtYQFYrSec; i_qOCCTHwWDKGL++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    o.IntSomeEnumMapValue = this.instantiator.AcquireDictionaryOfIntToSomeEnum();
                    for (int i_hw5QKxHeQ2EU = 0; i_hw5QKxHeQ2EU < intSomeEnumMapValueKeys.Count; i_hw5QKxHeQ2EU++) {
                        o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_hw5QKxHeQ2EU]] = intSomeEnumMapValueValues[i_hw5QKxHeQ2EU];
                    }
                    this.instantiator.DiscardListOfInt(intSomeEnumMapValueKeys);
                    this.instantiator.DiscardListOfSomeEnum(intSomeEnumMapValueValues);
                    intSomeEnumMapValueKeys = null;
                    intSomeEnumMapValueValues = null;
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumMap2Object o = this.instantiator.AcquireEnumMap2Object();
                nullFlagsIndex++;
                // MAP: SomeEnumIntMapValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<SomeEnum> someEnumIntMapValueKeys = this.instantiator.AcquireListOfSomeEnum();
                    List<int> someEnumIntMapValueValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_eSL19DX4pfoz;
                    ulong vuread_bOtauntpH3E0 = 0;
                    for (int i_mcb0ElLUkRsa = 0; i_mcb0ElLUkRsa < 9; i_mcb0ElLUkRsa++) {
                        byte b = bytes[index++];
                        if (i_mcb0ElLUkRsa < 8) {
                            vuread_bOtauntpH3E0 += (((ulong)b & (ulong)127) << (7 * i_mcb0ElLUkRsa));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bOtauntpH3E0 += (ulong)b << (7 * i_mcb0ElLUkRsa);
                            break;
                        }
                    }
                    count_eSL19DX4pfoz = (ushort)vuread_bOtauntpH3E0;
            // Read list items
            if (count_eSL19DX4pfoz > 0) {
                someEnumIntMapValueKeys = this.instantiator.AcquireListOfSomeEnum();
                for (int i_yFXaWLwmiFM6 = 0; i_yFXaWLwmiFM6 < count_eSL19DX4pfoz; i_yFXaWLwmiFM6++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_cHUCJonqoVw7;
                    ulong vuread_l7AdEEowvseY = 0;
                    for (int i_lsD5HrR9zfV6 = 0; i_lsD5HrR9zfV6 < 9; i_lsD5HrR9zfV6++) {
                        byte b = bytes[index++];
                        if (i_lsD5HrR9zfV6 < 8) {
                            vuread_l7AdEEowvseY += (((ulong)b & (ulong)127) << (7 * i_lsD5HrR9zfV6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_l7AdEEowvseY += (ulong)b << (7 * i_lsD5HrR9zfV6);
                            break;
                        }
                    }
                    count_cHUCJonqoVw7 = (ushort)vuread_l7AdEEowvseY;
            // Read list items
            if (count_cHUCJonqoVw7 > 0) {
                someEnumIntMapValueValues = this.instantiator.AcquireListOfInt();
                int listValue_lik6EbVkjZIZ;
                for (int i_etSOqqKWC6cq = 0; i_etSOqqKWC6cq < count_cHUCJonqoVw7; i_etSOqqKWC6cq++) {
                    // Read Int list item
                listValue_lik6EbVkjZIZ =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_lik6EbVkjZIZ);
                }
            }
                    o.SomeEnumIntMapValue = this.instantiator.AcquireDictionaryOfSomeEnumToInt();
                    for (int i_tsT7dwHwlEMw = 0; i_tsT7dwHwlEMw < someEnumIntMapValueKeys.Count; i_tsT7dwHwlEMw++) {
                        o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_tsT7dwHwlEMw]] = someEnumIntMapValueValues[i_tsT7dwHwlEMw];
                    }
                    this.instantiator.DiscardListOfSomeEnum(someEnumIntMapValueKeys);
                    this.instantiator.DiscardListOfInt(someEnumIntMapValueValues);
                    someEnumIntMapValueKeys = null;
                    someEnumIntMapValueValues = null;
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumSetObject o = this.instantiator.AcquireEnumSetObject();
                nullFlagsIndex++;
                // SET: SomeEnumSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_is1tG4PLUOUn;
                    ulong vuread_odTjE9EEg4kl = 0;
                    for (int i_hYhWslNQRwu7 = 0; i_hYhWslNQRwu7 < 9; i_hYhWslNQRwu7++) {
                        byte b = bytes[index++];
                        if (i_hYhWslNQRwu7 < 8) {
                            vuread_odTjE9EEg4kl += (((ulong)b & (ulong)127) << (7 * i_hYhWslNQRwu7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_odTjE9EEg4kl += (ulong)b << (7 * i_hYhWslNQRwu7);
                            break;
                        }
                    }
                    count_is1tG4PLUOUn = (ushort)vuread_odTjE9EEg4kl;
            // Read list items
            if (count_is1tG4PLUOUn > 0) {
                o.SomeEnumSetValue = this.instantiator.AcquireHashSetOfSomeEnum();
                for (int i_kqpIqAFhIGx9 = 0; i_kqpIqAFhIGx9 < count_is1tG4PLUOUn; i_kqpIqAFhIGx9++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new EnumTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(EnumObject o) {
            if (o != null) {
                o.SomeEnumValue = default(SomeEnum);
                this.instantiator.DiscardEnumObject(o);
            }
        }
        public void Reclaim(EnumListObject o) {
            if (o != null) {
                this.instantiator.DiscardEnumListObject(o);
            }
        }
        public void Reclaim(EnumMapObject o) {
            if (o != null) {
                if (o.IntSomeEnumMapValue != null) {
                    this.instantiator.DiscardDictionaryOfIntToSomeEnum((Dictionary<int,SomeEnum>)o.IntSomeEnumMapValue);
                }
                this.instantiator.DiscardEnumMapObject(o);
            }
        }
        public void Reclaim(EnumMap2Object o) {
            if (o != null) {
                if (o.SomeEnumIntMapValue != null) {
                    this.instantiator.DiscardDictionaryOfSomeEnumToInt((Dictionary<SomeEnum,int>)o.SomeEnumIntMapValue);
                }
                this.instantiator.DiscardEnumMap2Object(o);
            }
        }
        public void Reclaim(EnumSetObject o) {
            if (o != null) {
                this.instantiator.DiscardEnumSetObject(o);
            }
        }
    }
}
