
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
        public EnumTestPatternBuffer() : this(4096) { }
        public EnumTestPatternBuffer(uint bufferSize) {
            this.bytes = new byte[bufferSize];
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(EnumObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumMap2Object o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(EnumObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // REFERENCE: SomeEnumValue
                bytes[index++] = enumValueIndexMap["SomeEnum"][o.SomeEnumValue.ToString()];
;
        }
        public void Energize(EnumListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // LIST: SomeEnumListValue
            if (o.SomeEnumListValue == null || o.SomeEnumListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumListValue.Count;
                int i_uruRre2D31ad;
                for (i_uruRre2D31ad = 0; i_uruRre2D31ad < 2; i_uruRre2D31ad++) {
                    if ((ulong)o.SomeEnumListValue.Count < vuBoundaries[i_uruRre2D31ad]) {
                       byteCount = (int)(i_uruRre2D31ad + 1);
                       goto guvsgoto_sqGipXKibpHd;
                    }
                }
                byteCount = (int)i_uruRre2D31ad + 1;
                guvsgoto_sqGipXKibpHd:
                    for (int i_xjTKnp4ifjy4 = 0; i_xjTKnp4ifjy4 < byteCount; i_xjTKnp4ifjy4++) {
                        if (i_xjTKnp4ifjy4 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_xjTKnp4ifjy4 < byteCount - 1) {
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
        public void Energize(EnumMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // MAP: IntSomeEnumMapValue
            if (o.IntSomeEnumMapValue.Keys == null || o.IntSomeEnumMapValue.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSomeEnumMapValue.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSomeEnumMapValue.Keys.Count;
                int i_zQ3Ny7K0pDof;
                for (i_zQ3Ny7K0pDof = 0; i_zQ3Ny7K0pDof < 2; i_zQ3Ny7K0pDof++) {
                    if ((ulong)o.IntSomeEnumMapValue.Keys.Count < vuBoundaries[i_zQ3Ny7K0pDof]) {
                       byteCount = (int)(i_zQ3Ny7K0pDof + 1);
                       goto guvsgoto_xXVi9CeLc0oG;
                    }
                }
                byteCount = (int)i_zQ3Ny7K0pDof + 1;
                guvsgoto_xXVi9CeLc0oG:
                    for (int i_ba4Vuz8O3zYE = 0; i_ba4Vuz8O3zYE < byteCount; i_ba4Vuz8O3zYE++) {
                        if (i_ba4Vuz8O3zYE < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ba4Vuz8O3zYE < byteCount - 1) {
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
            if (o.IntSomeEnumMapValue.Values == null || o.IntSomeEnumMapValue.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSomeEnumMapValue.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSomeEnumMapValue.Values.Count;
                int i_jrThIHPAJPe9;
                for (i_jrThIHPAJPe9 = 0; i_jrThIHPAJPe9 < 2; i_jrThIHPAJPe9++) {
                    if ((ulong)o.IntSomeEnumMapValue.Values.Count < vuBoundaries[i_jrThIHPAJPe9]) {
                       byteCount = (int)(i_jrThIHPAJPe9 + 1);
                       goto guvsgoto_hUDAWzad5nKH;
                    }
                }
                byteCount = (int)i_jrThIHPAJPe9 + 1;
                guvsgoto_hUDAWzad5nKH:
                    for (int i_otqN2KMK2zuO = 0; i_otqN2KMK2zuO < byteCount; i_otqN2KMK2zuO++) {
                        if (i_otqN2KMK2zuO < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_otqN2KMK2zuO < byteCount - 1) {
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
        public void Energize(EnumMap2Object o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // MAP: SomeEnumIntMapValue
            if (o.SomeEnumIntMapValue.Keys == null || o.SomeEnumIntMapValue.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumIntMapValue.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumIntMapValue.Keys.Count;
                int i_r0fvTx4NQE2C;
                for (i_r0fvTx4NQE2C = 0; i_r0fvTx4NQE2C < 2; i_r0fvTx4NQE2C++) {
                    if ((ulong)o.SomeEnumIntMapValue.Keys.Count < vuBoundaries[i_r0fvTx4NQE2C]) {
                       byteCount = (int)(i_r0fvTx4NQE2C + 1);
                       goto guvsgoto_mjeZCkk1zwzd;
                    }
                }
                byteCount = (int)i_r0fvTx4NQE2C + 1;
                guvsgoto_mjeZCkk1zwzd:
                    for (int i_dwluKaP76eOy = 0; i_dwluKaP76eOy < byteCount; i_dwluKaP76eOy++) {
                        if (i_dwluKaP76eOy < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dwluKaP76eOy < byteCount - 1) {
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
            if (o.SomeEnumIntMapValue.Values == null || o.SomeEnumIntMapValue.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumIntMapValue.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumIntMapValue.Values.Count;
                int i_mr0EER89qLQg;
                for (i_mr0EER89qLQg = 0; i_mr0EER89qLQg < 2; i_mr0EER89qLQg++) {
                    if ((ulong)o.SomeEnumIntMapValue.Values.Count < vuBoundaries[i_mr0EER89qLQg]) {
                       byteCount = (int)(i_mr0EER89qLQg + 1);
                       goto guvsgoto_mZ8yFmJl4m7b;
                    }
                }
                byteCount = (int)i_mr0EER89qLQg + 1;
                guvsgoto_mZ8yFmJl4m7b:
                    for (int i_z0qzRBgKmQ23 = 0; i_z0qzRBgKmQ23 < byteCount; i_z0qzRBgKmQ23++) {
                        if (i_z0qzRBgKmQ23 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_z0qzRBgKmQ23 < byteCount - 1) {
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
        public void Energize(EnumSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // SET: SomeEnumSetValue
            if (o.SomeEnumSetValue == null || o.SomeEnumSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumSetValue.Count;
                int i_dkCpgPh1j2zP;
                for (i_dkCpgPh1j2zP = 0; i_dkCpgPh1j2zP < 2; i_dkCpgPh1j2zP++) {
                    if ((ulong)o.SomeEnumSetValue.Count < vuBoundaries[i_dkCpgPh1j2zP]) {
                       byteCount = (int)(i_dkCpgPh1j2zP + 1);
                       goto guvsgoto_kGhD4RI6yjZs;
                    }
                }
                byteCount = (int)i_dkCpgPh1j2zP + 1;
                guvsgoto_kGhD4RI6yjZs:
                    for (int i_yjECgwZYy6f7 = 0; i_yjECgwZYy6f7 < byteCount; i_yjECgwZYy6f7++) {
                        if (i_yjECgwZYy6f7 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_yjECgwZYy6f7 < byteCount - 1) {
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
                    ulong vuread_oFeJcURZa7qG = 0;
                    for (int i_z1EHIbUHgCHU = 0; i_z1EHIbUHgCHU < 9; i_z1EHIbUHgCHU++) {
                        byte b = bytes[index++];
                        if (i_z1EHIbUHgCHU < 8) {
                            vuread_oFeJcURZa7qG += (((ulong)b & (ulong)127) << (7 * i_z1EHIbUHgCHU));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oFeJcURZa7qG += (ulong)b << (7 * i_z1EHIbUHgCHU);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_oFeJcURZa7qG;
            switch (typeId) {
            case 11:
                {
                EnumObject o = new EnumObject();
                // REFERENCE: SomeEnumValue
                byte enumValue_fg0ctb4meEPL;
                enumValue_fg0ctb4meEPL = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_fg0ctb4meEPL]);
                    return o;
                }
            case 12:
                {
                EnumListObject o = new EnumListObject();
                // LIST: SomeEnumListValue
            // Read list item count
            ushort count_pIYykKO837Do;
                    ulong vuread_wspxmI1h7tw6 = 0;
                    for (int i_xOF9ddBEm26a = 0; i_xOF9ddBEm26a < 9; i_xOF9ddBEm26a++) {
                        byte b = bytes[index++];
                        if (i_xOF9ddBEm26a < 8) {
                            vuread_wspxmI1h7tw6 += (((ulong)b & (ulong)127) << (7 * i_xOF9ddBEm26a));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wspxmI1h7tw6 += (ulong)b << (7 * i_xOF9ddBEm26a);
                            break;
                        }
                    }
                    count_pIYykKO837Do = (ushort)vuread_wspxmI1h7tw6;
            // Read list items
            if (count_pIYykKO837Do > 0) {
                o.SomeEnumListValue = new List<SomeEnum>();
                for (int i_fvwGXJ1pNLjb = 0; i_fvwGXJ1pNLjb < count_pIYykKO837Do; i_fvwGXJ1pNLjb++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
            case 13:
                {
                EnumMapObject o = new EnumMapObject();
                // MAP: IntSomeEnumMapValue
                IList<int> intSomeEnumMapValueKeys = new List<int>();
                IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            // Read list item count
            ushort count_tGaFNINqm2EG;
                    ulong vuread_bP4ZF9c9vpk0 = 0;
                    for (int i_futyCgssFEnG = 0; i_futyCgssFEnG < 9; i_futyCgssFEnG++) {
                        byte b = bytes[index++];
                        if (i_futyCgssFEnG < 8) {
                            vuread_bP4ZF9c9vpk0 += (((ulong)b & (ulong)127) << (7 * i_futyCgssFEnG));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bP4ZF9c9vpk0 += (ulong)b << (7 * i_futyCgssFEnG);
                            break;
                        }
                    }
                    count_tGaFNINqm2EG = (ushort)vuread_bP4ZF9c9vpk0;
            // Read list items
            if (count_tGaFNINqm2EG > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                int listValue_b60NoPYu0ZBi;
                for (int i_rcUOJjPGwkts = 0; i_rcUOJjPGwkts < count_tGaFNINqm2EG; i_rcUOJjPGwkts++) {
                    // Read Int list item
                listValue_b60NoPYu0ZBi =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_b60NoPYu0ZBi);
                }
            }
            // Read list item count
            ushort count_gpYfKmaKBxWJ;
                    ulong vuread_dyVPB09w3lUA = 0;
                    for (int i_jNTvYRk3NHz9 = 0; i_jNTvYRk3NHz9 < 9; i_jNTvYRk3NHz9++) {
                        byte b = bytes[index++];
                        if (i_jNTvYRk3NHz9 < 8) {
                            vuread_dyVPB09w3lUA += (((ulong)b & (ulong)127) << (7 * i_jNTvYRk3NHz9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dyVPB09w3lUA += (ulong)b << (7 * i_jNTvYRk3NHz9);
                            break;
                        }
                    }
                    count_gpYfKmaKBxWJ = (ushort)vuread_dyVPB09w3lUA;
            // Read list items
            if (count_gpYfKmaKBxWJ > 0) {
                intSomeEnumMapValueValues = new List<SomeEnum>();
                for (int i_wSUOZ1QqpkFk = 0; i_wSUOZ1QqpkFk < count_gpYfKmaKBxWJ; i_wSUOZ1QqpkFk++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                o.IntSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
                for (int i_k9fFk6zdEyT6 = 0; i_k9fFk6zdEyT6 < intSomeEnumMapValueKeys.Count; i_k9fFk6zdEyT6++) {
                    o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_k9fFk6zdEyT6]] = intSomeEnumMapValueValues[i_k9fFk6zdEyT6];
                }
                    return o;
                }
            case 14:
                {
                EnumMap2Object o = new EnumMap2Object();
                // MAP: SomeEnumIntMapValue
                IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
                IList<int> someEnumIntMapValueValues = new List<int>();
            // Read list item count
            ushort count_mOWUm26L9VYS;
                    ulong vuread_cvHbEDklhI7Y = 0;
                    for (int i_qPSQhvED9Xlk = 0; i_qPSQhvED9Xlk < 9; i_qPSQhvED9Xlk++) {
                        byte b = bytes[index++];
                        if (i_qPSQhvED9Xlk < 8) {
                            vuread_cvHbEDklhI7Y += (((ulong)b & (ulong)127) << (7 * i_qPSQhvED9Xlk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cvHbEDklhI7Y += (ulong)b << (7 * i_qPSQhvED9Xlk);
                            break;
                        }
                    }
                    count_mOWUm26L9VYS = (ushort)vuread_cvHbEDklhI7Y;
            // Read list items
            if (count_mOWUm26L9VYS > 0) {
                someEnumIntMapValueKeys = new List<SomeEnum>();
                for (int i_c6exo4kNlwzZ = 0; i_c6exo4kNlwzZ < count_mOWUm26L9VYS; i_c6exo4kNlwzZ++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_kxJboHY4R7iH;
                    ulong vuread_epDOqvSskx6I = 0;
                    for (int i_kX6nxuMpq3sT = 0; i_kX6nxuMpq3sT < 9; i_kX6nxuMpq3sT++) {
                        byte b = bytes[index++];
                        if (i_kX6nxuMpq3sT < 8) {
                            vuread_epDOqvSskx6I += (((ulong)b & (ulong)127) << (7 * i_kX6nxuMpq3sT));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_epDOqvSskx6I += (ulong)b << (7 * i_kX6nxuMpq3sT);
                            break;
                        }
                    }
                    count_kxJboHY4R7iH = (ushort)vuread_epDOqvSskx6I;
            // Read list items
            if (count_kxJboHY4R7iH > 0) {
                someEnumIntMapValueValues = new List<int>();
                int listValue_uDoB9qChXGn8;
                for (int i_lGw0NgObBaMA = 0; i_lGw0NgObBaMA < count_kxJboHY4R7iH; i_lGw0NgObBaMA++) {
                    // Read Int list item
                listValue_uDoB9qChXGn8 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_uDoB9qChXGn8);
                }
            }
                o.SomeEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
                for (int i_pLHxv2rq7T2X = 0; i_pLHxv2rq7T2X < someEnumIntMapValueKeys.Count; i_pLHxv2rq7T2X++) {
                    o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_pLHxv2rq7T2X]] = someEnumIntMapValueValues[i_pLHxv2rq7T2X];
                }
                    return o;
                }
            case 15:
                {
                EnumSetObject o = new EnumSetObject();
                // SET: SomeEnumSetValue
            // Read list item count
            ushort count_cqt44ZU2K7V0;
                    ulong vuread_yWLjoqsV0Y1x = 0;
                    for (int i_sfW5p6bSOJUw = 0; i_sfW5p6bSOJUw < 9; i_sfW5p6bSOJUw++) {
                        byte b = bytes[index++];
                        if (i_sfW5p6bSOJUw < 8) {
                            vuread_yWLjoqsV0Y1x += (((ulong)b & (ulong)127) << (7 * i_sfW5p6bSOJUw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yWLjoqsV0Y1x += (ulong)b << (7 * i_sfW5p6bSOJUw);
                            break;
                        }
                    }
                    count_cqt44ZU2K7V0 = (ushort)vuread_yWLjoqsV0Y1x;
            // Read list items
            if (count_cqt44ZU2K7V0 > 0) {
                o.SomeEnumSetValue = new HashSet<SomeEnum>();
                for (int i_uUhLqU0M0QzI = 0; i_uUhLqU0M0QzI < count_cqt44ZU2K7V0; i_uUhLqU0M0QzI++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_hhbQAg6sz5kY = 0;
                    for (int i_bZNN6cmycoxE = 0; i_bZNN6cmycoxE < 9; i_bZNN6cmycoxE++) {
                        byte b = bytes[index++];
                        if (i_bZNN6cmycoxE < 8) {
                            vuread_hhbQAg6sz5kY += (((ulong)b & (ulong)127) << (7 * i_bZNN6cmycoxE));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hhbQAg6sz5kY += (ulong)b << (7 * i_bZNN6cmycoxE);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_hhbQAg6sz5kY;
            switch (typeId) {
            case 11:
                {
                EnumObject o = new EnumObject();
                // REFERENCE: SomeEnumValue
                byte enumValue_dQFg7oHcPnOh;
                enumValue_dQFg7oHcPnOh = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_dQFg7oHcPnOh]);
                    return o;
                }
            case 12:
                {
                EnumListObject o = new EnumListObject();
                // LIST: SomeEnumListValue
            // Read list item count
            ushort count_yusHMB70JsIA;
                    ulong vuread_cnQXDbGcUHHT = 0;
                    for (int i_pZvlyijZlFRL = 0; i_pZvlyijZlFRL < 9; i_pZvlyijZlFRL++) {
                        byte b = bytes[index++];
                        if (i_pZvlyijZlFRL < 8) {
                            vuread_cnQXDbGcUHHT += (((ulong)b & (ulong)127) << (7 * i_pZvlyijZlFRL));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cnQXDbGcUHHT += (ulong)b << (7 * i_pZvlyijZlFRL);
                            break;
                        }
                    }
                    count_yusHMB70JsIA = (ushort)vuread_cnQXDbGcUHHT;
            // Read list items
            if (count_yusHMB70JsIA > 0) {
                o.SomeEnumListValue = new List<SomeEnum>();
                for (int i_tOVKrG40ieaT = 0; i_tOVKrG40ieaT < count_yusHMB70JsIA; i_tOVKrG40ieaT++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
            case 13:
                {
                EnumMapObject o = new EnumMapObject();
                // MAP: IntSomeEnumMapValue
                IList<int> intSomeEnumMapValueKeys = new List<int>();
                IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            // Read list item count
            ushort count_oTINRLwyXI6X;
                    ulong vuread_cVCBjTpKGfdZ = 0;
                    for (int i_g6UoMQLGZLOO = 0; i_g6UoMQLGZLOO < 9; i_g6UoMQLGZLOO++) {
                        byte b = bytes[index++];
                        if (i_g6UoMQLGZLOO < 8) {
                            vuread_cVCBjTpKGfdZ += (((ulong)b & (ulong)127) << (7 * i_g6UoMQLGZLOO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cVCBjTpKGfdZ += (ulong)b << (7 * i_g6UoMQLGZLOO);
                            break;
                        }
                    }
                    count_oTINRLwyXI6X = (ushort)vuread_cVCBjTpKGfdZ;
            // Read list items
            if (count_oTINRLwyXI6X > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                int listValue_oFiJisXlS8DG;
                for (int i_bCRyZznCQTxU = 0; i_bCRyZznCQTxU < count_oTINRLwyXI6X; i_bCRyZznCQTxU++) {
                    // Read Int list item
                listValue_oFiJisXlS8DG =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_oFiJisXlS8DG);
                }
            }
            // Read list item count
            ushort count_wiVg7z7FgX2N;
                    ulong vuread_pPCnr1hrCokk = 0;
                    for (int i_zmQAxm7ZhxSa = 0; i_zmQAxm7ZhxSa < 9; i_zmQAxm7ZhxSa++) {
                        byte b = bytes[index++];
                        if (i_zmQAxm7ZhxSa < 8) {
                            vuread_pPCnr1hrCokk += (((ulong)b & (ulong)127) << (7 * i_zmQAxm7ZhxSa));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pPCnr1hrCokk += (ulong)b << (7 * i_zmQAxm7ZhxSa);
                            break;
                        }
                    }
                    count_wiVg7z7FgX2N = (ushort)vuread_pPCnr1hrCokk;
            // Read list items
            if (count_wiVg7z7FgX2N > 0) {
                intSomeEnumMapValueValues = new List<SomeEnum>();
                for (int i_nQosa8zpJeYk = 0; i_nQosa8zpJeYk < count_wiVg7z7FgX2N; i_nQosa8zpJeYk++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                o.IntSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
                for (int i_yakZMfsN8LhV = 0; i_yakZMfsN8LhV < intSomeEnumMapValueKeys.Count; i_yakZMfsN8LhV++) {
                    o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_yakZMfsN8LhV]] = intSomeEnumMapValueValues[i_yakZMfsN8LhV];
                }
                    return o;
                }
            case 14:
                {
                EnumMap2Object o = new EnumMap2Object();
                // MAP: SomeEnumIntMapValue
                IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
                IList<int> someEnumIntMapValueValues = new List<int>();
            // Read list item count
            ushort count_sGh40dFn7BPK;
                    ulong vuread_qZqEY4K4yGDx = 0;
                    for (int i_ahncffc6IDIE = 0; i_ahncffc6IDIE < 9; i_ahncffc6IDIE++) {
                        byte b = bytes[index++];
                        if (i_ahncffc6IDIE < 8) {
                            vuread_qZqEY4K4yGDx += (((ulong)b & (ulong)127) << (7 * i_ahncffc6IDIE));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qZqEY4K4yGDx += (ulong)b << (7 * i_ahncffc6IDIE);
                            break;
                        }
                    }
                    count_sGh40dFn7BPK = (ushort)vuread_qZqEY4K4yGDx;
            // Read list items
            if (count_sGh40dFn7BPK > 0) {
                someEnumIntMapValueKeys = new List<SomeEnum>();
                for (int i_wEzGILmFuJnX = 0; i_wEzGILmFuJnX < count_sGh40dFn7BPK; i_wEzGILmFuJnX++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_vYYdanwmdT3S;
                    ulong vuread_vDh2zTbjqWNt = 0;
                    for (int i_mewWt7dC4znr = 0; i_mewWt7dC4znr < 9; i_mewWt7dC4znr++) {
                        byte b = bytes[index++];
                        if (i_mewWt7dC4znr < 8) {
                            vuread_vDh2zTbjqWNt += (((ulong)b & (ulong)127) << (7 * i_mewWt7dC4znr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vDh2zTbjqWNt += (ulong)b << (7 * i_mewWt7dC4znr);
                            break;
                        }
                    }
                    count_vYYdanwmdT3S = (ushort)vuread_vDh2zTbjqWNt;
            // Read list items
            if (count_vYYdanwmdT3S > 0) {
                someEnumIntMapValueValues = new List<int>();
                int listValue_g85vgwAhLRQf;
                for (int i_mufKHeHblEI6 = 0; i_mufKHeHblEI6 < count_vYYdanwmdT3S; i_mufKHeHblEI6++) {
                    // Read Int list item
                listValue_g85vgwAhLRQf =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_g85vgwAhLRQf);
                }
            }
                o.SomeEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
                for (int i_wK2fQBXAp0LB = 0; i_wK2fQBXAp0LB < someEnumIntMapValueKeys.Count; i_wK2fQBXAp0LB++) {
                    o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_wK2fQBXAp0LB]] = someEnumIntMapValueValues[i_wK2fQBXAp0LB];
                }
                    return o;
                }
            case 15:
                {
                EnumSetObject o = new EnumSetObject();
                // SET: SomeEnumSetValue
            // Read list item count
            ushort count_uQc3wFSXxrt8;
                    ulong vuread_wC402lfVz9FG = 0;
                    for (int i_muAk3qZMTOW1 = 0; i_muAk3qZMTOW1 < 9; i_muAk3qZMTOW1++) {
                        byte b = bytes[index++];
                        if (i_muAk3qZMTOW1 < 8) {
                            vuread_wC402lfVz9FG += (((ulong)b & (ulong)127) << (7 * i_muAk3qZMTOW1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wC402lfVz9FG += (ulong)b << (7 * i_muAk3qZMTOW1);
                            break;
                        }
                    }
                    count_uQc3wFSXxrt8 = (ushort)vuread_wC402lfVz9FG;
            // Read list items
            if (count_uQc3wFSXxrt8 > 0) {
                o.SomeEnumSetValue = new HashSet<SomeEnum>();
                for (int i_aNPPWVIJq4nn = 0; i_aNPPWVIJq4nn < count_uQc3wFSXxrt8; i_aNPPWVIJq4nn++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
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
                EnumObject o = new EnumObject();
                // REFERENCE: SomeEnumValue
                byte enumValue_n7IdU0bXkGzb;
                enumValue_n7IdU0bXkGzb = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_n7IdU0bXkGzb]);
                    return o;
                }
            case 12:
                {
                EnumListObject o = new EnumListObject();
                // LIST: SomeEnumListValue
            // Read list item count
            ushort count_bH4gBRpnPcYo;
                    ulong vuread_nA9OA5qJhmN5 = 0;
                    for (int i_sV13N9QFnOKo = 0; i_sV13N9QFnOKo < 9; i_sV13N9QFnOKo++) {
                        byte b = bytes[index++];
                        if (i_sV13N9QFnOKo < 8) {
                            vuread_nA9OA5qJhmN5 += (((ulong)b & (ulong)127) << (7 * i_sV13N9QFnOKo));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nA9OA5qJhmN5 += (ulong)b << (7 * i_sV13N9QFnOKo);
                            break;
                        }
                    }
                    count_bH4gBRpnPcYo = (ushort)vuread_nA9OA5qJhmN5;
            // Read list items
            if (count_bH4gBRpnPcYo > 0) {
                o.SomeEnumListValue = new List<SomeEnum>();
                for (int i_wBhJOaIEitHu = 0; i_wBhJOaIEitHu < count_bH4gBRpnPcYo; i_wBhJOaIEitHu++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
            case 13:
                {
                EnumMapObject o = new EnumMapObject();
                // MAP: IntSomeEnumMapValue
                IList<int> intSomeEnumMapValueKeys = new List<int>();
                IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            // Read list item count
            ushort count_wxwoq04148yP;
                    ulong vuread_vvKQvta1ZUX9 = 0;
                    for (int i_uQ4gOjXynGcp = 0; i_uQ4gOjXynGcp < 9; i_uQ4gOjXynGcp++) {
                        byte b = bytes[index++];
                        if (i_uQ4gOjXynGcp < 8) {
                            vuread_vvKQvta1ZUX9 += (((ulong)b & (ulong)127) << (7 * i_uQ4gOjXynGcp));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vvKQvta1ZUX9 += (ulong)b << (7 * i_uQ4gOjXynGcp);
                            break;
                        }
                    }
                    count_wxwoq04148yP = (ushort)vuread_vvKQvta1ZUX9;
            // Read list items
            if (count_wxwoq04148yP > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                int listValue_pBpxTSu2dCTs;
                for (int i_k2iYtQEgJxBJ = 0; i_k2iYtQEgJxBJ < count_wxwoq04148yP; i_k2iYtQEgJxBJ++) {
                    // Read Int list item
                listValue_pBpxTSu2dCTs =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_pBpxTSu2dCTs);
                }
            }
            // Read list item count
            ushort count_yXnUkaCttue3;
                    ulong vuread_bNhgA56v7LRW = 0;
                    for (int i_a8fHb5QoaQB6 = 0; i_a8fHb5QoaQB6 < 9; i_a8fHb5QoaQB6++) {
                        byte b = bytes[index++];
                        if (i_a8fHb5QoaQB6 < 8) {
                            vuread_bNhgA56v7LRW += (((ulong)b & (ulong)127) << (7 * i_a8fHb5QoaQB6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bNhgA56v7LRW += (ulong)b << (7 * i_a8fHb5QoaQB6);
                            break;
                        }
                    }
                    count_yXnUkaCttue3 = (ushort)vuread_bNhgA56v7LRW;
            // Read list items
            if (count_yXnUkaCttue3 > 0) {
                intSomeEnumMapValueValues = new List<SomeEnum>();
                for (int i_nJRcaA9fXoUQ = 0; i_nJRcaA9fXoUQ < count_yXnUkaCttue3; i_nJRcaA9fXoUQ++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                o.IntSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
                for (int i_oyQOBfLugATm = 0; i_oyQOBfLugATm < intSomeEnumMapValueKeys.Count; i_oyQOBfLugATm++) {
                    o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_oyQOBfLugATm]] = intSomeEnumMapValueValues[i_oyQOBfLugATm];
                }
                    return o;
                }
            case 14:
                {
                EnumMap2Object o = new EnumMap2Object();
                // MAP: SomeEnumIntMapValue
                IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
                IList<int> someEnumIntMapValueValues = new List<int>();
            // Read list item count
            ushort count_x4rxO03xllK0;
                    ulong vuread_f3vHML8Wnz8N = 0;
                    for (int i_gcW5fh0eZFhf = 0; i_gcW5fh0eZFhf < 9; i_gcW5fh0eZFhf++) {
                        byte b = bytes[index++];
                        if (i_gcW5fh0eZFhf < 8) {
                            vuread_f3vHML8Wnz8N += (((ulong)b & (ulong)127) << (7 * i_gcW5fh0eZFhf));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_f3vHML8Wnz8N += (ulong)b << (7 * i_gcW5fh0eZFhf);
                            break;
                        }
                    }
                    count_x4rxO03xllK0 = (ushort)vuread_f3vHML8Wnz8N;
            // Read list items
            if (count_x4rxO03xllK0 > 0) {
                someEnumIntMapValueKeys = new List<SomeEnum>();
                for (int i_dLB7vxExXZAI = 0; i_dLB7vxExXZAI < count_x4rxO03xllK0; i_dLB7vxExXZAI++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_tdREC68F5NiL;
                    ulong vuread_b7seuGbSVpya = 0;
                    for (int i_ebB04L0zLolb = 0; i_ebB04L0zLolb < 9; i_ebB04L0zLolb++) {
                        byte b = bytes[index++];
                        if (i_ebB04L0zLolb < 8) {
                            vuread_b7seuGbSVpya += (((ulong)b & (ulong)127) << (7 * i_ebB04L0zLolb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_b7seuGbSVpya += (ulong)b << (7 * i_ebB04L0zLolb);
                            break;
                        }
                    }
                    count_tdREC68F5NiL = (ushort)vuread_b7seuGbSVpya;
            // Read list items
            if (count_tdREC68F5NiL > 0) {
                someEnumIntMapValueValues = new List<int>();
                int listValue_kvM2GMkEDZ3x;
                for (int i_cAcrYSXEOQtA = 0; i_cAcrYSXEOQtA < count_tdREC68F5NiL; i_cAcrYSXEOQtA++) {
                    // Read Int list item
                listValue_kvM2GMkEDZ3x =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_kvM2GMkEDZ3x);
                }
            }
                o.SomeEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
                for (int i_niLtXSaZWrO9 = 0; i_niLtXSaZWrO9 < someEnumIntMapValueKeys.Count; i_niLtXSaZWrO9++) {
                    o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_niLtXSaZWrO9]] = someEnumIntMapValueValues[i_niLtXSaZWrO9];
                }
                    return o;
                }
            case 15:
                {
                EnumSetObject o = new EnumSetObject();
                // SET: SomeEnumSetValue
            // Read list item count
            ushort count_xiljf4HvheVD;
                    ulong vuread_oIK3BQwScmxy = 0;
                    for (int i_a0QUZeKXWdxQ = 0; i_a0QUZeKXWdxQ < 9; i_a0QUZeKXWdxQ++) {
                        byte b = bytes[index++];
                        if (i_a0QUZeKXWdxQ < 8) {
                            vuread_oIK3BQwScmxy += (((ulong)b & (ulong)127) << (7 * i_a0QUZeKXWdxQ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oIK3BQwScmxy += (ulong)b << (7 * i_a0QUZeKXWdxQ);
                            break;
                        }
                    }
                    count_xiljf4HvheVD = (ushort)vuread_oIK3BQwScmxy;
            // Read list items
            if (count_xiljf4HvheVD > 0) {
                o.SomeEnumSetValue = new HashSet<SomeEnum>();
                for (int i_nNyUj8tBwhUp = 0; i_nNyUj8tBwhUp < count_xiljf4HvheVD; i_nNyUj8tBwhUp++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
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
    }
}
