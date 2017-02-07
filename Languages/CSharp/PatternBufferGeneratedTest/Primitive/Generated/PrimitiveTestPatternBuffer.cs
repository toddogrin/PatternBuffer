
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Primitive {
    public class PrimitiveTestPatternBuffer {
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
        private byte[] bytes;
        public PrimitiveTestPatternBuffer() : this(4096) { }
        public PrimitiveTestPatternBuffer(uint bufferSize) {
            this.bytes = new byte[bufferSize];
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(ShortObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(LongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(UShortObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(UIntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ULongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(StringObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(DoubleObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FloatObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(BoolObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ByteObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EverythingObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VLongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VUShortObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VUIntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VULongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(HighScoreObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(ShortObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // PRIMITIVE: ShortValue
                bytes[index++] = (byte)((o.ShortValue >> 8) & 255);
                bytes[index++] = (byte)(o.ShortValue & 255);
        }
        public void Energize(IntObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 139;
            bytes[index++] = 6;
            }
                // PRIMITIVE: IntValue
                bytes[index++] = (byte)((o.IntValue >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue & 255);
        }
        public void Energize(LongObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // PRIMITIVE: LongValue
                bytes[index++] = (byte)((o.LongValue >> 56) & 255);
                bytes[index++] = (byte)((o.LongValue >> 48) & 255);
                bytes[index++] = (byte)((o.LongValue >> 40) & 255);
                bytes[index++] = (byte)((o.LongValue >> 32) & 255);
                bytes[index++] = (byte)((o.LongValue >> 24) & 255);
                bytes[index++] = (byte)((o.LongValue >> 16) & 255);
                bytes[index++] = (byte)((o.LongValue >> 8) & 255);
                bytes[index++] = (byte)(o.LongValue & 255);
        }
        public void Energize(UShortObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // PRIMITIVE: UshortValue
                bytes[index++] = (byte)((o.UshortValue >> 8) & 255);
                bytes[index++] = (byte)(o.UshortValue & 255);
        }
        public void Energize(UIntObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // PRIMITIVE: UintValue
                bytes[index++] = (byte)((o.UintValue >> 24) & 255);
                bytes[index++] = (byte)((o.UintValue >> 16) & 255);
                bytes[index++] = (byte)((o.UintValue >> 8) & 255);
                bytes[index++] = (byte)(o.UintValue & 255);
        }
        public void Energize(ULongObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // PRIMITIVE: UlongValue
                bytes[index++] = (byte)((o.UlongValue >> 56) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 48) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 40) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 32) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 24) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 16) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 8) & 255);
                bytes[index++] = (byte)(o.UlongValue & 255);
        }
        public void Energize(StringObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 17;
            }
                // PRIMITIVE: StringValue
                uint stringLength_g93bJqpQhFE5;
                int i_zroQ8zJAU9eu;
                for (i_zroQ8zJAU9eu = 0; i_zroQ8zJAU9eu < 2; i_zroQ8zJAU9eu++) {
                    if ((ulong)o.StringValue.Length < vuBoundaries[i_zroQ8zJAU9eu]) {
                       stringLength_g93bJqpQhFE5 = (uint)(i_zroQ8zJAU9eu + 1);
                       goto guvsgoto_nsXxZkSQEM2f;
                    }
                }
                stringLength_g93bJqpQhFE5 = (uint)i_zroQ8zJAU9eu + 1;
                guvsgoto_nsXxZkSQEM2f:
                if (o.StringValue.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.StringValue.Length;
                    for (int i_u8IgXXuTayTO = 0; i_u8IgXXuTayTO < stringLength_g93bJqpQhFE5; i_u8IgXXuTayTO++) {
                        if (i_u8IgXXuTayTO < stringLength_g93bJqpQhFE5 - 1) {
                            byte b = (byte)(value & 127);
                            if (i_u8IgXXuTayTO < stringLength_g93bJqpQhFE5 - 1) {
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
                index += Encoding.UTF8.GetBytes(o.StringValue, 0, o.StringValue.Length, bytes, index);
        }
        public void Energize(DoubleObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 18;
            }
                // PRIMITIVE: DoubleValue
                double double_apBg0UkLhYcs = o.DoubleValue;
                ulong doubleAsULong_aISS6dlGoCL1;
                unsafe {
                    doubleAsULong_aISS6dlGoCL1 = *((ulong*)&(double_apBg0UkLhYcs));
                }
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 56) & 255);
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 48) & 255);
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 40) & 255);
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 32) & 255);
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 24) & 255);
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 16) & 255);
                bytes[index++] = (byte)((doubleAsULong_aISS6dlGoCL1 >> 8) & 255);
                bytes[index++] = (byte)(doubleAsULong_aISS6dlGoCL1 & 255);
        }
        public void Energize(FloatObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 19;
            }
                // PRIMITIVE: FloatValue
                float float_qL3QsieKHJOT = o.FloatValue;
                uint floatAsUInt_zDKaYCn75peo;
                unsafe {
                    floatAsUInt_zDKaYCn75peo = *((uint*)&(float_qL3QsieKHJOT));
                }
                bytes[index++] = (byte)((floatAsUInt_zDKaYCn75peo >> 24) & 255);
                bytes[index++] = (byte)((floatAsUInt_zDKaYCn75peo >> 16) & 255);
                bytes[index++] = (byte)((floatAsUInt_zDKaYCn75peo >> 8) & 255);
                bytes[index++] = (byte)(floatAsUInt_zDKaYCn75peo & 255);
        }
        public void Energize(BoolObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 20;
            }
                // PRIMITIVE: BoolValue
                bytes[index++] = o.BoolValue ? (byte)1 : (byte)0;
        }
        public void Energize(ByteObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 21;
            }
                // PRIMITIVE: ByteValue
                bytes[index++] = o.ByteValue;
        }
        public void Energize(EverythingObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 22;
            }
                // PRIMITIVE: ShortValue
                bytes[index++] = (byte)((o.ShortValue >> 8) & 255);
                bytes[index++] = (byte)(o.ShortValue & 255);
                // PRIMITIVE: IntValue
                bytes[index++] = (byte)((o.IntValue >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue & 255);
                // PRIMITIVE: LongValue
                bytes[index++] = (byte)((o.LongValue >> 56) & 255);
                bytes[index++] = (byte)((o.LongValue >> 48) & 255);
                bytes[index++] = (byte)((o.LongValue >> 40) & 255);
                bytes[index++] = (byte)((o.LongValue >> 32) & 255);
                bytes[index++] = (byte)((o.LongValue >> 24) & 255);
                bytes[index++] = (byte)((o.LongValue >> 16) & 255);
                bytes[index++] = (byte)((o.LongValue >> 8) & 255);
                bytes[index++] = (byte)(o.LongValue & 255);
                // PRIMITIVE: UshortValue
                bytes[index++] = (byte)((o.UshortValue >> 8) & 255);
                bytes[index++] = (byte)(o.UshortValue & 255);
                // PRIMITIVE: UintValue
                bytes[index++] = (byte)((o.UintValue >> 24) & 255);
                bytes[index++] = (byte)((o.UintValue >> 16) & 255);
                bytes[index++] = (byte)((o.UintValue >> 8) & 255);
                bytes[index++] = (byte)(o.UintValue & 255);
                // PRIMITIVE: UlongValue
                bytes[index++] = (byte)((o.UlongValue >> 56) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 48) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 40) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 32) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 24) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 16) & 255);
                bytes[index++] = (byte)((o.UlongValue >> 8) & 255);
                bytes[index++] = (byte)(o.UlongValue & 255);
                // PRIMITIVE: StringValue
                uint stringLength_cLX7nnAJNJDo;
                int i_mkRVpN5wHOLQ;
                for (i_mkRVpN5wHOLQ = 0; i_mkRVpN5wHOLQ < 2; i_mkRVpN5wHOLQ++) {
                    if ((ulong)o.StringValue.Length < vuBoundaries[i_mkRVpN5wHOLQ]) {
                       stringLength_cLX7nnAJNJDo = (uint)(i_mkRVpN5wHOLQ + 1);
                       goto guvsgoto_wEt8UBUC48UC;
                    }
                }
                stringLength_cLX7nnAJNJDo = (uint)i_mkRVpN5wHOLQ + 1;
                guvsgoto_wEt8UBUC48UC:
                if (o.StringValue.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.StringValue.Length;
                    for (int i_ihxuiefy9wju = 0; i_ihxuiefy9wju < stringLength_cLX7nnAJNJDo; i_ihxuiefy9wju++) {
                        if (i_ihxuiefy9wju < stringLength_cLX7nnAJNJDo - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ihxuiefy9wju < stringLength_cLX7nnAJNJDo - 1) {
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
                index += Encoding.UTF8.GetBytes(o.StringValue, 0, o.StringValue.Length, bytes, index);
                // PRIMITIVE: DoubleValue
                double double_donDEMtg1vEc = o.DoubleValue;
                ulong doubleAsULong_nOu9OhRm3MNM;
                unsafe {
                    doubleAsULong_nOu9OhRm3MNM = *((ulong*)&(double_donDEMtg1vEc));
                }
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 56) & 255);
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 48) & 255);
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 40) & 255);
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 32) & 255);
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 24) & 255);
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 16) & 255);
                bytes[index++] = (byte)((doubleAsULong_nOu9OhRm3MNM >> 8) & 255);
                bytes[index++] = (byte)(doubleAsULong_nOu9OhRm3MNM & 255);
                // PRIMITIVE: FloatValue
                float float_bAuZ2wCgbxMa = o.FloatValue;
                uint floatAsUInt_lB14vEYaNvYD;
                unsafe {
                    floatAsUInt_lB14vEYaNvYD = *((uint*)&(float_bAuZ2wCgbxMa));
                }
                bytes[index++] = (byte)((floatAsUInt_lB14vEYaNvYD >> 24) & 255);
                bytes[index++] = (byte)((floatAsUInt_lB14vEYaNvYD >> 16) & 255);
                bytes[index++] = (byte)((floatAsUInt_lB14vEYaNvYD >> 8) & 255);
                bytes[index++] = (byte)(floatAsUInt_lB14vEYaNvYD & 255);
                // PRIMITIVE: BoolValue
                bytes[index++] = o.BoolValue ? (byte)1 : (byte)0;
                // PRIMITIVE: ByteValue
                bytes[index++] = o.ByteValue;
        }
        public void Energize(VIntObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 112;
            }
                // PRIMITIVE: VintValue
    //// AppendSignedToULong(o.VintValue)
    long s2ultemp_tgT2P6BGLKze = o.VintValue;
    if (s2ultemp_tgT2P6BGLKze == long.MinValue) {
        s2ultemp_tgT2P6BGLKze = long.MaxValue;
    }
    else {
        if (s2ultemp_tgT2P6BGLKze > 0) {
            s2ultemp_tgT2P6BGLKze = -s2ultemp_tgT2P6BGLKze;
        }
        s2ultemp_tgT2P6BGLKze -= 1;
    }
    s2ultemp_tgT2P6BGLKze = ~s2ultemp_tgT2P6BGLKze;
    ulong s2ulresult_hEoF2xaictJm = (ulong)s2ultemp_tgT2P6BGLKze;
    //// AppendGetSignVariantSize(s2ulresult_hEoF2xaictJm)
    byte vr_gW1yYN9TL0fW = 1;
    for (int v_qJBe5gz0cXM1 = 56; v_qJBe5gz0cXM1 >= 0; v_qJBe5gz0cXM1 -= 8) {
        if (((255UL << v_qJBe5gz0cXM1) & s2ulresult_hEoF2xaictJm) > 0) {
            vr_gW1yYN9TL0fW = (byte)(v_qJBe5gz0cXM1 / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_gW1yYN9TL0fW << 1) | (byte)(o.VintValue > 0 ? 0 : 1));
    for (int vi_gshpuQBAGHN3 = 0; vi_gshpuQBAGHN3 < vr_gW1yYN9TL0fW - 1; vi_gshpuQBAGHN3++) {
        bytes[index++] = (byte)(s2ulresult_hEoF2xaictJm & 255);
        s2ulresult_hEoF2xaictJm = s2ulresult_hEoF2xaictJm >> 8;
    }
        }
        public void Energize(VLongObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 113;
            }
                // PRIMITIVE: VlongValue
    //// AppendSignedToULong(o.VlongValue)
    long s2ultemp_ccR7KPCBzB3s = o.VlongValue;
    if (s2ultemp_ccR7KPCBzB3s == long.MinValue) {
        s2ultemp_ccR7KPCBzB3s = long.MaxValue;
    }
    else {
        if (s2ultemp_ccR7KPCBzB3s > 0) {
            s2ultemp_ccR7KPCBzB3s = -s2ultemp_ccR7KPCBzB3s;
        }
        s2ultemp_ccR7KPCBzB3s -= 1;
    }
    s2ultemp_ccR7KPCBzB3s = ~s2ultemp_ccR7KPCBzB3s;
    ulong s2ulresult_y5m54TjBj9iF = (ulong)s2ultemp_ccR7KPCBzB3s;
    //// AppendGetSignVariantSize(s2ulresult_y5m54TjBj9iF)
    byte vr_nTz5zOpe6I83 = 1;
    for (int v_kBpxulCYzYty = 56; v_kBpxulCYzYty >= 0; v_kBpxulCYzYty -= 8) {
        if (((255UL << v_kBpxulCYzYty) & s2ulresult_y5m54TjBj9iF) > 0) {
            vr_nTz5zOpe6I83 = (byte)(v_kBpxulCYzYty / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_nTz5zOpe6I83 << 1) | (byte)(o.VlongValue > 0 ? 0 : 1));
    for (int vi_mFGXylTf3mB0 = 0; vi_mFGXylTf3mB0 < vr_nTz5zOpe6I83 - 1; vi_mFGXylTf3mB0++) {
        bytes[index++] = (byte)(s2ulresult_y5m54TjBj9iF & 255);
        s2ulresult_y5m54TjBj9iF = s2ulresult_y5m54TjBj9iF >> 8;
    }
        }
        public void Energize(VUShortObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 114;
            }
                // PRIMITIVE: VushortValue
                if (o.VushortValue == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VushortValue;
                int i_mWh8HugQAaB3;
                for (i_mWh8HugQAaB3 = 0; i_mWh8HugQAaB3 < 2; i_mWh8HugQAaB3++) {
                    if ((ulong)o.VushortValue < vuBoundaries[i_mWh8HugQAaB3]) {
                       byteCount = (int)(i_mWh8HugQAaB3 + 1);
                       goto guvsgoto_gHcUmZvx6tHC;
                    }
                }
                byteCount = (int)i_mWh8HugQAaB3 + 1;
                guvsgoto_gHcUmZvx6tHC:
                    for (int i_dBQVY39m9ygX = 0; i_dBQVY39m9ygX < byteCount; i_dBQVY39m9ygX++) {
                        if (i_dBQVY39m9ygX < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dBQVY39m9ygX < byteCount - 1) {
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
        }
        public void Energize(VUIntObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 115;
            }
                // PRIMITIVE: VuintValue
                if (o.VuintValue == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VuintValue;
                int i_bVIJgUAqgiNU;
                for (i_bVIJgUAqgiNU = 0; i_bVIJgUAqgiNU < 4; i_bVIJgUAqgiNU++) {
                    if ((ulong)o.VuintValue < vuBoundaries[i_bVIJgUAqgiNU]) {
                       byteCount = (int)(i_bVIJgUAqgiNU + 1);
                       goto guvsgoto_dRLKD5Bk8duM;
                    }
                }
                byteCount = (int)i_bVIJgUAqgiNU + 1;
                guvsgoto_dRLKD5Bk8duM:
                    for (int i_dKJduvDfPtZ0 = 0; i_dKJduvDfPtZ0 < byteCount; i_dKJduvDfPtZ0++) {
                        if (i_dKJduvDfPtZ0 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dKJduvDfPtZ0 < byteCount - 1) {
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
        }
        public void Energize(VULongObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 116;
            }
                // PRIMITIVE: VulongValue
                if (o.VulongValue == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VulongValue;
                int i_iAfo70Rad1B2;
                for (i_iAfo70Rad1B2 = 0; i_iAfo70Rad1B2 < 8; i_iAfo70Rad1B2++) {
                    if ((ulong)o.VulongValue < vuBoundaries[i_iAfo70Rad1B2]) {
                       byteCount = (int)(i_iAfo70Rad1B2 + 1);
                       goto guvsgoto_sFnEIq5dheRd;
                    }
                }
                byteCount = (int)i_iAfo70Rad1B2 + 1;
                guvsgoto_sFnEIq5dheRd:
                    for (int i_jy0NKo6U6RZK = 0; i_jy0NKo6U6RZK < byteCount; i_jy0NKo6U6RZK++) {
                        if (i_jy0NKo6U6RZK < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_jy0NKo6U6RZK < byteCount - 1) {
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
        }
        public void Energize(HighScoreObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 117;
            }
                // PRIMITIVE: Name
                uint stringLength_n6RZnJNe3GS4;
                int i_lrD2h6gNKERb;
                for (i_lrD2h6gNKERb = 0; i_lrD2h6gNKERb < 2; i_lrD2h6gNKERb++) {
                    if ((ulong)o.Name.Length < vuBoundaries[i_lrD2h6gNKERb]) {
                       stringLength_n6RZnJNe3GS4 = (uint)(i_lrD2h6gNKERb + 1);
                       goto guvsgoto_gohZMZW2evhk;
                    }
                }
                stringLength_n6RZnJNe3GS4 = (uint)i_lrD2h6gNKERb + 1;
                guvsgoto_gohZMZW2evhk:
                if (o.Name.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.Name.Length;
                    for (int i_d1WEnw90P6xw = 0; i_d1WEnw90P6xw < stringLength_n6RZnJNe3GS4; i_d1WEnw90P6xw++) {
                        if (i_d1WEnw90P6xw < stringLength_n6RZnJNe3GS4 - 1) {
                            byte b = (byte)(value & 127);
                            if (i_d1WEnw90P6xw < stringLength_n6RZnJNe3GS4 - 1) {
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
                index += Encoding.UTF8.GetBytes(o.Name, 0, o.Name.Length, bytes, index);
                // PRIMITIVE: HighScore
                if (o.HighScore == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.HighScore;
                int i_cU66zftUGgQU;
                for (i_cU66zftUGgQU = 0; i_cU66zftUGgQU < 4; i_cU66zftUGgQU++) {
                    if ((ulong)o.HighScore < vuBoundaries[i_cU66zftUGgQU]) {
                       byteCount = (int)(i_cU66zftUGgQU + 1);
                       goto guvsgoto_dgig47GlYHy5;
                    }
                }
                byteCount = (int)i_cU66zftUGgQU + 1;
                guvsgoto_dgig47GlYHy5:
                    for (int i_bsORvrFE4hVb = 0; i_bsORvrFE4hVb < byteCount; i_bsORvrFE4hVb++) {
                        if (i_bsORvrFE4hVb < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_bsORvrFE4hVb < byteCount - 1) {
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
        }
        public void Energize(IPrimitiveTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 11:
                    Energize((ShortObject)o, bytes, ref index, writeTypeId);
                    break;
                case 779:
                    Energize((IntObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((LongObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((UShortObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((UIntObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((ULongObject)o, bytes, ref index, writeTypeId);
                    break;
                case 17:
                    Energize((StringObject)o, bytes, ref index, writeTypeId);
                    break;
                case 18:
                    Energize((DoubleObject)o, bytes, ref index, writeTypeId);
                    break;
                case 19:
                    Energize((FloatObject)o, bytes, ref index, writeTypeId);
                    break;
                case 20:
                    Energize((BoolObject)o, bytes, ref index, writeTypeId);
                    break;
                case 21:
                    Energize((ByteObject)o, bytes, ref index, writeTypeId);
                    break;
                case 22:
                    Energize((EverythingObject)o, bytes, ref index, writeTypeId);
                    break;
                case 112:
                    Energize((VIntObject)o, bytes, ref index, writeTypeId);
                    break;
                case 113:
                    Energize((VLongObject)o, bytes, ref index, writeTypeId);
                    break;
                case 114:
                    Energize((VUShortObject)o, bytes, ref index, writeTypeId);
                    break;
                case 115:
                    Energize((VUIntObject)o, bytes, ref index, writeTypeId);
                    break;
                case 116:
                    Energize((VULongObject)o, bytes, ref index, writeTypeId);
                    break;
                case 117:
                    Energize((HighScoreObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new PrimitiveTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_u9SM8FmLC0yC = 0;
                    for (int i_kdAKMMZbAydM = 0; i_kdAKMMZbAydM < 9; i_kdAKMMZbAydM++) {
                        byte b = bytes[index++];
                        if (i_kdAKMMZbAydM < 8) {
                            vuread_u9SM8FmLC0yC += (((ulong)b & (ulong)127) << (7 * i_kdAKMMZbAydM));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_u9SM8FmLC0yC += (ulong)b << (7 * i_kdAKMMZbAydM);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_u9SM8FmLC0yC;
            switch (typeId) {
            case 11:
                {
                ShortObject o = new ShortObject();
                // PRIMITIVE: ShortValue
                o.ShortValue =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                    return o;
                }
            case 779:
                {
                IntObject o = new IntObject();
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 13:
                {
                LongObject o = new LongObject();
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                    return o;
                }
            case 14:
                {
                UShortObject o = new UShortObject();
                // PRIMITIVE: UshortValue
                o.UshortValue =
                    (ushort)(
                        ((ushort)bytes[index++] << 8) |
                        (ushort)bytes[index++]
                    );
                    return o;
                }
            case 15:
                {
                UIntObject o = new UIntObject();
                // PRIMITIVE: UintValue
                o.UintValue =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                    return o;
                }
            case 16:
                {
                ULongObject o = new ULongObject();
                // PRIMITIVE: UlongValue
                o.UlongValue =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                    return o;
                }
            case 17:
                {
                StringObject o = new StringObject();
                // PRIMITIVE: StringValue
                    ulong vuread_jRWb3frm3lss = 0;
                    for (int i_w52rsUKz5ftk = 0; i_w52rsUKz5ftk < 9; i_w52rsUKz5ftk++) {
                        byte b = bytes[index++];
                        if (i_w52rsUKz5ftk < 8) {
                            vuread_jRWb3frm3lss += (((ulong)b & (ulong)127) << (7 * i_w52rsUKz5ftk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jRWb3frm3lss += (ulong)b << (7 * i_w52rsUKz5ftk);
                            break;
                        }
                    }
                    ushort stringLength_iY0Gb4b995iz = (ushort)vuread_jRWb3frm3lss;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_iY0Gb4b995iz);
                index += stringLength_iY0Gb4b995iz;
                    return o;
                }
            case 18:
                {
                DoubleObject o = new DoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_vXhuh1ShGIOg =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                double double_rQJIYzDE4an4;
                unsafe {
                    double_rQJIYzDE4an4 = *((double*)&(doubleAsUInt_vXhuh1ShGIOg));
                }
                o.DoubleValue = double_rQJIYzDE4an4;
                    return o;
                }
            case 19:
                {
                FloatObject o = new FloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_nSyESYy0R7BE =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_aUQpuTDqyMvm;
                unsafe {
                    float_aUQpuTDqyMvm = *((float*)&(floatAsUInt_nSyESYy0R7BE));
                }
                o.FloatValue = float_aUQpuTDqyMvm;
                    return o;
                }
            case 20:
                {
                BoolObject o = new BoolObject();
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                    return o;
                }
            case 21:
                {
                ByteObject o = new ByteObject();
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 22:
                {
                EverythingObject o = new EverythingObject();
                // PRIMITIVE: ShortValue
                o.ShortValue =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                // PRIMITIVE: UshortValue
                o.UshortValue =
                    (ushort)(
                        ((ushort)bytes[index++] << 8) |
                        (ushort)bytes[index++]
                    );
                // PRIMITIVE: UintValue
                o.UintValue =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                // PRIMITIVE: UlongValue
                o.UlongValue =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                // PRIMITIVE: StringValue
                    ulong vuread_sojkG6GoB5Yy = 0;
                    for (int i_mozSkYzetmNe = 0; i_mozSkYzetmNe < 9; i_mozSkYzetmNe++) {
                        byte b = bytes[index++];
                        if (i_mozSkYzetmNe < 8) {
                            vuread_sojkG6GoB5Yy += (((ulong)b & (ulong)127) << (7 * i_mozSkYzetmNe));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sojkG6GoB5Yy += (ulong)b << (7 * i_mozSkYzetmNe);
                            break;
                        }
                    }
                    ushort stringLength_qqrewlNhbCGe = (ushort)vuread_sojkG6GoB5Yy;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_qqrewlNhbCGe);
                index += stringLength_qqrewlNhbCGe;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_rnuUBmcRB2Li =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                double double_lz4n8oldmtWD;
                unsafe {
                    double_lz4n8oldmtWD = *((double*)&(doubleAsUInt_rnuUBmcRB2Li));
                }
                o.DoubleValue = double_lz4n8oldmtWD;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_asqnUVmjB5d6 =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_t57ndBVFKeSh;
                unsafe {
                    float_t57ndBVFKeSh = *((float*)&(floatAsUInt_asqnUVmjB5d6));
                }
                o.FloatValue = float_t57ndBVFKeSh;
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 112:
                {
                VIntObject o = new VIntObject();
                // PRIMITIVE: VintValue
    byte rvint_b_mOMgj6NJXVCc = bytes[index++];
    byte rvint_sign_h79UIr3KFmSj = (byte)(rvint_b_mOMgj6NJXVCc & 1);
    byte rvint_size_yZ6PPBRZ2aTy = (byte)(rvint_b_mOMgj6NJXVCc >> 1);
    ulong rvint_remaining_vPvOBitq0n5W = 0;
    for (int i_uCLjcDAr5Dku = 0; i_uCLjcDAr5Dku < rvint_size_yZ6PPBRZ2aTy - 1; i_uCLjcDAr5Dku++) {
        rvint_remaining_vPvOBitq0n5W = rvint_remaining_vPvOBitq0n5W | (((ulong)bytes[index++] << (8 * i_uCLjcDAr5Dku)));
    }
    int rvint_result_z74weNkqoK53 = (int)rvint_remaining_vPvOBitq0n5W;
    rvint_result_z74weNkqoK53 = ~rvint_result_z74weNkqoK53;
    if (rvint_result_z74weNkqoK53 == int.MaxValue) {
        rvint_result_z74weNkqoK53 = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_z74weNkqoK53 += 1;
        if (rvint_sign_h79UIr3KFmSj == 0) {
            rvint_result_z74weNkqoK53 = -rvint_result_z74weNkqoK53;
        }
    }
    o.VintValue = rvint_result_z74weNkqoK53;
                    return o;
                }
            case 113:
                {
                VLongObject o = new VLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_yoix3BsS4k3n = bytes[index++];
    byte rvlong_sign_wHWyJCCvEbPD = (byte)(rvlong_b_yoix3BsS4k3n & 1);
    byte rvlong_size_f7mndOIlHSoY = (byte)(rvlong_b_yoix3BsS4k3n >> 1);
    ulong rvlong_remaining_idyEkBAYeQFG = 0;
    for (int i_wVQWhJy4IPj5 = 0; i_wVQWhJy4IPj5 < rvlong_size_f7mndOIlHSoY - 1; i_wVQWhJy4IPj5++) {
        rvlong_remaining_idyEkBAYeQFG = rvlong_remaining_idyEkBAYeQFG | (((ulong)bytes[index++] << (8 * i_wVQWhJy4IPj5)));
    }
    long rvlong_result_gfPpLRQit7dG = (long)rvlong_remaining_idyEkBAYeQFG;
    rvlong_result_gfPpLRQit7dG = ~rvlong_result_gfPpLRQit7dG;
    if (rvlong_result_gfPpLRQit7dG == long.MaxValue) {
        rvlong_result_gfPpLRQit7dG = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_gfPpLRQit7dG += 1;
        if (rvlong_sign_wHWyJCCvEbPD == 0) {
            rvlong_result_gfPpLRQit7dG = -rvlong_result_gfPpLRQit7dG;
        }
    }
    o.VlongValue = rvlong_result_gfPpLRQit7dG;
                    return o;
                }
            case 114:
                {
                VUShortObject o = new VUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_b8ldK0yHCQvr = 0;
                    for (int i_yWd7ttqP3Cpe = 0; i_yWd7ttqP3Cpe < 9; i_yWd7ttqP3Cpe++) {
                        byte b = bytes[index++];
                        if (i_yWd7ttqP3Cpe < 8) {
                            vuread_b8ldK0yHCQvr += (((ulong)b & (ulong)127) << (7 * i_yWd7ttqP3Cpe));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_b8ldK0yHCQvr += (ulong)b << (7 * i_yWd7ttqP3Cpe);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_b8ldK0yHCQvr;
                    return o;
                }
            case 115:
                {
                VUIntObject o = new VUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_ukmw9xn3RkSj = 0;
                    for (int i_kutRqLDITysZ = 0; i_kutRqLDITysZ < 9; i_kutRqLDITysZ++) {
                        byte b = bytes[index++];
                        if (i_kutRqLDITysZ < 8) {
                            vuread_ukmw9xn3RkSj += (((ulong)b & (ulong)127) << (7 * i_kutRqLDITysZ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ukmw9xn3RkSj += (ulong)b << (7 * i_kutRqLDITysZ);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_ukmw9xn3RkSj;
                    return o;
                }
            case 116:
                {
                VULongObject o = new VULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_rSY9RyMKTgrA = 0;
                    for (int i_qbHfDCJXe4J9 = 0; i_qbHfDCJXe4J9 < 9; i_qbHfDCJXe4J9++) {
                        byte b = bytes[index++];
                        if (i_qbHfDCJXe4J9 < 8) {
                            vuread_rSY9RyMKTgrA += (((ulong)b & (ulong)127) << (7 * i_qbHfDCJXe4J9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rSY9RyMKTgrA += (ulong)b << (7 * i_qbHfDCJXe4J9);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_rSY9RyMKTgrA;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = new HighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_onmtHhzrd2do = 0;
                    for (int i_byfrZFVUjZ9i = 0; i_byfrZFVUjZ9i < 9; i_byfrZFVUjZ9i++) {
                        byte b = bytes[index++];
                        if (i_byfrZFVUjZ9i < 8) {
                            vuread_onmtHhzrd2do += (((ulong)b & (ulong)127) << (7 * i_byfrZFVUjZ9i));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_onmtHhzrd2do += (ulong)b << (7 * i_byfrZFVUjZ9i);
                            break;
                        }
                    }
                    ushort stringLength_aIys9Qux2xSq = (ushort)vuread_onmtHhzrd2do;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_aIys9Qux2xSq);
                index += stringLength_aIys9Qux2xSq;
                // PRIMITIVE: HighScore
                    ulong vuread_zuLdV4IqtqGp = 0;
                    for (int i_gpp6Er6hEjoK = 0; i_gpp6Er6hEjoK < 9; i_gpp6Er6hEjoK++) {
                        byte b = bytes[index++];
                        if (i_gpp6Er6hEjoK < 8) {
                            vuread_zuLdV4IqtqGp += (((ulong)b & (ulong)127) << (7 * i_gpp6Er6hEjoK));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zuLdV4IqtqGp += (ulong)b << (7 * i_gpp6Er6hEjoK);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_zuLdV4IqtqGp;
                    return o;
                }
                default:
                    throw new PrimitiveTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_pdIxM8hSodtn = 0;
                    for (int i_nvGjuX5W10bJ = 0; i_nvGjuX5W10bJ < 9; i_nvGjuX5W10bJ++) {
                        byte b = bytes[index++];
                        if (i_nvGjuX5W10bJ < 8) {
                            vuread_pdIxM8hSodtn += (((ulong)b & (ulong)127) << (7 * i_nvGjuX5W10bJ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pdIxM8hSodtn += (ulong)b << (7 * i_nvGjuX5W10bJ);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_pdIxM8hSodtn;
            switch (typeId) {
            case 11:
                {
                ShortObject o = new ShortObject();
                // PRIMITIVE: ShortValue
                o.ShortValue =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                    return o;
                }
            case 779:
                {
                IntObject o = new IntObject();
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 13:
                {
                LongObject o = new LongObject();
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                    return o;
                }
            case 14:
                {
                UShortObject o = new UShortObject();
                // PRIMITIVE: UshortValue
                o.UshortValue =
                    (ushort)(
                        ((ushort)bytes[index++] << 8) |
                        (ushort)bytes[index++]
                    );
                    return o;
                }
            case 15:
                {
                UIntObject o = new UIntObject();
                // PRIMITIVE: UintValue
                o.UintValue =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                    return o;
                }
            case 16:
                {
                ULongObject o = new ULongObject();
                // PRIMITIVE: UlongValue
                o.UlongValue =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                    return o;
                }
            case 17:
                {
                StringObject o = new StringObject();
                // PRIMITIVE: StringValue
                    ulong vuread_jlNvjXam6cAi = 0;
                    for (int i_tWWQoBTUc8hX = 0; i_tWWQoBTUc8hX < 9; i_tWWQoBTUc8hX++) {
                        byte b = bytes[index++];
                        if (i_tWWQoBTUc8hX < 8) {
                            vuread_jlNvjXam6cAi += (((ulong)b & (ulong)127) << (7 * i_tWWQoBTUc8hX));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jlNvjXam6cAi += (ulong)b << (7 * i_tWWQoBTUc8hX);
                            break;
                        }
                    }
                    ushort stringLength_gYp131O0faCR = (ushort)vuread_jlNvjXam6cAi;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_gYp131O0faCR);
                index += stringLength_gYp131O0faCR;
                    return o;
                }
            case 18:
                {
                DoubleObject o = new DoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_eKNe0YMnxggg =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                double double_spZxzDhF3YXj;
                unsafe {
                    double_spZxzDhF3YXj = *((double*)&(doubleAsUInt_eKNe0YMnxggg));
                }
                o.DoubleValue = double_spZxzDhF3YXj;
                    return o;
                }
            case 19:
                {
                FloatObject o = new FloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_zNXD45p69NHO =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_b7LOrSPwe0M3;
                unsafe {
                    float_b7LOrSPwe0M3 = *((float*)&(floatAsUInt_zNXD45p69NHO));
                }
                o.FloatValue = float_b7LOrSPwe0M3;
                    return o;
                }
            case 20:
                {
                BoolObject o = new BoolObject();
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                    return o;
                }
            case 21:
                {
                ByteObject o = new ByteObject();
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 22:
                {
                EverythingObject o = new EverythingObject();
                // PRIMITIVE: ShortValue
                o.ShortValue =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                // PRIMITIVE: UshortValue
                o.UshortValue =
                    (ushort)(
                        ((ushort)bytes[index++] << 8) |
                        (ushort)bytes[index++]
                    );
                // PRIMITIVE: UintValue
                o.UintValue =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                // PRIMITIVE: UlongValue
                o.UlongValue =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                // PRIMITIVE: StringValue
                    ulong vuread_wCokjAft7Ugn = 0;
                    for (int i_ajsB0kgAA70M = 0; i_ajsB0kgAA70M < 9; i_ajsB0kgAA70M++) {
                        byte b = bytes[index++];
                        if (i_ajsB0kgAA70M < 8) {
                            vuread_wCokjAft7Ugn += (((ulong)b & (ulong)127) << (7 * i_ajsB0kgAA70M));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wCokjAft7Ugn += (ulong)b << (7 * i_ajsB0kgAA70M);
                            break;
                        }
                    }
                    ushort stringLength_vO4ov3AMjTsB = (ushort)vuread_wCokjAft7Ugn;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_vO4ov3AMjTsB);
                index += stringLength_vO4ov3AMjTsB;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_sfWJInQeIRnm =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                double double_vBakzaUouwLB;
                unsafe {
                    double_vBakzaUouwLB = *((double*)&(doubleAsUInt_sfWJInQeIRnm));
                }
                o.DoubleValue = double_vBakzaUouwLB;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_k436912OI0UV =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_p8V8M1b3MLwR;
                unsafe {
                    float_p8V8M1b3MLwR = *((float*)&(floatAsUInt_k436912OI0UV));
                }
                o.FloatValue = float_p8V8M1b3MLwR;
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 112:
                {
                VIntObject o = new VIntObject();
                // PRIMITIVE: VintValue
    byte rvint_b_jH2mqVdhoYJB = bytes[index++];
    byte rvint_sign_gVMCuRZfSfjN = (byte)(rvint_b_jH2mqVdhoYJB & 1);
    byte rvint_size_iUeRYJNUn9Ke = (byte)(rvint_b_jH2mqVdhoYJB >> 1);
    ulong rvint_remaining_zYN0HpDKvCRn = 0;
    for (int i_gzt0bOcsxo2G = 0; i_gzt0bOcsxo2G < rvint_size_iUeRYJNUn9Ke - 1; i_gzt0bOcsxo2G++) {
        rvint_remaining_zYN0HpDKvCRn = rvint_remaining_zYN0HpDKvCRn | (((ulong)bytes[index++] << (8 * i_gzt0bOcsxo2G)));
    }
    int rvint_result_swsOkZnplHDF = (int)rvint_remaining_zYN0HpDKvCRn;
    rvint_result_swsOkZnplHDF = ~rvint_result_swsOkZnplHDF;
    if (rvint_result_swsOkZnplHDF == int.MaxValue) {
        rvint_result_swsOkZnplHDF = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_swsOkZnplHDF += 1;
        if (rvint_sign_gVMCuRZfSfjN == 0) {
            rvint_result_swsOkZnplHDF = -rvint_result_swsOkZnplHDF;
        }
    }
    o.VintValue = rvint_result_swsOkZnplHDF;
                    return o;
                }
            case 113:
                {
                VLongObject o = new VLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_b8HDLIs1d0Dy = bytes[index++];
    byte rvlong_sign_gXSJ7rQU5gjl = (byte)(rvlong_b_b8HDLIs1d0Dy & 1);
    byte rvlong_size_yYzGoBcQ6XWd = (byte)(rvlong_b_b8HDLIs1d0Dy >> 1);
    ulong rvlong_remaining_cIRZ6bC033zx = 0;
    for (int i_cOs30TK7YwHW = 0; i_cOs30TK7YwHW < rvlong_size_yYzGoBcQ6XWd - 1; i_cOs30TK7YwHW++) {
        rvlong_remaining_cIRZ6bC033zx = rvlong_remaining_cIRZ6bC033zx | (((ulong)bytes[index++] << (8 * i_cOs30TK7YwHW)));
    }
    long rvlong_result_dVNLYWCBaOCy = (long)rvlong_remaining_cIRZ6bC033zx;
    rvlong_result_dVNLYWCBaOCy = ~rvlong_result_dVNLYWCBaOCy;
    if (rvlong_result_dVNLYWCBaOCy == long.MaxValue) {
        rvlong_result_dVNLYWCBaOCy = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_dVNLYWCBaOCy += 1;
        if (rvlong_sign_gXSJ7rQU5gjl == 0) {
            rvlong_result_dVNLYWCBaOCy = -rvlong_result_dVNLYWCBaOCy;
        }
    }
    o.VlongValue = rvlong_result_dVNLYWCBaOCy;
                    return o;
                }
            case 114:
                {
                VUShortObject o = new VUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_p1Y4OtsczczK = 0;
                    for (int i_djZmnZpUb4Qk = 0; i_djZmnZpUb4Qk < 9; i_djZmnZpUb4Qk++) {
                        byte b = bytes[index++];
                        if (i_djZmnZpUb4Qk < 8) {
                            vuread_p1Y4OtsczczK += (((ulong)b & (ulong)127) << (7 * i_djZmnZpUb4Qk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_p1Y4OtsczczK += (ulong)b << (7 * i_djZmnZpUb4Qk);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_p1Y4OtsczczK;
                    return o;
                }
            case 115:
                {
                VUIntObject o = new VUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_k0cgB8xBl3s9 = 0;
                    for (int i_xPtFdExgwdCP = 0; i_xPtFdExgwdCP < 9; i_xPtFdExgwdCP++) {
                        byte b = bytes[index++];
                        if (i_xPtFdExgwdCP < 8) {
                            vuread_k0cgB8xBl3s9 += (((ulong)b & (ulong)127) << (7 * i_xPtFdExgwdCP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_k0cgB8xBl3s9 += (ulong)b << (7 * i_xPtFdExgwdCP);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_k0cgB8xBl3s9;
                    return o;
                }
            case 116:
                {
                VULongObject o = new VULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_ypnlzSxPlNGX = 0;
                    for (int i_hmLAO7yp00rI = 0; i_hmLAO7yp00rI < 9; i_hmLAO7yp00rI++) {
                        byte b = bytes[index++];
                        if (i_hmLAO7yp00rI < 8) {
                            vuread_ypnlzSxPlNGX += (((ulong)b & (ulong)127) << (7 * i_hmLAO7yp00rI));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ypnlzSxPlNGX += (ulong)b << (7 * i_hmLAO7yp00rI);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_ypnlzSxPlNGX;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = new HighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_tlcDGMXriGo0 = 0;
                    for (int i_x6ByOnYf7PPQ = 0; i_x6ByOnYf7PPQ < 9; i_x6ByOnYf7PPQ++) {
                        byte b = bytes[index++];
                        if (i_x6ByOnYf7PPQ < 8) {
                            vuread_tlcDGMXriGo0 += (((ulong)b & (ulong)127) << (7 * i_x6ByOnYf7PPQ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tlcDGMXriGo0 += (ulong)b << (7 * i_x6ByOnYf7PPQ);
                            break;
                        }
                    }
                    ushort stringLength_nTRGHJXuywkl = (ushort)vuread_tlcDGMXriGo0;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_nTRGHJXuywkl);
                index += stringLength_nTRGHJXuywkl;
                // PRIMITIVE: HighScore
                    ulong vuread_a1iLZly3bAQD = 0;
                    for (int i_y4Tndaz9F0ML = 0; i_y4Tndaz9F0ML < 9; i_y4Tndaz9F0ML++) {
                        byte b = bytes[index++];
                        if (i_y4Tndaz9F0ML < 8) {
                            vuread_a1iLZly3bAQD += (((ulong)b & (ulong)127) << (7 * i_y4Tndaz9F0ML));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_a1iLZly3bAQD += (ulong)b << (7 * i_y4Tndaz9F0ML);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_a1iLZly3bAQD;
                    return o;
                }
                default:
                    throw new PrimitiveTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 11:
                {
                ShortObject o = new ShortObject();
                // PRIMITIVE: ShortValue
                o.ShortValue =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                    return o;
                }
            case 779:
                {
                IntObject o = new IntObject();
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 13:
                {
                LongObject o = new LongObject();
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                    return o;
                }
            case 14:
                {
                UShortObject o = new UShortObject();
                // PRIMITIVE: UshortValue
                o.UshortValue =
                    (ushort)(
                        ((ushort)bytes[index++] << 8) |
                        (ushort)bytes[index++]
                    );
                    return o;
                }
            case 15:
                {
                UIntObject o = new UIntObject();
                // PRIMITIVE: UintValue
                o.UintValue =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                    return o;
                }
            case 16:
                {
                ULongObject o = new ULongObject();
                // PRIMITIVE: UlongValue
                o.UlongValue =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                    return o;
                }
            case 17:
                {
                StringObject o = new StringObject();
                // PRIMITIVE: StringValue
                    ulong vuread_mlB7huZDq8DT = 0;
                    for (int i_mLc7pQkkoHEA = 0; i_mLc7pQkkoHEA < 9; i_mLc7pQkkoHEA++) {
                        byte b = bytes[index++];
                        if (i_mLc7pQkkoHEA < 8) {
                            vuread_mlB7huZDq8DT += (((ulong)b & (ulong)127) << (7 * i_mLc7pQkkoHEA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mlB7huZDq8DT += (ulong)b << (7 * i_mLc7pQkkoHEA);
                            break;
                        }
                    }
                    ushort stringLength_dzQkIenfFwCO = (ushort)vuread_mlB7huZDq8DT;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_dzQkIenfFwCO);
                index += stringLength_dzQkIenfFwCO;
                    return o;
                }
            case 18:
                {
                DoubleObject o = new DoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_oC2kbjuj66Q6 =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                double double_nov7mL7JCeS1;
                unsafe {
                    double_nov7mL7JCeS1 = *((double*)&(doubleAsUInt_oC2kbjuj66Q6));
                }
                o.DoubleValue = double_nov7mL7JCeS1;
                    return o;
                }
            case 19:
                {
                FloatObject o = new FloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_z1rPa3rz2lxX =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_aqZZlsA7RbC3;
                unsafe {
                    float_aqZZlsA7RbC3 = *((float*)&(floatAsUInt_z1rPa3rz2lxX));
                }
                o.FloatValue = float_aqZZlsA7RbC3;
                    return o;
                }
            case 20:
                {
                BoolObject o = new BoolObject();
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                    return o;
                }
            case 21:
                {
                ByteObject o = new ByteObject();
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 22:
                {
                EverythingObject o = new EverythingObject();
                // PRIMITIVE: ShortValue
                o.ShortValue =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                // PRIMITIVE: UshortValue
                o.UshortValue =
                    (ushort)(
                        ((ushort)bytes[index++] << 8) |
                        (ushort)bytes[index++]
                    );
                // PRIMITIVE: UintValue
                o.UintValue =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                // PRIMITIVE: UlongValue
                o.UlongValue =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                // PRIMITIVE: StringValue
                    ulong vuread_thykOVkI99lj = 0;
                    for (int i_wPicPrd02bbk = 0; i_wPicPrd02bbk < 9; i_wPicPrd02bbk++) {
                        byte b = bytes[index++];
                        if (i_wPicPrd02bbk < 8) {
                            vuread_thykOVkI99lj += (((ulong)b & (ulong)127) << (7 * i_wPicPrd02bbk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_thykOVkI99lj += (ulong)b << (7 * i_wPicPrd02bbk);
                            break;
                        }
                    }
                    ushort stringLength_uajemvEIHz55 = (ushort)vuread_thykOVkI99lj;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_uajemvEIHz55);
                index += stringLength_uajemvEIHz55;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_mgVhbZXYY9mG =
                    (ulong)(
                        ((ulong)bytes[index++] << 56) |
                        ((ulong)bytes[index++] << 48) |
                        ((ulong)bytes[index++] << 40) |
                        ((ulong)bytes[index++] << 32) |
                        ((ulong)bytes[index++] << 24) |
                        ((ulong)bytes[index++] << 16) |
                        ((ulong)bytes[index++] << 8) |
                        (ulong)bytes[index++]
                    );
                double double_dvVwH3vJ6v32;
                unsafe {
                    double_dvVwH3vJ6v32 = *((double*)&(doubleAsUInt_mgVhbZXYY9mG));
                }
                o.DoubleValue = double_dvVwH3vJ6v32;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_zXagNMmHWpHI =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_fB3pvecTfnbs;
                unsafe {
                    float_fB3pvecTfnbs = *((float*)&(floatAsUInt_zXagNMmHWpHI));
                }
                o.FloatValue = float_fB3pvecTfnbs;
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 112:
                {
                VIntObject o = new VIntObject();
                // PRIMITIVE: VintValue
    byte rvint_b_n6Zdnnvjipjf = bytes[index++];
    byte rvint_sign_ago2sjWrfChn = (byte)(rvint_b_n6Zdnnvjipjf & 1);
    byte rvint_size_vRlmWPT73vSy = (byte)(rvint_b_n6Zdnnvjipjf >> 1);
    ulong rvint_remaining_g9G222jUN5gG = 0;
    for (int i_kuoMCqCeYMoG = 0; i_kuoMCqCeYMoG < rvint_size_vRlmWPT73vSy - 1; i_kuoMCqCeYMoG++) {
        rvint_remaining_g9G222jUN5gG = rvint_remaining_g9G222jUN5gG | (((ulong)bytes[index++] << (8 * i_kuoMCqCeYMoG)));
    }
    int rvint_result_ajwDFmmPyZNs = (int)rvint_remaining_g9G222jUN5gG;
    rvint_result_ajwDFmmPyZNs = ~rvint_result_ajwDFmmPyZNs;
    if (rvint_result_ajwDFmmPyZNs == int.MaxValue) {
        rvint_result_ajwDFmmPyZNs = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_ajwDFmmPyZNs += 1;
        if (rvint_sign_ago2sjWrfChn == 0) {
            rvint_result_ajwDFmmPyZNs = -rvint_result_ajwDFmmPyZNs;
        }
    }
    o.VintValue = rvint_result_ajwDFmmPyZNs;
                    return o;
                }
            case 113:
                {
                VLongObject o = new VLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_q4ynsxJ3LOYB = bytes[index++];
    byte rvlong_sign_lgEM2OKMVa0S = (byte)(rvlong_b_q4ynsxJ3LOYB & 1);
    byte rvlong_size_nQpBSBiIR59I = (byte)(rvlong_b_q4ynsxJ3LOYB >> 1);
    ulong rvlong_remaining_wpVBcu4xv5cy = 0;
    for (int i_sKWTpaHNeQSM = 0; i_sKWTpaHNeQSM < rvlong_size_nQpBSBiIR59I - 1; i_sKWTpaHNeQSM++) {
        rvlong_remaining_wpVBcu4xv5cy = rvlong_remaining_wpVBcu4xv5cy | (((ulong)bytes[index++] << (8 * i_sKWTpaHNeQSM)));
    }
    long rvlong_result_diljFpTFh6UM = (long)rvlong_remaining_wpVBcu4xv5cy;
    rvlong_result_diljFpTFh6UM = ~rvlong_result_diljFpTFh6UM;
    if (rvlong_result_diljFpTFh6UM == long.MaxValue) {
        rvlong_result_diljFpTFh6UM = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_diljFpTFh6UM += 1;
        if (rvlong_sign_lgEM2OKMVa0S == 0) {
            rvlong_result_diljFpTFh6UM = -rvlong_result_diljFpTFh6UM;
        }
    }
    o.VlongValue = rvlong_result_diljFpTFh6UM;
                    return o;
                }
            case 114:
                {
                VUShortObject o = new VUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_wiJAfCxKO0Ti = 0;
                    for (int i_qytRywDlHjt4 = 0; i_qytRywDlHjt4 < 9; i_qytRywDlHjt4++) {
                        byte b = bytes[index++];
                        if (i_qytRywDlHjt4 < 8) {
                            vuread_wiJAfCxKO0Ti += (((ulong)b & (ulong)127) << (7 * i_qytRywDlHjt4));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wiJAfCxKO0Ti += (ulong)b << (7 * i_qytRywDlHjt4);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_wiJAfCxKO0Ti;
                    return o;
                }
            case 115:
                {
                VUIntObject o = new VUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_dV2flHrV0k1g = 0;
                    for (int i_lgHLsi8rzdFg = 0; i_lgHLsi8rzdFg < 9; i_lgHLsi8rzdFg++) {
                        byte b = bytes[index++];
                        if (i_lgHLsi8rzdFg < 8) {
                            vuread_dV2flHrV0k1g += (((ulong)b & (ulong)127) << (7 * i_lgHLsi8rzdFg));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dV2flHrV0k1g += (ulong)b << (7 * i_lgHLsi8rzdFg);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_dV2flHrV0k1g;
                    return o;
                }
            case 116:
                {
                VULongObject o = new VULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_ycgUCIfSZPru = 0;
                    for (int i_psygJ7rEHmqr = 0; i_psygJ7rEHmqr < 9; i_psygJ7rEHmqr++) {
                        byte b = bytes[index++];
                        if (i_psygJ7rEHmqr < 8) {
                            vuread_ycgUCIfSZPru += (((ulong)b & (ulong)127) << (7 * i_psygJ7rEHmqr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ycgUCIfSZPru += (ulong)b << (7 * i_psygJ7rEHmqr);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_ycgUCIfSZPru;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = new HighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_lGtrejrVZnba = 0;
                    for (int i_t1SBVbJTWZ6K = 0; i_t1SBVbJTWZ6K < 9; i_t1SBVbJTWZ6K++) {
                        byte b = bytes[index++];
                        if (i_t1SBVbJTWZ6K < 8) {
                            vuread_lGtrejrVZnba += (((ulong)b & (ulong)127) << (7 * i_t1SBVbJTWZ6K));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lGtrejrVZnba += (ulong)b << (7 * i_t1SBVbJTWZ6K);
                            break;
                        }
                    }
                    ushort stringLength_v12ylbFgpVji = (ushort)vuread_lGtrejrVZnba;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_v12ylbFgpVji);
                index += stringLength_v12ylbFgpVji;
                // PRIMITIVE: HighScore
                    ulong vuread_rQGXjkeYjqQc = 0;
                    for (int i_qazx5FBK02Pu = 0; i_qazx5FBK02Pu < 9; i_qazx5FBK02Pu++) {
                        byte b = bytes[index++];
                        if (i_qazx5FBK02Pu < 8) {
                            vuread_rQGXjkeYjqQc += (((ulong)b & (ulong)127) << (7 * i_qazx5FBK02Pu));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rQGXjkeYjqQc += (ulong)b << (7 * i_qazx5FBK02Pu);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_rQGXjkeYjqQc;
                    return o;
                }
                default:
                    throw new PrimitiveTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new PrimitiveTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
