
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
                uint stringLength_v5Bg12A1jbL2;
                int i_u5WkdGLOUnzB;
                for (i_u5WkdGLOUnzB = 0; i_u5WkdGLOUnzB < 2; i_u5WkdGLOUnzB++) {
                    if ((ulong)o.StringValue.Length < vuBoundaries[i_u5WkdGLOUnzB]) {
                       stringLength_v5Bg12A1jbL2 = (uint)(i_u5WkdGLOUnzB + 1);
                       goto guvsgoto_eJdxGw3XPBlH;
                    }
                }
                stringLength_v5Bg12A1jbL2 = (uint)i_u5WkdGLOUnzB + 1;
                guvsgoto_eJdxGw3XPBlH:
                if (o.StringValue.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.StringValue.Length;
                    for (int i_dzGbwWFsjsBO = 0; i_dzGbwWFsjsBO < stringLength_v5Bg12A1jbL2; i_dzGbwWFsjsBO++) {
                        if (i_dzGbwWFsjsBO < stringLength_v5Bg12A1jbL2 - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dzGbwWFsjsBO < stringLength_v5Bg12A1jbL2 - 1) {
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
                double double_zQ9Ua6wyU3t6 = o.DoubleValue;
                ulong doubleAsULong_cpYNA7h7kLoh;
                unsafe {
                    doubleAsULong_cpYNA7h7kLoh = *((ulong*)&(double_zQ9Ua6wyU3t6));
                }
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 56) & 255);
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 48) & 255);
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 40) & 255);
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 32) & 255);
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 24) & 255);
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 16) & 255);
                bytes[index++] = (byte)((doubleAsULong_cpYNA7h7kLoh >> 8) & 255);
                bytes[index++] = (byte)(doubleAsULong_cpYNA7h7kLoh & 255);
        }
        public void Energize(FloatObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 19;
            }
                // PRIMITIVE: FloatValue
                float float_v2A252xEEilw = o.FloatValue;
                uint floatAsUInt_n1OX1aRpfJ5h;
                unsafe {
                    floatAsUInt_n1OX1aRpfJ5h = *((uint*)&(float_v2A252xEEilw));
                }
                bytes[index++] = (byte)((floatAsUInt_n1OX1aRpfJ5h >> 24) & 255);
                bytes[index++] = (byte)((floatAsUInt_n1OX1aRpfJ5h >> 16) & 255);
                bytes[index++] = (byte)((floatAsUInt_n1OX1aRpfJ5h >> 8) & 255);
                bytes[index++] = (byte)(floatAsUInt_n1OX1aRpfJ5h & 255);
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
                uint stringLength_z22mkDDxC24h;
                int i_htfj38bq7s4d;
                for (i_htfj38bq7s4d = 0; i_htfj38bq7s4d < 2; i_htfj38bq7s4d++) {
                    if ((ulong)o.StringValue.Length < vuBoundaries[i_htfj38bq7s4d]) {
                       stringLength_z22mkDDxC24h = (uint)(i_htfj38bq7s4d + 1);
                       goto guvsgoto_nDC1FZC6dBhJ;
                    }
                }
                stringLength_z22mkDDxC24h = (uint)i_htfj38bq7s4d + 1;
                guvsgoto_nDC1FZC6dBhJ:
                if (o.StringValue.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.StringValue.Length;
                    for (int i_altaPY4O6Grx = 0; i_altaPY4O6Grx < stringLength_z22mkDDxC24h; i_altaPY4O6Grx++) {
                        if (i_altaPY4O6Grx < stringLength_z22mkDDxC24h - 1) {
                            byte b = (byte)(value & 127);
                            if (i_altaPY4O6Grx < stringLength_z22mkDDxC24h - 1) {
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
                double double_o0Tqg8dGVt40 = o.DoubleValue;
                ulong doubleAsULong_ktDD1NknIz1u;
                unsafe {
                    doubleAsULong_ktDD1NknIz1u = *((ulong*)&(double_o0Tqg8dGVt40));
                }
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 56) & 255);
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 48) & 255);
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 40) & 255);
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 32) & 255);
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 24) & 255);
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 16) & 255);
                bytes[index++] = (byte)((doubleAsULong_ktDD1NknIz1u >> 8) & 255);
                bytes[index++] = (byte)(doubleAsULong_ktDD1NknIz1u & 255);
                // PRIMITIVE: FloatValue
                float float_nCroHDMWcSMd = o.FloatValue;
                uint floatAsUInt_gUk8oxsRrCLv;
                unsafe {
                    floatAsUInt_gUk8oxsRrCLv = *((uint*)&(float_nCroHDMWcSMd));
                }
                bytes[index++] = (byte)((floatAsUInt_gUk8oxsRrCLv >> 24) & 255);
                bytes[index++] = (byte)((floatAsUInt_gUk8oxsRrCLv >> 16) & 255);
                bytes[index++] = (byte)((floatAsUInt_gUk8oxsRrCLv >> 8) & 255);
                bytes[index++] = (byte)(floatAsUInt_gUk8oxsRrCLv & 255);
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
    long s2ultemp_iBWtwdZi8zUN = o.VintValue;
    if (s2ultemp_iBWtwdZi8zUN == long.MinValue) {
        s2ultemp_iBWtwdZi8zUN = long.MaxValue;
    }
    else {
        if (s2ultemp_iBWtwdZi8zUN > 0) {
            s2ultemp_iBWtwdZi8zUN = -s2ultemp_iBWtwdZi8zUN;
        }
        s2ultemp_iBWtwdZi8zUN -= 1;
    }
    s2ultemp_iBWtwdZi8zUN = ~s2ultemp_iBWtwdZi8zUN;
    ulong s2ulresult_sY9sQhYQRzog = (ulong)s2ultemp_iBWtwdZi8zUN;
    //// AppendGetSignVariantSize(s2ulresult_sY9sQhYQRzog)
    byte vr_mm8lhjdd063f = 1;
    for (int v_rtA82DeZaHrz = 56; v_rtA82DeZaHrz >= 0; v_rtA82DeZaHrz -= 8) {
        if (((255UL << v_rtA82DeZaHrz) & s2ulresult_sY9sQhYQRzog) > 0) {
            vr_mm8lhjdd063f = (byte)(v_rtA82DeZaHrz / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_mm8lhjdd063f << 1) | (byte)(o.VintValue > 0 ? 0 : 1));
    for (int vi_kaajO5N5nQ0k = 0; vi_kaajO5N5nQ0k < vr_mm8lhjdd063f - 1; vi_kaajO5N5nQ0k++) {
        bytes[index++] = (byte)(s2ulresult_sY9sQhYQRzog & 255);
        s2ulresult_sY9sQhYQRzog = s2ulresult_sY9sQhYQRzog >> 8;
    }
        }
        public void Energize(VLongObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 113;
            }
                // PRIMITIVE: VlongValue
    //// AppendSignedToULong(o.VlongValue)
    long s2ultemp_cNbZvRWU53Lx = o.VlongValue;
    if (s2ultemp_cNbZvRWU53Lx == long.MinValue) {
        s2ultemp_cNbZvRWU53Lx = long.MaxValue;
    }
    else {
        if (s2ultemp_cNbZvRWU53Lx > 0) {
            s2ultemp_cNbZvRWU53Lx = -s2ultemp_cNbZvRWU53Lx;
        }
        s2ultemp_cNbZvRWU53Lx -= 1;
    }
    s2ultemp_cNbZvRWU53Lx = ~s2ultemp_cNbZvRWU53Lx;
    ulong s2ulresult_sZXnuyf54JXg = (ulong)s2ultemp_cNbZvRWU53Lx;
    //// AppendGetSignVariantSize(s2ulresult_sZXnuyf54JXg)
    byte vr_d4y4s829Dp3o = 1;
    for (int v_mpEtUGEEyNBY = 56; v_mpEtUGEEyNBY >= 0; v_mpEtUGEEyNBY -= 8) {
        if (((255UL << v_mpEtUGEEyNBY) & s2ulresult_sZXnuyf54JXg) > 0) {
            vr_d4y4s829Dp3o = (byte)(v_mpEtUGEEyNBY / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_d4y4s829Dp3o << 1) | (byte)(o.VlongValue > 0 ? 0 : 1));
    for (int vi_dAKYK4pF04QB = 0; vi_dAKYK4pF04QB < vr_d4y4s829Dp3o - 1; vi_dAKYK4pF04QB++) {
        bytes[index++] = (byte)(s2ulresult_sZXnuyf54JXg & 255);
        s2ulresult_sZXnuyf54JXg = s2ulresult_sZXnuyf54JXg >> 8;
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
                int i_xWlxetSFCJW2;
                for (i_xWlxetSFCJW2 = 0; i_xWlxetSFCJW2 < 2; i_xWlxetSFCJW2++) {
                    if ((ulong)o.VushortValue < vuBoundaries[i_xWlxetSFCJW2]) {
                       byteCount = (int)(i_xWlxetSFCJW2 + 1);
                       goto guvsgoto_h1C6bL3B6IUf;
                    }
                }
                byteCount = (int)i_xWlxetSFCJW2 + 1;
                guvsgoto_h1C6bL3B6IUf:
                    for (int i_kdzJaxyIJcb3 = 0; i_kdzJaxyIJcb3 < byteCount; i_kdzJaxyIJcb3++) {
                        if (i_kdzJaxyIJcb3 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_kdzJaxyIJcb3 < byteCount - 1) {
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
                int i_s1BHlk8SfKI7;
                for (i_s1BHlk8SfKI7 = 0; i_s1BHlk8SfKI7 < 4; i_s1BHlk8SfKI7++) {
                    if ((ulong)o.VuintValue < vuBoundaries[i_s1BHlk8SfKI7]) {
                       byteCount = (int)(i_s1BHlk8SfKI7 + 1);
                       goto guvsgoto_bICWT92KPF5Y;
                    }
                }
                byteCount = (int)i_s1BHlk8SfKI7 + 1;
                guvsgoto_bICWT92KPF5Y:
                    for (int i_fuBIkmF0VrtG = 0; i_fuBIkmF0VrtG < byteCount; i_fuBIkmF0VrtG++) {
                        if (i_fuBIkmF0VrtG < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_fuBIkmF0VrtG < byteCount - 1) {
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
                int i_y0wzesXDaFKy;
                for (i_y0wzesXDaFKy = 0; i_y0wzesXDaFKy < 8; i_y0wzesXDaFKy++) {
                    if ((ulong)o.VulongValue < vuBoundaries[i_y0wzesXDaFKy]) {
                       byteCount = (int)(i_y0wzesXDaFKy + 1);
                       goto guvsgoto_v5WDRlm3iL0i;
                    }
                }
                byteCount = (int)i_y0wzesXDaFKy + 1;
                guvsgoto_v5WDRlm3iL0i:
                    for (int i_ouAD9ecBI5Rq = 0; i_ouAD9ecBI5Rq < byteCount; i_ouAD9ecBI5Rq++) {
                        if (i_ouAD9ecBI5Rq < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ouAD9ecBI5Rq < byteCount - 1) {
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
                uint stringLength_kEb3xPYKEtLt;
                int i_tT3eIzKbjgbJ;
                for (i_tT3eIzKbjgbJ = 0; i_tT3eIzKbjgbJ < 2; i_tT3eIzKbjgbJ++) {
                    if ((ulong)o.Name.Length < vuBoundaries[i_tT3eIzKbjgbJ]) {
                       stringLength_kEb3xPYKEtLt = (uint)(i_tT3eIzKbjgbJ + 1);
                       goto guvsgoto_vgWCEZFuvx5w;
                    }
                }
                stringLength_kEb3xPYKEtLt = (uint)i_tT3eIzKbjgbJ + 1;
                guvsgoto_vgWCEZFuvx5w:
                if (o.Name.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.Name.Length;
                    for (int i_h4fuR93oSgN2 = 0; i_h4fuR93oSgN2 < stringLength_kEb3xPYKEtLt; i_h4fuR93oSgN2++) {
                        if (i_h4fuR93oSgN2 < stringLength_kEb3xPYKEtLt - 1) {
                            byte b = (byte)(value & 127);
                            if (i_h4fuR93oSgN2 < stringLength_kEb3xPYKEtLt - 1) {
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
                int i_tUcfTKkSfmlJ;
                for (i_tUcfTKkSfmlJ = 0; i_tUcfTKkSfmlJ < 4; i_tUcfTKkSfmlJ++) {
                    if ((ulong)o.HighScore < vuBoundaries[i_tUcfTKkSfmlJ]) {
                       byteCount = (int)(i_tUcfTKkSfmlJ + 1);
                       goto guvsgoto_hK7Szw59JOiO;
                    }
                }
                byteCount = (int)i_tUcfTKkSfmlJ + 1;
                guvsgoto_hK7Szw59JOiO:
                    for (int i_tlNvDROOfbW7 = 0; i_tlNvDROOfbW7 < byteCount; i_tlNvDROOfbW7++) {
                        if (i_tlNvDROOfbW7 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_tlNvDROOfbW7 < byteCount - 1) {
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
                    ulong vuread_l1LWlbaMVBJ7 = 0;
                    for (int i_yYFh64Xfzx8o = 0; i_yYFh64Xfzx8o < 9; i_yYFh64Xfzx8o++) {
                        byte b = bytes[index++];
                        if (i_yYFh64Xfzx8o < 8) {
                            vuread_l1LWlbaMVBJ7 += (((ulong)b & (ulong)127) << (7 * i_yYFh64Xfzx8o));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_l1LWlbaMVBJ7 += (ulong)b << (7 * i_yYFh64Xfzx8o);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_l1LWlbaMVBJ7;
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
                    ulong vuread_zxHelIYsLQxP = 0;
                    for (int i_fGRkoRIf2xcL = 0; i_fGRkoRIf2xcL < 9; i_fGRkoRIf2xcL++) {
                        byte b = bytes[index++];
                        if (i_fGRkoRIf2xcL < 8) {
                            vuread_zxHelIYsLQxP += (((ulong)b & (ulong)127) << (7 * i_fGRkoRIf2xcL));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zxHelIYsLQxP += (ulong)b << (7 * i_fGRkoRIf2xcL);
                            break;
                        }
                    }
                    ushort stringLength_tKF1aEIU7eN1 = (ushort)vuread_zxHelIYsLQxP;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_tKF1aEIU7eN1);
                index += stringLength_tKF1aEIU7eN1;
                    return o;
                }
            case 18:
                {
                DoubleObject o = new DoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_jT30IQMdm0PE =
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
                double double_njLr3Z93kNiI;
                unsafe {
                    double_njLr3Z93kNiI = *((double*)&(doubleAsUInt_jT30IQMdm0PE));
                }
                o.DoubleValue = double_njLr3Z93kNiI;
                    return o;
                }
            case 19:
                {
                FloatObject o = new FloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_yGyWQEEIxjXE =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_uxGqFI9Lv6Ic;
                unsafe {
                    float_uxGqFI9Lv6Ic = *((float*)&(floatAsUInt_yGyWQEEIxjXE));
                }
                o.FloatValue = float_uxGqFI9Lv6Ic;
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
                    ulong vuread_iTxMOHnBk03b = 0;
                    for (int i_h0xSvggMKbCX = 0; i_h0xSvggMKbCX < 9; i_h0xSvggMKbCX++) {
                        byte b = bytes[index++];
                        if (i_h0xSvggMKbCX < 8) {
                            vuread_iTxMOHnBk03b += (((ulong)b & (ulong)127) << (7 * i_h0xSvggMKbCX));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iTxMOHnBk03b += (ulong)b << (7 * i_h0xSvggMKbCX);
                            break;
                        }
                    }
                    ushort stringLength_uRGmV9yPDhFG = (ushort)vuread_iTxMOHnBk03b;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_uRGmV9yPDhFG);
                index += stringLength_uRGmV9yPDhFG;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_c2405vu7XE44 =
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
                double double_aW0wH3JYb2D6;
                unsafe {
                    double_aW0wH3JYb2D6 = *((double*)&(doubleAsUInt_c2405vu7XE44));
                }
                o.DoubleValue = double_aW0wH3JYb2D6;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_r14qrfazxALD =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_pQtwb25rrJK1;
                unsafe {
                    float_pQtwb25rrJK1 = *((float*)&(floatAsUInt_r14qrfazxALD));
                }
                o.FloatValue = float_pQtwb25rrJK1;
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
    byte rvint_b_fqQoRFaH25U0 = bytes[index++];
    byte rvint_sign_pmXi6lPHrcje = (byte)(rvint_b_fqQoRFaH25U0 & 1);
    byte rvint_size_ldPSDEHkfZkV = (byte)(rvint_b_fqQoRFaH25U0 >> 1);
    ulong rvint_remaining_eRKVJc8VgdQe = 0;
    for (int i_h1ClVdljgMWN = 0; i_h1ClVdljgMWN < rvint_size_ldPSDEHkfZkV - 1; i_h1ClVdljgMWN++) {
        rvint_remaining_eRKVJc8VgdQe = rvint_remaining_eRKVJc8VgdQe | (((ulong)bytes[index++] << (8 * i_h1ClVdljgMWN)));
    }
    int rvint_result_vreyxJUUcc7o = (int)rvint_remaining_eRKVJc8VgdQe;
    rvint_result_vreyxJUUcc7o = ~rvint_result_vreyxJUUcc7o;
    if (rvint_result_vreyxJUUcc7o == int.MaxValue) {
        rvint_result_vreyxJUUcc7o = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_vreyxJUUcc7o += 1;
        if (rvint_sign_pmXi6lPHrcje == 0) {
            rvint_result_vreyxJUUcc7o = -rvint_result_vreyxJUUcc7o;
        }
    }
    o.VintValue = rvint_result_vreyxJUUcc7o;
                    return o;
                }
            case 113:
                {
                VLongObject o = new VLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_p38pey8xwKBM = bytes[index++];
    byte rvlong_sign_awzcOaOJ576r = (byte)(rvlong_b_p38pey8xwKBM & 1);
    byte rvlong_size_zKxGs6co4oL1 = (byte)(rvlong_b_p38pey8xwKBM >> 1);
    ulong rvlong_remaining_c5fSOyro0Cwb = 0;
    for (int i_eSgbxytN7QrD = 0; i_eSgbxytN7QrD < rvlong_size_zKxGs6co4oL1 - 1; i_eSgbxytN7QrD++) {
        rvlong_remaining_c5fSOyro0Cwb = rvlong_remaining_c5fSOyro0Cwb | (((ulong)bytes[index++] << (8 * i_eSgbxytN7QrD)));
    }
    long rvlong_result_aBeAImRXUH7S = (long)rvlong_remaining_c5fSOyro0Cwb;
    rvlong_result_aBeAImRXUH7S = ~rvlong_result_aBeAImRXUH7S;
    if (rvlong_result_aBeAImRXUH7S == long.MaxValue) {
        rvlong_result_aBeAImRXUH7S = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_aBeAImRXUH7S += 1;
        if (rvlong_sign_awzcOaOJ576r == 0) {
            rvlong_result_aBeAImRXUH7S = -rvlong_result_aBeAImRXUH7S;
        }
    }
    o.VlongValue = rvlong_result_aBeAImRXUH7S;
                    return o;
                }
            case 114:
                {
                VUShortObject o = new VUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_x65GPRBFovwK = 0;
                    for (int i_va1F474yOMRm = 0; i_va1F474yOMRm < 9; i_va1F474yOMRm++) {
                        byte b = bytes[index++];
                        if (i_va1F474yOMRm < 8) {
                            vuread_x65GPRBFovwK += (((ulong)b & (ulong)127) << (7 * i_va1F474yOMRm));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_x65GPRBFovwK += (ulong)b << (7 * i_va1F474yOMRm);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_x65GPRBFovwK;
                    return o;
                }
            case 115:
                {
                VUIntObject o = new VUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_i1PNUIrMVxgB = 0;
                    for (int i_mX7poVpPeEJI = 0; i_mX7poVpPeEJI < 9; i_mX7poVpPeEJI++) {
                        byte b = bytes[index++];
                        if (i_mX7poVpPeEJI < 8) {
                            vuread_i1PNUIrMVxgB += (((ulong)b & (ulong)127) << (7 * i_mX7poVpPeEJI));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_i1PNUIrMVxgB += (ulong)b << (7 * i_mX7poVpPeEJI);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_i1PNUIrMVxgB;
                    return o;
                }
            case 116:
                {
                VULongObject o = new VULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_im3WMIdtpSmY = 0;
                    for (int i_aYVPeUZC3zch = 0; i_aYVPeUZC3zch < 9; i_aYVPeUZC3zch++) {
                        byte b = bytes[index++];
                        if (i_aYVPeUZC3zch < 8) {
                            vuread_im3WMIdtpSmY += (((ulong)b & (ulong)127) << (7 * i_aYVPeUZC3zch));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_im3WMIdtpSmY += (ulong)b << (7 * i_aYVPeUZC3zch);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_im3WMIdtpSmY;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = new HighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_rE9nuXmUKioA = 0;
                    for (int i_zJLuPhO5jWW8 = 0; i_zJLuPhO5jWW8 < 9; i_zJLuPhO5jWW8++) {
                        byte b = bytes[index++];
                        if (i_zJLuPhO5jWW8 < 8) {
                            vuread_rE9nuXmUKioA += (((ulong)b & (ulong)127) << (7 * i_zJLuPhO5jWW8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rE9nuXmUKioA += (ulong)b << (7 * i_zJLuPhO5jWW8);
                            break;
                        }
                    }
                    ushort stringLength_aOk3wbiZrhsI = (ushort)vuread_rE9nuXmUKioA;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_aOk3wbiZrhsI);
                index += stringLength_aOk3wbiZrhsI;
                // PRIMITIVE: HighScore
                    ulong vuread_jk6nJxH3FnaK = 0;
                    for (int i_tLignrG1AU3W = 0; i_tLignrG1AU3W < 9; i_tLignrG1AU3W++) {
                        byte b = bytes[index++];
                        if (i_tLignrG1AU3W < 8) {
                            vuread_jk6nJxH3FnaK += (((ulong)b & (ulong)127) << (7 * i_tLignrG1AU3W));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jk6nJxH3FnaK += (ulong)b << (7 * i_tLignrG1AU3W);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_jk6nJxH3FnaK;
                    return o;
                }
                default:
                    throw new PrimitiveTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_lYjjDwy3SbZj = 0;
                    for (int i_w9kmLu4WJaJd = 0; i_w9kmLu4WJaJd < 9; i_w9kmLu4WJaJd++) {
                        byte b = bytes[index++];
                        if (i_w9kmLu4WJaJd < 8) {
                            vuread_lYjjDwy3SbZj += (((ulong)b & (ulong)127) << (7 * i_w9kmLu4WJaJd));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lYjjDwy3SbZj += (ulong)b << (7 * i_w9kmLu4WJaJd);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_lYjjDwy3SbZj;
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
                    ulong vuread_fxAjZg2TW8pn = 0;
                    for (int i_cuqg0hnzpgk5 = 0; i_cuqg0hnzpgk5 < 9; i_cuqg0hnzpgk5++) {
                        byte b = bytes[index++];
                        if (i_cuqg0hnzpgk5 < 8) {
                            vuread_fxAjZg2TW8pn += (((ulong)b & (ulong)127) << (7 * i_cuqg0hnzpgk5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fxAjZg2TW8pn += (ulong)b << (7 * i_cuqg0hnzpgk5);
                            break;
                        }
                    }
                    ushort stringLength_zHS1p4HNrjWV = (ushort)vuread_fxAjZg2TW8pn;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_zHS1p4HNrjWV);
                index += stringLength_zHS1p4HNrjWV;
                    return o;
                }
            case 18:
                {
                DoubleObject o = new DoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_xU7Ci0rasEU5 =
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
                double double_qHNXEm2Rmz8n;
                unsafe {
                    double_qHNXEm2Rmz8n = *((double*)&(doubleAsUInt_xU7Ci0rasEU5));
                }
                o.DoubleValue = double_qHNXEm2Rmz8n;
                    return o;
                }
            case 19:
                {
                FloatObject o = new FloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_meoJgHaRvdlf =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_qBWj6wGhmEFr;
                unsafe {
                    float_qBWj6wGhmEFr = *((float*)&(floatAsUInt_meoJgHaRvdlf));
                }
                o.FloatValue = float_qBWj6wGhmEFr;
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
                    ulong vuread_kSV031aApP9e = 0;
                    for (int i_pR3UDdJKpR9l = 0; i_pR3UDdJKpR9l < 9; i_pR3UDdJKpR9l++) {
                        byte b = bytes[index++];
                        if (i_pR3UDdJKpR9l < 8) {
                            vuread_kSV031aApP9e += (((ulong)b & (ulong)127) << (7 * i_pR3UDdJKpR9l));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kSV031aApP9e += (ulong)b << (7 * i_pR3UDdJKpR9l);
                            break;
                        }
                    }
                    ushort stringLength_eUqyZkNiWSjc = (ushort)vuread_kSV031aApP9e;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_eUqyZkNiWSjc);
                index += stringLength_eUqyZkNiWSjc;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_ukXEcV0FUmXh =
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
                double double_chsc0wFU4ljx;
                unsafe {
                    double_chsc0wFU4ljx = *((double*)&(doubleAsUInt_ukXEcV0FUmXh));
                }
                o.DoubleValue = double_chsc0wFU4ljx;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_o8J2jojzHF8t =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_h3OTjIXSSJUW;
                unsafe {
                    float_h3OTjIXSSJUW = *((float*)&(floatAsUInt_o8J2jojzHF8t));
                }
                o.FloatValue = float_h3OTjIXSSJUW;
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
    byte rvint_b_geID0EA3tkV7 = bytes[index++];
    byte rvint_sign_sWLvyBPmAb6e = (byte)(rvint_b_geID0EA3tkV7 & 1);
    byte rvint_size_f8vGcyJV5vDe = (byte)(rvint_b_geID0EA3tkV7 >> 1);
    ulong rvint_remaining_au2oi1CxnMkx = 0;
    for (int i_qXag0V2niDr1 = 0; i_qXag0V2niDr1 < rvint_size_f8vGcyJV5vDe - 1; i_qXag0V2niDr1++) {
        rvint_remaining_au2oi1CxnMkx = rvint_remaining_au2oi1CxnMkx | (((ulong)bytes[index++] << (8 * i_qXag0V2niDr1)));
    }
    int rvint_result_d405L9cwsHve = (int)rvint_remaining_au2oi1CxnMkx;
    rvint_result_d405L9cwsHve = ~rvint_result_d405L9cwsHve;
    if (rvint_result_d405L9cwsHve == int.MaxValue) {
        rvint_result_d405L9cwsHve = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_d405L9cwsHve += 1;
        if (rvint_sign_sWLvyBPmAb6e == 0) {
            rvint_result_d405L9cwsHve = -rvint_result_d405L9cwsHve;
        }
    }
    o.VintValue = rvint_result_d405L9cwsHve;
                    return o;
                }
            case 113:
                {
                VLongObject o = new VLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_oBeJII1KY83o = bytes[index++];
    byte rvlong_sign_jD4jCq6Hcaen = (byte)(rvlong_b_oBeJII1KY83o & 1);
    byte rvlong_size_aHWnKXefC6Hz = (byte)(rvlong_b_oBeJII1KY83o >> 1);
    ulong rvlong_remaining_stPKMRdkbLHh = 0;
    for (int i_c23cLXbJw0Ia = 0; i_c23cLXbJw0Ia < rvlong_size_aHWnKXefC6Hz - 1; i_c23cLXbJw0Ia++) {
        rvlong_remaining_stPKMRdkbLHh = rvlong_remaining_stPKMRdkbLHh | (((ulong)bytes[index++] << (8 * i_c23cLXbJw0Ia)));
    }
    long rvlong_result_tO9a3YWA6FCj = (long)rvlong_remaining_stPKMRdkbLHh;
    rvlong_result_tO9a3YWA6FCj = ~rvlong_result_tO9a3YWA6FCj;
    if (rvlong_result_tO9a3YWA6FCj == long.MaxValue) {
        rvlong_result_tO9a3YWA6FCj = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_tO9a3YWA6FCj += 1;
        if (rvlong_sign_jD4jCq6Hcaen == 0) {
            rvlong_result_tO9a3YWA6FCj = -rvlong_result_tO9a3YWA6FCj;
        }
    }
    o.VlongValue = rvlong_result_tO9a3YWA6FCj;
                    return o;
                }
            case 114:
                {
                VUShortObject o = new VUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_pv4v63myaPiS = 0;
                    for (int i_xcEO48c1UOZ7 = 0; i_xcEO48c1UOZ7 < 9; i_xcEO48c1UOZ7++) {
                        byte b = bytes[index++];
                        if (i_xcEO48c1UOZ7 < 8) {
                            vuread_pv4v63myaPiS += (((ulong)b & (ulong)127) << (7 * i_xcEO48c1UOZ7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pv4v63myaPiS += (ulong)b << (7 * i_xcEO48c1UOZ7);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_pv4v63myaPiS;
                    return o;
                }
            case 115:
                {
                VUIntObject o = new VUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_sdrmZglJzUBp = 0;
                    for (int i_xQMCNkagGrf1 = 0; i_xQMCNkagGrf1 < 9; i_xQMCNkagGrf1++) {
                        byte b = bytes[index++];
                        if (i_xQMCNkagGrf1 < 8) {
                            vuread_sdrmZglJzUBp += (((ulong)b & (ulong)127) << (7 * i_xQMCNkagGrf1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sdrmZglJzUBp += (ulong)b << (7 * i_xQMCNkagGrf1);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_sdrmZglJzUBp;
                    return o;
                }
            case 116:
                {
                VULongObject o = new VULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_ihF8CLy6G7O2 = 0;
                    for (int i_qaJ3DIskKoVo = 0; i_qaJ3DIskKoVo < 9; i_qaJ3DIskKoVo++) {
                        byte b = bytes[index++];
                        if (i_qaJ3DIskKoVo < 8) {
                            vuread_ihF8CLy6G7O2 += (((ulong)b & (ulong)127) << (7 * i_qaJ3DIskKoVo));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ihF8CLy6G7O2 += (ulong)b << (7 * i_qaJ3DIskKoVo);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_ihF8CLy6G7O2;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = new HighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_pmgXvES5bT0N = 0;
                    for (int i_pgM785qewrM2 = 0; i_pgM785qewrM2 < 9; i_pgM785qewrM2++) {
                        byte b = bytes[index++];
                        if (i_pgM785qewrM2 < 8) {
                            vuread_pmgXvES5bT0N += (((ulong)b & (ulong)127) << (7 * i_pgM785qewrM2));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pmgXvES5bT0N += (ulong)b << (7 * i_pgM785qewrM2);
                            break;
                        }
                    }
                    ushort stringLength_iKnKNSBz7z3R = (ushort)vuread_pmgXvES5bT0N;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_iKnKNSBz7z3R);
                index += stringLength_iKnKNSBz7z3R;
                // PRIMITIVE: HighScore
                    ulong vuread_kYsXFo5mg1tr = 0;
                    for (int i_lFZgFZnLTK9H = 0; i_lFZgFZnLTK9H < 9; i_lFZgFZnLTK9H++) {
                        byte b = bytes[index++];
                        if (i_lFZgFZnLTK9H < 8) {
                            vuread_kYsXFo5mg1tr += (((ulong)b & (ulong)127) << (7 * i_lFZgFZnLTK9H));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kYsXFo5mg1tr += (ulong)b << (7 * i_lFZgFZnLTK9H);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_kYsXFo5mg1tr;
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
                    ulong vuread_e5AXYNGTXvFD = 0;
                    for (int i_ckJGebiXYVRb = 0; i_ckJGebiXYVRb < 9; i_ckJGebiXYVRb++) {
                        byte b = bytes[index++];
                        if (i_ckJGebiXYVRb < 8) {
                            vuread_e5AXYNGTXvFD += (((ulong)b & (ulong)127) << (7 * i_ckJGebiXYVRb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_e5AXYNGTXvFD += (ulong)b << (7 * i_ckJGebiXYVRb);
                            break;
                        }
                    }
                    ushort stringLength_cEAcjYvtKozH = (ushort)vuread_e5AXYNGTXvFD;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_cEAcjYvtKozH);
                index += stringLength_cEAcjYvtKozH;
                    return o;
                }
            case 18:
                {
                DoubleObject o = new DoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_kzXfeqUV8769 =
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
                double double_u2dsGaRnfr4K;
                unsafe {
                    double_u2dsGaRnfr4K = *((double*)&(doubleAsUInt_kzXfeqUV8769));
                }
                o.DoubleValue = double_u2dsGaRnfr4K;
                    return o;
                }
            case 19:
                {
                FloatObject o = new FloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_pnmWOrxYp8hO =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_gYpIfMSAoz96;
                unsafe {
                    float_gYpIfMSAoz96 = *((float*)&(floatAsUInt_pnmWOrxYp8hO));
                }
                o.FloatValue = float_gYpIfMSAoz96;
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
                    ulong vuread_tiiDJEwaA0E0 = 0;
                    for (int i_b7hRJiTqRLuc = 0; i_b7hRJiTqRLuc < 9; i_b7hRJiTqRLuc++) {
                        byte b = bytes[index++];
                        if (i_b7hRJiTqRLuc < 8) {
                            vuread_tiiDJEwaA0E0 += (((ulong)b & (ulong)127) << (7 * i_b7hRJiTqRLuc));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tiiDJEwaA0E0 += (ulong)b << (7 * i_b7hRJiTqRLuc);
                            break;
                        }
                    }
                    ushort stringLength_fdSHb5c05ddR = (ushort)vuread_tiiDJEwaA0E0;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_fdSHb5c05ddR);
                index += stringLength_fdSHb5c05ddR;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_d3oVLhnxI2Dd =
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
                double double_xkzswiaGkEcF;
                unsafe {
                    double_xkzswiaGkEcF = *((double*)&(doubleAsUInt_d3oVLhnxI2Dd));
                }
                o.DoubleValue = double_xkzswiaGkEcF;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_ceNs08QJ5LIP =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_vvrWuWajXgKy;
                unsafe {
                    float_vvrWuWajXgKy = *((float*)&(floatAsUInt_ceNs08QJ5LIP));
                }
                o.FloatValue = float_vvrWuWajXgKy;
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
    byte rvint_b_x8PKx7EbQvEa = bytes[index++];
    byte rvint_sign_wnmxE2Sct0PH = (byte)(rvint_b_x8PKx7EbQvEa & 1);
    byte rvint_size_m5HJl4imXL2w = (byte)(rvint_b_x8PKx7EbQvEa >> 1);
    ulong rvint_remaining_cAW0MIRUKMBM = 0;
    for (int i_tsec3GwdsigB = 0; i_tsec3GwdsigB < rvint_size_m5HJl4imXL2w - 1; i_tsec3GwdsigB++) {
        rvint_remaining_cAW0MIRUKMBM = rvint_remaining_cAW0MIRUKMBM | (((ulong)bytes[index++] << (8 * i_tsec3GwdsigB)));
    }
    int rvint_result_k4ZWmrnpu0qe = (int)rvint_remaining_cAW0MIRUKMBM;
    rvint_result_k4ZWmrnpu0qe = ~rvint_result_k4ZWmrnpu0qe;
    if (rvint_result_k4ZWmrnpu0qe == int.MaxValue) {
        rvint_result_k4ZWmrnpu0qe = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_k4ZWmrnpu0qe += 1;
        if (rvint_sign_wnmxE2Sct0PH == 0) {
            rvint_result_k4ZWmrnpu0qe = -rvint_result_k4ZWmrnpu0qe;
        }
    }
    o.VintValue = rvint_result_k4ZWmrnpu0qe;
                    return o;
                }
            case 113:
                {
                VLongObject o = new VLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_c1zUi570E5Y2 = bytes[index++];
    byte rvlong_sign_vftqoZe8tuBS = (byte)(rvlong_b_c1zUi570E5Y2 & 1);
    byte rvlong_size_s5Hszlr5b96b = (byte)(rvlong_b_c1zUi570E5Y2 >> 1);
    ulong rvlong_remaining_cL5wlp7Ef66g = 0;
    for (int i_z6aFVsVVARbn = 0; i_z6aFVsVVARbn < rvlong_size_s5Hszlr5b96b - 1; i_z6aFVsVVARbn++) {
        rvlong_remaining_cL5wlp7Ef66g = rvlong_remaining_cL5wlp7Ef66g | (((ulong)bytes[index++] << (8 * i_z6aFVsVVARbn)));
    }
    long rvlong_result_kOBsN210jrkN = (long)rvlong_remaining_cL5wlp7Ef66g;
    rvlong_result_kOBsN210jrkN = ~rvlong_result_kOBsN210jrkN;
    if (rvlong_result_kOBsN210jrkN == long.MaxValue) {
        rvlong_result_kOBsN210jrkN = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_kOBsN210jrkN += 1;
        if (rvlong_sign_vftqoZe8tuBS == 0) {
            rvlong_result_kOBsN210jrkN = -rvlong_result_kOBsN210jrkN;
        }
    }
    o.VlongValue = rvlong_result_kOBsN210jrkN;
                    return o;
                }
            case 114:
                {
                VUShortObject o = new VUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_xRXdw6MV8AtC = 0;
                    for (int i_eVjTokLzJR8G = 0; i_eVjTokLzJR8G < 9; i_eVjTokLzJR8G++) {
                        byte b = bytes[index++];
                        if (i_eVjTokLzJR8G < 8) {
                            vuread_xRXdw6MV8AtC += (((ulong)b & (ulong)127) << (7 * i_eVjTokLzJR8G));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xRXdw6MV8AtC += (ulong)b << (7 * i_eVjTokLzJR8G);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_xRXdw6MV8AtC;
                    return o;
                }
            case 115:
                {
                VUIntObject o = new VUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_vO0mfg7RWxMd = 0;
                    for (int i_mRyDepo7u8i2 = 0; i_mRyDepo7u8i2 < 9; i_mRyDepo7u8i2++) {
                        byte b = bytes[index++];
                        if (i_mRyDepo7u8i2 < 8) {
                            vuread_vO0mfg7RWxMd += (((ulong)b & (ulong)127) << (7 * i_mRyDepo7u8i2));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vO0mfg7RWxMd += (ulong)b << (7 * i_mRyDepo7u8i2);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_vO0mfg7RWxMd;
                    return o;
                }
            case 116:
                {
                VULongObject o = new VULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_shL8PUdlTqoS = 0;
                    for (int i_czQ2DMQWjgpH = 0; i_czQ2DMQWjgpH < 9; i_czQ2DMQWjgpH++) {
                        byte b = bytes[index++];
                        if (i_czQ2DMQWjgpH < 8) {
                            vuread_shL8PUdlTqoS += (((ulong)b & (ulong)127) << (7 * i_czQ2DMQWjgpH));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_shL8PUdlTqoS += (ulong)b << (7 * i_czQ2DMQWjgpH);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_shL8PUdlTqoS;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = new HighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_m8bcuAtnCQyP = 0;
                    for (int i_ovDSrvSM1emH = 0; i_ovDSrvSM1emH < 9; i_ovDSrvSM1emH++) {
                        byte b = bytes[index++];
                        if (i_ovDSrvSM1emH < 8) {
                            vuread_m8bcuAtnCQyP += (((ulong)b & (ulong)127) << (7 * i_ovDSrvSM1emH));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_m8bcuAtnCQyP += (ulong)b << (7 * i_ovDSrvSM1emH);
                            break;
                        }
                    }
                    ushort stringLength_uhvuDal0G8E8 = (ushort)vuread_m8bcuAtnCQyP;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_uhvuDal0G8E8);
                index += stringLength_uhvuDal0G8E8;
                // PRIMITIVE: HighScore
                    ulong vuread_kTSSeylh5RxF = 0;
                    for (int i_pOCTWbefTPUh = 0; i_pOCTWbefTPUh < 9; i_pOCTWbefTPUh++) {
                        byte b = bytes[index++];
                        if (i_pOCTWbefTPUh < 8) {
                            vuread_kTSSeylh5RxF += (((ulong)b & (ulong)127) << (7 * i_pOCTWbefTPUh));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kTSSeylh5RxF += (ulong)b << (7 * i_pOCTWbefTPUh);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_kTSSeylh5RxF;
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
