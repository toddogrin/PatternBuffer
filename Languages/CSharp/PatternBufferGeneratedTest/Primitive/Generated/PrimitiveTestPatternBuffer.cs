
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
        private IPrimitiveTestInstantiator instantiator;
        public PrimitiveTestPatternBuffer() : this(4096, new DefaultPrimitiveTestInstantiator()) { }
        public PrimitiveTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultPrimitiveTestInstantiator()) { }
        public PrimitiveTestPatternBuffer(IPrimitiveTestInstantiator instantiator) : this (4096, instantiator) { }
        public PrimitiveTestPatternBuffer(uint bufferSize, IPrimitiveTestInstantiator instantiator) {
            this.bytes = new byte[bufferSize];
            this.instantiator = instantiator;
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(ShortObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(LongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(UShortObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(UIntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ULongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(StringObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(DoubleObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FloatObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(BoolObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ByteObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EverythingObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VLongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VUShortObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VUIntObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VULongObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(HighScoreObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
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
                uint stringLength_eqDkFw71XlQ8;
                int i_x8YLQAiOwO5m;
                for (i_x8YLQAiOwO5m = 0; i_x8YLQAiOwO5m < 2; i_x8YLQAiOwO5m++) {
                    if ((ulong)o.StringValue.Length < vuBoundaries[i_x8YLQAiOwO5m]) {
                       stringLength_eqDkFw71XlQ8 = (uint)(i_x8YLQAiOwO5m + 1);
                       goto guvsgoto_mjjF4s9KmIPH;
                    }
                }
                stringLength_eqDkFw71XlQ8 = (uint)i_x8YLQAiOwO5m + 1;
                guvsgoto_mjjF4s9KmIPH:
                if (o.StringValue.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.StringValue.Length;
                    for (int i_nqhBOSvXIRYg = 0; i_nqhBOSvXIRYg < stringLength_eqDkFw71XlQ8; i_nqhBOSvXIRYg++) {
                        if (i_nqhBOSvXIRYg < stringLength_eqDkFw71XlQ8 - 1) {
                            byte b = (byte)(value & 127);
                            if (i_nqhBOSvXIRYg < stringLength_eqDkFw71XlQ8 - 1) {
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
                double double_jctGwjfML6pH = o.DoubleValue;
                ulong doubleAsULong_nvkwdbMZo79O;
                unsafe {
                    doubleAsULong_nvkwdbMZo79O = *((ulong*)&(double_jctGwjfML6pH));
                }
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 56) & 255);
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 48) & 255);
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 40) & 255);
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 32) & 255);
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 24) & 255);
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 16) & 255);
                bytes[index++] = (byte)((doubleAsULong_nvkwdbMZo79O >> 8) & 255);
                bytes[index++] = (byte)(doubleAsULong_nvkwdbMZo79O & 255);
        }
        public void Energize(FloatObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 19;
            }
                // PRIMITIVE: FloatValue
                float float_eH6Dn18mjSoO = o.FloatValue;
                uint floatAsUInt_dLrmIsKKaJ4s;
                unsafe {
                    floatAsUInt_dLrmIsKKaJ4s = *((uint*)&(float_eH6Dn18mjSoO));
                }
                bytes[index++] = (byte)((floatAsUInt_dLrmIsKKaJ4s >> 24) & 255);
                bytes[index++] = (byte)((floatAsUInt_dLrmIsKKaJ4s >> 16) & 255);
                bytes[index++] = (byte)((floatAsUInt_dLrmIsKKaJ4s >> 8) & 255);
                bytes[index++] = (byte)(floatAsUInt_dLrmIsKKaJ4s & 255);
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
                uint stringLength_o9UGf92ydPvY;
                int i_tzq5xyNLNN6o;
                for (i_tzq5xyNLNN6o = 0; i_tzq5xyNLNN6o < 2; i_tzq5xyNLNN6o++) {
                    if ((ulong)o.StringValue.Length < vuBoundaries[i_tzq5xyNLNN6o]) {
                       stringLength_o9UGf92ydPvY = (uint)(i_tzq5xyNLNN6o + 1);
                       goto guvsgoto_fLzT7dxZhGoB;
                    }
                }
                stringLength_o9UGf92ydPvY = (uint)i_tzq5xyNLNN6o + 1;
                guvsgoto_fLzT7dxZhGoB:
                if (o.StringValue.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.StringValue.Length;
                    for (int i_dBgjZZKBqC96 = 0; i_dBgjZZKBqC96 < stringLength_o9UGf92ydPvY; i_dBgjZZKBqC96++) {
                        if (i_dBgjZZKBqC96 < stringLength_o9UGf92ydPvY - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dBgjZZKBqC96 < stringLength_o9UGf92ydPvY - 1) {
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
                double double_x0N6mflbUsWP = o.DoubleValue;
                ulong doubleAsULong_s7bPcTlJPkMF;
                unsafe {
                    doubleAsULong_s7bPcTlJPkMF = *((ulong*)&(double_x0N6mflbUsWP));
                }
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 56) & 255);
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 48) & 255);
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 40) & 255);
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 32) & 255);
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 24) & 255);
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 16) & 255);
                bytes[index++] = (byte)((doubleAsULong_s7bPcTlJPkMF >> 8) & 255);
                bytes[index++] = (byte)(doubleAsULong_s7bPcTlJPkMF & 255);
                // PRIMITIVE: FloatValue
                float float_yn9r5XkrAtcG = o.FloatValue;
                uint floatAsUInt_tQzHC5DYPBA2;
                unsafe {
                    floatAsUInt_tQzHC5DYPBA2 = *((uint*)&(float_yn9r5XkrAtcG));
                }
                bytes[index++] = (byte)((floatAsUInt_tQzHC5DYPBA2 >> 24) & 255);
                bytes[index++] = (byte)((floatAsUInt_tQzHC5DYPBA2 >> 16) & 255);
                bytes[index++] = (byte)((floatAsUInt_tQzHC5DYPBA2 >> 8) & 255);
                bytes[index++] = (byte)(floatAsUInt_tQzHC5DYPBA2 & 255);
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
    long s2ultemp_u5zHrzrSoha8 = o.VintValue;
    if (s2ultemp_u5zHrzrSoha8 == long.MinValue) {
        s2ultemp_u5zHrzrSoha8 = long.MaxValue;
    }
    else {
        if (s2ultemp_u5zHrzrSoha8 > 0) {
            s2ultemp_u5zHrzrSoha8 = -s2ultemp_u5zHrzrSoha8;
        }
        s2ultemp_u5zHrzrSoha8 -= 1;
    }
    s2ultemp_u5zHrzrSoha8 = ~s2ultemp_u5zHrzrSoha8;
    ulong s2ulresult_c3f7iEpz4F3v = (ulong)s2ultemp_u5zHrzrSoha8;
    //// AppendGetSignVariantSize(s2ulresult_c3f7iEpz4F3v)
    byte vr_iNhURX0FWhDa = 1;
    for (int v_kN9bctrNQBBI = 56; v_kN9bctrNQBBI >= 0; v_kN9bctrNQBBI -= 8) {
        if (((255UL << v_kN9bctrNQBBI) & s2ulresult_c3f7iEpz4F3v) > 0) {
            vr_iNhURX0FWhDa = (byte)(v_kN9bctrNQBBI / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_iNhURX0FWhDa << 1) | (byte)(o.VintValue > 0 ? 0 : 1));
    for (int vi_vGQklb7scdmN = 0; vi_vGQklb7scdmN < vr_iNhURX0FWhDa - 1; vi_vGQklb7scdmN++) {
        bytes[index++] = (byte)(s2ulresult_c3f7iEpz4F3v & 255);
        s2ulresult_c3f7iEpz4F3v = s2ulresult_c3f7iEpz4F3v >> 8;
    }
        }
        public void Energize(VLongObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 113;
            }
                // PRIMITIVE: VlongValue
    //// AppendSignedToULong(o.VlongValue)
    long s2ultemp_hGbBrEl9AfJF = o.VlongValue;
    if (s2ultemp_hGbBrEl9AfJF == long.MinValue) {
        s2ultemp_hGbBrEl9AfJF = long.MaxValue;
    }
    else {
        if (s2ultemp_hGbBrEl9AfJF > 0) {
            s2ultemp_hGbBrEl9AfJF = -s2ultemp_hGbBrEl9AfJF;
        }
        s2ultemp_hGbBrEl9AfJF -= 1;
    }
    s2ultemp_hGbBrEl9AfJF = ~s2ultemp_hGbBrEl9AfJF;
    ulong s2ulresult_nnwLnpP2mI4k = (ulong)s2ultemp_hGbBrEl9AfJF;
    //// AppendGetSignVariantSize(s2ulresult_nnwLnpP2mI4k)
    byte vr_cQuVjk7uAwTF = 1;
    for (int v_h0wmpCiU7lP7 = 56; v_h0wmpCiU7lP7 >= 0; v_h0wmpCiU7lP7 -= 8) {
        if (((255UL << v_h0wmpCiU7lP7) & s2ulresult_nnwLnpP2mI4k) > 0) {
            vr_cQuVjk7uAwTF = (byte)(v_h0wmpCiU7lP7 / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_cQuVjk7uAwTF << 1) | (byte)(o.VlongValue > 0 ? 0 : 1));
    for (int vi_rweWytBSL0uK = 0; vi_rweWytBSL0uK < vr_cQuVjk7uAwTF - 1; vi_rweWytBSL0uK++) {
        bytes[index++] = (byte)(s2ulresult_nnwLnpP2mI4k & 255);
        s2ulresult_nnwLnpP2mI4k = s2ulresult_nnwLnpP2mI4k >> 8;
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
                int i_xDNUAkn5awgX;
                for (i_xDNUAkn5awgX = 0; i_xDNUAkn5awgX < 2; i_xDNUAkn5awgX++) {
                    if ((ulong)o.VushortValue < vuBoundaries[i_xDNUAkn5awgX]) {
                       byteCount = (int)(i_xDNUAkn5awgX + 1);
                       goto guvsgoto_eAZphoejE1sx;
                    }
                }
                byteCount = (int)i_xDNUAkn5awgX + 1;
                guvsgoto_eAZphoejE1sx:
                    for (int i_cl5g4a3CFVbZ = 0; i_cl5g4a3CFVbZ < byteCount; i_cl5g4a3CFVbZ++) {
                        if (i_cl5g4a3CFVbZ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_cl5g4a3CFVbZ < byteCount - 1) {
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
                int i_rRsBNyKXtcj5;
                for (i_rRsBNyKXtcj5 = 0; i_rRsBNyKXtcj5 < 4; i_rRsBNyKXtcj5++) {
                    if ((ulong)o.VuintValue < vuBoundaries[i_rRsBNyKXtcj5]) {
                       byteCount = (int)(i_rRsBNyKXtcj5 + 1);
                       goto guvsgoto_q3NSgGDXeR25;
                    }
                }
                byteCount = (int)i_rRsBNyKXtcj5 + 1;
                guvsgoto_q3NSgGDXeR25:
                    for (int i_h8oD702hBXhH = 0; i_h8oD702hBXhH < byteCount; i_h8oD702hBXhH++) {
                        if (i_h8oD702hBXhH < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_h8oD702hBXhH < byteCount - 1) {
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
                int i_sBYgloFKURzh;
                for (i_sBYgloFKURzh = 0; i_sBYgloFKURzh < 8; i_sBYgloFKURzh++) {
                    if ((ulong)o.VulongValue < vuBoundaries[i_sBYgloFKURzh]) {
                       byteCount = (int)(i_sBYgloFKURzh + 1);
                       goto guvsgoto_nEZE2sSzsazn;
                    }
                }
                byteCount = (int)i_sBYgloFKURzh + 1;
                guvsgoto_nEZE2sSzsazn:
                    for (int i_ha0nYVE3JV5i = 0; i_ha0nYVE3JV5i < byteCount; i_ha0nYVE3JV5i++) {
                        if (i_ha0nYVE3JV5i < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ha0nYVE3JV5i < byteCount - 1) {
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
                uint stringLength_of4btTMsIaUF;
                int i_lFKHGGO7GQHg;
                for (i_lFKHGGO7GQHg = 0; i_lFKHGGO7GQHg < 2; i_lFKHGGO7GQHg++) {
                    if ((ulong)o.Name.Length < vuBoundaries[i_lFKHGGO7GQHg]) {
                       stringLength_of4btTMsIaUF = (uint)(i_lFKHGGO7GQHg + 1);
                       goto guvsgoto_aV5nrHWYfRm2;
                    }
                }
                stringLength_of4btTMsIaUF = (uint)i_lFKHGGO7GQHg + 1;
                guvsgoto_aV5nrHWYfRm2:
                if (o.Name.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)o.Name.Length;
                    for (int i_iEqafhJrpvmd = 0; i_iEqafhJrpvmd < stringLength_of4btTMsIaUF; i_iEqafhJrpvmd++) {
                        if (i_iEqafhJrpvmd < stringLength_of4btTMsIaUF - 1) {
                            byte b = (byte)(value & 127);
                            if (i_iEqafhJrpvmd < stringLength_of4btTMsIaUF - 1) {
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
                int i_efVcwX8uoZ3W;
                for (i_efVcwX8uoZ3W = 0; i_efVcwX8uoZ3W < 4; i_efVcwX8uoZ3W++) {
                    if ((ulong)o.HighScore < vuBoundaries[i_efVcwX8uoZ3W]) {
                       byteCount = (int)(i_efVcwX8uoZ3W + 1);
                       goto guvsgoto_vrLc8gd12cJY;
                    }
                }
                byteCount = (int)i_efVcwX8uoZ3W + 1;
                guvsgoto_vrLc8gd12cJY:
                    for (int i_hWT8i5NgsGRp = 0; i_hWT8i5NgsGRp < byteCount; i_hWT8i5NgsGRp++) {
                        if (i_hWT8i5NgsGRp < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_hWT8i5NgsGRp < byteCount - 1) {
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
                    ulong vuread_xM9ANPor5C09 = 0;
                    for (int i_iH5Bw1ZaxYVl = 0; i_iH5Bw1ZaxYVl < 9; i_iH5Bw1ZaxYVl++) {
                        byte b = bytes[index++];
                        if (i_iH5Bw1ZaxYVl < 8) {
                            vuread_xM9ANPor5C09 += (((ulong)b & (ulong)127) << (7 * i_iH5Bw1ZaxYVl));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xM9ANPor5C09 += (ulong)b << (7 * i_iH5Bw1ZaxYVl);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_xM9ANPor5C09;
            switch (typeId) {
            case 11:
                {
                ShortObject o = this.instantiator.AcquireShortObject();
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
                IntObject o = this.instantiator.AcquireIntObject();
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
                LongObject o = this.instantiator.AcquireLongObject();
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
                UShortObject o = this.instantiator.AcquireUShortObject();
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
                UIntObject o = this.instantiator.AcquireUIntObject();
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
                ULongObject o = this.instantiator.AcquireULongObject();
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
                StringObject o = this.instantiator.AcquireStringObject();
                // PRIMITIVE: StringValue
                    ulong vuread_vIRILM1Y6TML = 0;
                    for (int i_alUARR2f0XdI = 0; i_alUARR2f0XdI < 9; i_alUARR2f0XdI++) {
                        byte b = bytes[index++];
                        if (i_alUARR2f0XdI < 8) {
                            vuread_vIRILM1Y6TML += (((ulong)b & (ulong)127) << (7 * i_alUARR2f0XdI));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vIRILM1Y6TML += (ulong)b << (7 * i_alUARR2f0XdI);
                            break;
                        }
                    }
                    ushort stringLength_jfT6yCFNxGhT = (ushort)vuread_vIRILM1Y6TML;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_jfT6yCFNxGhT);
                index += stringLength_jfT6yCFNxGhT;
                    return o;
                }
            case 18:
                {
                DoubleObject o = this.instantiator.AcquireDoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_eqyU76oNCi6m =
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
                double double_yr2D6nMYzlNY;
                unsafe {
                    double_yr2D6nMYzlNY = *((double*)&(doubleAsUInt_eqyU76oNCi6m));
                }
                o.DoubleValue = double_yr2D6nMYzlNY;
                    return o;
                }
            case 19:
                {
                FloatObject o = this.instantiator.AcquireFloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_tx2ThYlYI5qA =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_sf5QOb2aFjLu;
                unsafe {
                    float_sf5QOb2aFjLu = *((float*)&(floatAsUInt_tx2ThYlYI5qA));
                }
                o.FloatValue = float_sf5QOb2aFjLu;
                    return o;
                }
            case 20:
                {
                BoolObject o = this.instantiator.AcquireBoolObject();
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                    return o;
                }
            case 21:
                {
                ByteObject o = this.instantiator.AcquireByteObject();
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 22:
                {
                EverythingObject o = this.instantiator.AcquireEverythingObject();
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
                    ulong vuread_h5kysMsbPe9K = 0;
                    for (int i_bFFO7hOWZExG = 0; i_bFFO7hOWZExG < 9; i_bFFO7hOWZExG++) {
                        byte b = bytes[index++];
                        if (i_bFFO7hOWZExG < 8) {
                            vuread_h5kysMsbPe9K += (((ulong)b & (ulong)127) << (7 * i_bFFO7hOWZExG));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_h5kysMsbPe9K += (ulong)b << (7 * i_bFFO7hOWZExG);
                            break;
                        }
                    }
                    ushort stringLength_hhh4IzfYuPV0 = (ushort)vuread_h5kysMsbPe9K;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_hhh4IzfYuPV0);
                index += stringLength_hhh4IzfYuPV0;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_qWG6NoVnhH0d =
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
                double double_x8CfdX9eMbBm;
                unsafe {
                    double_x8CfdX9eMbBm = *((double*)&(doubleAsUInt_qWG6NoVnhH0d));
                }
                o.DoubleValue = double_x8CfdX9eMbBm;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_em81e57cdt9k =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_xB1mb8bWHNEt;
                unsafe {
                    float_xB1mb8bWHNEt = *((float*)&(floatAsUInt_em81e57cdt9k));
                }
                o.FloatValue = float_xB1mb8bWHNEt;
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 112:
                {
                VIntObject o = this.instantiator.AcquireVIntObject();
                // PRIMITIVE: VintValue
    byte rvint_b_pRiKTkywizlL = bytes[index++];
    byte rvint_sign_yWcNaOOasmVA = (byte)(rvint_b_pRiKTkywizlL & 1);
    byte rvint_size_g3imKX9KCRLt = (byte)(rvint_b_pRiKTkywizlL >> 1);
    ulong rvint_remaining_vAdxoilVbx5s = 0;
    for (int i_wtczO81y5SvZ = 0; i_wtczO81y5SvZ < rvint_size_g3imKX9KCRLt - 1; i_wtczO81y5SvZ++) {
        rvint_remaining_vAdxoilVbx5s = rvint_remaining_vAdxoilVbx5s | (((ulong)bytes[index++] << (8 * i_wtczO81y5SvZ)));
    }
    int rvint_result_amVuzKjokTXJ = (int)rvint_remaining_vAdxoilVbx5s;
    rvint_result_amVuzKjokTXJ = ~rvint_result_amVuzKjokTXJ;
    if (rvint_result_amVuzKjokTXJ == int.MaxValue) {
        rvint_result_amVuzKjokTXJ = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_amVuzKjokTXJ += 1;
        if (rvint_sign_yWcNaOOasmVA == 0) {
            rvint_result_amVuzKjokTXJ = -rvint_result_amVuzKjokTXJ;
        }
    }
    o.VintValue = rvint_result_amVuzKjokTXJ;
                    return o;
                }
            case 113:
                {
                VLongObject o = this.instantiator.AcquireVLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_pqWkbaz270ur = bytes[index++];
    byte rvlong_sign_tK5DZnxhfnwc = (byte)(rvlong_b_pqWkbaz270ur & 1);
    byte rvlong_size_j0vAoRhjFCXx = (byte)(rvlong_b_pqWkbaz270ur >> 1);
    ulong rvlong_remaining_fQw5tC2k1EJZ = 0;
    for (int i_rQz7vQEy4TYk = 0; i_rQz7vQEy4TYk < rvlong_size_j0vAoRhjFCXx - 1; i_rQz7vQEy4TYk++) {
        rvlong_remaining_fQw5tC2k1EJZ = rvlong_remaining_fQw5tC2k1EJZ | (((ulong)bytes[index++] << (8 * i_rQz7vQEy4TYk)));
    }
    long rvlong_result_r8OqTlVsWHqi = (long)rvlong_remaining_fQw5tC2k1EJZ;
    rvlong_result_r8OqTlVsWHqi = ~rvlong_result_r8OqTlVsWHqi;
    if (rvlong_result_r8OqTlVsWHqi == long.MaxValue) {
        rvlong_result_r8OqTlVsWHqi = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_r8OqTlVsWHqi += 1;
        if (rvlong_sign_tK5DZnxhfnwc == 0) {
            rvlong_result_r8OqTlVsWHqi = -rvlong_result_r8OqTlVsWHqi;
        }
    }
    o.VlongValue = rvlong_result_r8OqTlVsWHqi;
                    return o;
                }
            case 114:
                {
                VUShortObject o = this.instantiator.AcquireVUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_wCYMulk1qFVI = 0;
                    for (int i_hjYZ8zDC2lqu = 0; i_hjYZ8zDC2lqu < 9; i_hjYZ8zDC2lqu++) {
                        byte b = bytes[index++];
                        if (i_hjYZ8zDC2lqu < 8) {
                            vuread_wCYMulk1qFVI += (((ulong)b & (ulong)127) << (7 * i_hjYZ8zDC2lqu));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wCYMulk1qFVI += (ulong)b << (7 * i_hjYZ8zDC2lqu);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_wCYMulk1qFVI;
                    return o;
                }
            case 115:
                {
                VUIntObject o = this.instantiator.AcquireVUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_vMBQTrdhzqg2 = 0;
                    for (int i_w1dTI64jng8J = 0; i_w1dTI64jng8J < 9; i_w1dTI64jng8J++) {
                        byte b = bytes[index++];
                        if (i_w1dTI64jng8J < 8) {
                            vuread_vMBQTrdhzqg2 += (((ulong)b & (ulong)127) << (7 * i_w1dTI64jng8J));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vMBQTrdhzqg2 += (ulong)b << (7 * i_w1dTI64jng8J);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_vMBQTrdhzqg2;
                    return o;
                }
            case 116:
                {
                VULongObject o = this.instantiator.AcquireVULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_j6txeXpOmDYS = 0;
                    for (int i_tEi8CNiad56h = 0; i_tEi8CNiad56h < 9; i_tEi8CNiad56h++) {
                        byte b = bytes[index++];
                        if (i_tEi8CNiad56h < 8) {
                            vuread_j6txeXpOmDYS += (((ulong)b & (ulong)127) << (7 * i_tEi8CNiad56h));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_j6txeXpOmDYS += (ulong)b << (7 * i_tEi8CNiad56h);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_j6txeXpOmDYS;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = this.instantiator.AcquireHighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_zPcLbBPycu9e = 0;
                    for (int i_u5RJ77GA9lbv = 0; i_u5RJ77GA9lbv < 9; i_u5RJ77GA9lbv++) {
                        byte b = bytes[index++];
                        if (i_u5RJ77GA9lbv < 8) {
                            vuread_zPcLbBPycu9e += (((ulong)b & (ulong)127) << (7 * i_u5RJ77GA9lbv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zPcLbBPycu9e += (ulong)b << (7 * i_u5RJ77GA9lbv);
                            break;
                        }
                    }
                    ushort stringLength_jT36rggSN1tW = (ushort)vuread_zPcLbBPycu9e;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_jT36rggSN1tW);
                index += stringLength_jT36rggSN1tW;
                // PRIMITIVE: HighScore
                    ulong vuread_xsxgxgf2kwaW = 0;
                    for (int i_pH9LpIfbUZjw = 0; i_pH9LpIfbUZjw < 9; i_pH9LpIfbUZjw++) {
                        byte b = bytes[index++];
                        if (i_pH9LpIfbUZjw < 8) {
                            vuread_xsxgxgf2kwaW += (((ulong)b & (ulong)127) << (7 * i_pH9LpIfbUZjw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xsxgxgf2kwaW += (ulong)b << (7 * i_pH9LpIfbUZjw);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_xsxgxgf2kwaW;
                    return o;
                }
                default:
                    throw new PrimitiveTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_kHUPu2XWORRS = 0;
                    for (int i_bJb6pg4B448A = 0; i_bJb6pg4B448A < 9; i_bJb6pg4B448A++) {
                        byte b = bytes[index++];
                        if (i_bJb6pg4B448A < 8) {
                            vuread_kHUPu2XWORRS += (((ulong)b & (ulong)127) << (7 * i_bJb6pg4B448A));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kHUPu2XWORRS += (ulong)b << (7 * i_bJb6pg4B448A);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_kHUPu2XWORRS;
            switch (typeId) {
            case 11:
                {
                ShortObject o = this.instantiator.AcquireShortObject();
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
                IntObject o = this.instantiator.AcquireIntObject();
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
                LongObject o = this.instantiator.AcquireLongObject();
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
                UShortObject o = this.instantiator.AcquireUShortObject();
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
                UIntObject o = this.instantiator.AcquireUIntObject();
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
                ULongObject o = this.instantiator.AcquireULongObject();
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
                StringObject o = this.instantiator.AcquireStringObject();
                // PRIMITIVE: StringValue
                    ulong vuread_jzHrJnh3ZrHQ = 0;
                    for (int i_ojWO4SBEIuRA = 0; i_ojWO4SBEIuRA < 9; i_ojWO4SBEIuRA++) {
                        byte b = bytes[index++];
                        if (i_ojWO4SBEIuRA < 8) {
                            vuread_jzHrJnh3ZrHQ += (((ulong)b & (ulong)127) << (7 * i_ojWO4SBEIuRA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jzHrJnh3ZrHQ += (ulong)b << (7 * i_ojWO4SBEIuRA);
                            break;
                        }
                    }
                    ushort stringLength_z4lAg9KfjbRZ = (ushort)vuread_jzHrJnh3ZrHQ;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_z4lAg9KfjbRZ);
                index += stringLength_z4lAg9KfjbRZ;
                    return o;
                }
            case 18:
                {
                DoubleObject o = this.instantiator.AcquireDoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_oM1QXeKQwE37 =
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
                double double_swQOhMIc2lKZ;
                unsafe {
                    double_swQOhMIc2lKZ = *((double*)&(doubleAsUInt_oM1QXeKQwE37));
                }
                o.DoubleValue = double_swQOhMIc2lKZ;
                    return o;
                }
            case 19:
                {
                FloatObject o = this.instantiator.AcquireFloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_oDWnTFXwI6fs =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_f6kBKnqaRhKm;
                unsafe {
                    float_f6kBKnqaRhKm = *((float*)&(floatAsUInt_oDWnTFXwI6fs));
                }
                o.FloatValue = float_f6kBKnqaRhKm;
                    return o;
                }
            case 20:
                {
                BoolObject o = this.instantiator.AcquireBoolObject();
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                    return o;
                }
            case 21:
                {
                ByteObject o = this.instantiator.AcquireByteObject();
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 22:
                {
                EverythingObject o = this.instantiator.AcquireEverythingObject();
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
                    ulong vuread_lgCP4JhAcOju = 0;
                    for (int i_hw61RHzq01LZ = 0; i_hw61RHzq01LZ < 9; i_hw61RHzq01LZ++) {
                        byte b = bytes[index++];
                        if (i_hw61RHzq01LZ < 8) {
                            vuread_lgCP4JhAcOju += (((ulong)b & (ulong)127) << (7 * i_hw61RHzq01LZ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lgCP4JhAcOju += (ulong)b << (7 * i_hw61RHzq01LZ);
                            break;
                        }
                    }
                    ushort stringLength_vUQEUbdmDSBk = (ushort)vuread_lgCP4JhAcOju;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_vUQEUbdmDSBk);
                index += stringLength_vUQEUbdmDSBk;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_bhB8ZOqlLwlx =
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
                double double_nWqQexTYbLVM;
                unsafe {
                    double_nWqQexTYbLVM = *((double*)&(doubleAsUInt_bhB8ZOqlLwlx));
                }
                o.DoubleValue = double_nWqQexTYbLVM;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_iBwO5usQLuZK =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_clF5tltKFNji;
                unsafe {
                    float_clF5tltKFNji = *((float*)&(floatAsUInt_iBwO5usQLuZK));
                }
                o.FloatValue = float_clF5tltKFNji;
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 112:
                {
                VIntObject o = this.instantiator.AcquireVIntObject();
                // PRIMITIVE: VintValue
    byte rvint_b_cABlKAojK2L3 = bytes[index++];
    byte rvint_sign_wXF0rkhz7tOx = (byte)(rvint_b_cABlKAojK2L3 & 1);
    byte rvint_size_hLqqeFWUv402 = (byte)(rvint_b_cABlKAojK2L3 >> 1);
    ulong rvint_remaining_ti9eyaHB0DWh = 0;
    for (int i_vByAmzMWWd39 = 0; i_vByAmzMWWd39 < rvint_size_hLqqeFWUv402 - 1; i_vByAmzMWWd39++) {
        rvint_remaining_ti9eyaHB0DWh = rvint_remaining_ti9eyaHB0DWh | (((ulong)bytes[index++] << (8 * i_vByAmzMWWd39)));
    }
    int rvint_result_e7eef0H77Mgj = (int)rvint_remaining_ti9eyaHB0DWh;
    rvint_result_e7eef0H77Mgj = ~rvint_result_e7eef0H77Mgj;
    if (rvint_result_e7eef0H77Mgj == int.MaxValue) {
        rvint_result_e7eef0H77Mgj = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_e7eef0H77Mgj += 1;
        if (rvint_sign_wXF0rkhz7tOx == 0) {
            rvint_result_e7eef0H77Mgj = -rvint_result_e7eef0H77Mgj;
        }
    }
    o.VintValue = rvint_result_e7eef0H77Mgj;
                    return o;
                }
            case 113:
                {
                VLongObject o = this.instantiator.AcquireVLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_eca7VmHZZiBM = bytes[index++];
    byte rvlong_sign_cvH5sdgQpa4A = (byte)(rvlong_b_eca7VmHZZiBM & 1);
    byte rvlong_size_yCw96Yjnvopk = (byte)(rvlong_b_eca7VmHZZiBM >> 1);
    ulong rvlong_remaining_kOaJGdjbGB7U = 0;
    for (int i_iLO3FA4kiKbt = 0; i_iLO3FA4kiKbt < rvlong_size_yCw96Yjnvopk - 1; i_iLO3FA4kiKbt++) {
        rvlong_remaining_kOaJGdjbGB7U = rvlong_remaining_kOaJGdjbGB7U | (((ulong)bytes[index++] << (8 * i_iLO3FA4kiKbt)));
    }
    long rvlong_result_wH3a9nr2fxGN = (long)rvlong_remaining_kOaJGdjbGB7U;
    rvlong_result_wH3a9nr2fxGN = ~rvlong_result_wH3a9nr2fxGN;
    if (rvlong_result_wH3a9nr2fxGN == long.MaxValue) {
        rvlong_result_wH3a9nr2fxGN = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_wH3a9nr2fxGN += 1;
        if (rvlong_sign_cvH5sdgQpa4A == 0) {
            rvlong_result_wH3a9nr2fxGN = -rvlong_result_wH3a9nr2fxGN;
        }
    }
    o.VlongValue = rvlong_result_wH3a9nr2fxGN;
                    return o;
                }
            case 114:
                {
                VUShortObject o = this.instantiator.AcquireVUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_bHkl024EELQu = 0;
                    for (int i_epR5ufbYNRT8 = 0; i_epR5ufbYNRT8 < 9; i_epR5ufbYNRT8++) {
                        byte b = bytes[index++];
                        if (i_epR5ufbYNRT8 < 8) {
                            vuread_bHkl024EELQu += (((ulong)b & (ulong)127) << (7 * i_epR5ufbYNRT8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bHkl024EELQu += (ulong)b << (7 * i_epR5ufbYNRT8);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_bHkl024EELQu;
                    return o;
                }
            case 115:
                {
                VUIntObject o = this.instantiator.AcquireVUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_eicskfO6eb08 = 0;
                    for (int i_gStqQHYo1I0T = 0; i_gStqQHYo1I0T < 9; i_gStqQHYo1I0T++) {
                        byte b = bytes[index++];
                        if (i_gStqQHYo1I0T < 8) {
                            vuread_eicskfO6eb08 += (((ulong)b & (ulong)127) << (7 * i_gStqQHYo1I0T));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_eicskfO6eb08 += (ulong)b << (7 * i_gStqQHYo1I0T);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_eicskfO6eb08;
                    return o;
                }
            case 116:
                {
                VULongObject o = this.instantiator.AcquireVULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_nwHavSavYlbR = 0;
                    for (int i_vLty7TqizTPL = 0; i_vLty7TqizTPL < 9; i_vLty7TqizTPL++) {
                        byte b = bytes[index++];
                        if (i_vLty7TqizTPL < 8) {
                            vuread_nwHavSavYlbR += (((ulong)b & (ulong)127) << (7 * i_vLty7TqizTPL));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nwHavSavYlbR += (ulong)b << (7 * i_vLty7TqizTPL);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_nwHavSavYlbR;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = this.instantiator.AcquireHighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_oOKwbEkdRLAe = 0;
                    for (int i_fzrhsRtWQ6oL = 0; i_fzrhsRtWQ6oL < 9; i_fzrhsRtWQ6oL++) {
                        byte b = bytes[index++];
                        if (i_fzrhsRtWQ6oL < 8) {
                            vuread_oOKwbEkdRLAe += (((ulong)b & (ulong)127) << (7 * i_fzrhsRtWQ6oL));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oOKwbEkdRLAe += (ulong)b << (7 * i_fzrhsRtWQ6oL);
                            break;
                        }
                    }
                    ushort stringLength_uUig3EgLstWY = (ushort)vuread_oOKwbEkdRLAe;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_uUig3EgLstWY);
                index += stringLength_uUig3EgLstWY;
                // PRIMITIVE: HighScore
                    ulong vuread_o3CtfAzGYE0t = 0;
                    for (int i_e4h4JL4kue2D = 0; i_e4h4JL4kue2D < 9; i_e4h4JL4kue2D++) {
                        byte b = bytes[index++];
                        if (i_e4h4JL4kue2D < 8) {
                            vuread_o3CtfAzGYE0t += (((ulong)b & (ulong)127) << (7 * i_e4h4JL4kue2D));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_o3CtfAzGYE0t += (ulong)b << (7 * i_e4h4JL4kue2D);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_o3CtfAzGYE0t;
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
                ShortObject o = this.instantiator.AcquireShortObject();
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
                IntObject o = this.instantiator.AcquireIntObject();
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
                LongObject o = this.instantiator.AcquireLongObject();
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
                UShortObject o = this.instantiator.AcquireUShortObject();
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
                UIntObject o = this.instantiator.AcquireUIntObject();
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
                ULongObject o = this.instantiator.AcquireULongObject();
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
                StringObject o = this.instantiator.AcquireStringObject();
                // PRIMITIVE: StringValue
                    ulong vuread_b08rm3pSI88x = 0;
                    for (int i_pznebdrEb8gf = 0; i_pznebdrEb8gf < 9; i_pznebdrEb8gf++) {
                        byte b = bytes[index++];
                        if (i_pznebdrEb8gf < 8) {
                            vuread_b08rm3pSI88x += (((ulong)b & (ulong)127) << (7 * i_pznebdrEb8gf));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_b08rm3pSI88x += (ulong)b << (7 * i_pznebdrEb8gf);
                            break;
                        }
                    }
                    ushort stringLength_f9tK99iLA8Wh = (ushort)vuread_b08rm3pSI88x;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_f9tK99iLA8Wh);
                index += stringLength_f9tK99iLA8Wh;
                    return o;
                }
            case 18:
                {
                DoubleObject o = this.instantiator.AcquireDoubleObject();
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_qN8AYj5ob5aK =
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
                double double_cZHZwp2kha2S;
                unsafe {
                    double_cZHZwp2kha2S = *((double*)&(doubleAsUInt_qN8AYj5ob5aK));
                }
                o.DoubleValue = double_cZHZwp2kha2S;
                    return o;
                }
            case 19:
                {
                FloatObject o = this.instantiator.AcquireFloatObject();
                // PRIMITIVE: FloatValue
                uint floatAsUInt_jAwtfXqJGFBy =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_udJwRrgdT2kw;
                unsafe {
                    float_udJwRrgdT2kw = *((float*)&(floatAsUInt_jAwtfXqJGFBy));
                }
                o.FloatValue = float_udJwRrgdT2kw;
                    return o;
                }
            case 20:
                {
                BoolObject o = this.instantiator.AcquireBoolObject();
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                    return o;
                }
            case 21:
                {
                ByteObject o = this.instantiator.AcquireByteObject();
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 22:
                {
                EverythingObject o = this.instantiator.AcquireEverythingObject();
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
                    ulong vuread_rGCZ4Y8UCLey = 0;
                    for (int i_uMjnPAdrMkq1 = 0; i_uMjnPAdrMkq1 < 9; i_uMjnPAdrMkq1++) {
                        byte b = bytes[index++];
                        if (i_uMjnPAdrMkq1 < 8) {
                            vuread_rGCZ4Y8UCLey += (((ulong)b & (ulong)127) << (7 * i_uMjnPAdrMkq1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rGCZ4Y8UCLey += (ulong)b << (7 * i_uMjnPAdrMkq1);
                            break;
                        }
                    }
                    ushort stringLength_c0Q1d1ekZ7ct = (ushort)vuread_rGCZ4Y8UCLey;
                o.StringValue = Encoding.UTF8.GetString(bytes, index, stringLength_c0Q1d1ekZ7ct);
                index += stringLength_c0Q1d1ekZ7ct;
                // PRIMITIVE: DoubleValue
                ulong doubleAsUInt_iAPSGQ6EWreA =
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
                double double_poa2X9HyxcNJ;
                unsafe {
                    double_poa2X9HyxcNJ = *((double*)&(doubleAsUInt_iAPSGQ6EWreA));
                }
                o.DoubleValue = double_poa2X9HyxcNJ;
                // PRIMITIVE: FloatValue
                uint floatAsUInt_ug6CdPaU8K3p =
                    (uint)(
                        ((uint)bytes[index++] << 24) |
                        ((uint)bytes[index++] << 16) |
                        ((uint)bytes[index++] << 8) |
                        (uint)bytes[index++]
                    );
                float float_s1Fy3VREpLnP;
                unsafe {
                    float_s1Fy3VREpLnP = *((float*)&(floatAsUInt_ug6CdPaU8K3p));
                }
                o.FloatValue = float_s1Fy3VREpLnP;
                // PRIMITIVE: BoolValue
                o.BoolValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 112:
                {
                VIntObject o = this.instantiator.AcquireVIntObject();
                // PRIMITIVE: VintValue
    byte rvint_b_tvU5oWftkJj6 = bytes[index++];
    byte rvint_sign_mjEMvitTm94z = (byte)(rvint_b_tvU5oWftkJj6 & 1);
    byte rvint_size_tDBgrtCi7pNI = (byte)(rvint_b_tvU5oWftkJj6 >> 1);
    ulong rvint_remaining_aVqDG3Fn6a83 = 0;
    for (int i_eyzZqkcVAvlV = 0; i_eyzZqkcVAvlV < rvint_size_tDBgrtCi7pNI - 1; i_eyzZqkcVAvlV++) {
        rvint_remaining_aVqDG3Fn6a83 = rvint_remaining_aVqDG3Fn6a83 | (((ulong)bytes[index++] << (8 * i_eyzZqkcVAvlV)));
    }
    int rvint_result_i9c1hb8oF5LK = (int)rvint_remaining_aVqDG3Fn6a83;
    rvint_result_i9c1hb8oF5LK = ~rvint_result_i9c1hb8oF5LK;
    if (rvint_result_i9c1hb8oF5LK == int.MaxValue) {
        rvint_result_i9c1hb8oF5LK = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_i9c1hb8oF5LK += 1;
        if (rvint_sign_mjEMvitTm94z == 0) {
            rvint_result_i9c1hb8oF5LK = -rvint_result_i9c1hb8oF5LK;
        }
    }
    o.VintValue = rvint_result_i9c1hb8oF5LK;
                    return o;
                }
            case 113:
                {
                VLongObject o = this.instantiator.AcquireVLongObject();
                // PRIMITIVE: VlongValue
    byte rvlong_b_w0msERCTEH42 = bytes[index++];
    byte rvlong_sign_xM1Xm2iPJFiG = (byte)(rvlong_b_w0msERCTEH42 & 1);
    byte rvlong_size_wNg5bTxpWZ7A = (byte)(rvlong_b_w0msERCTEH42 >> 1);
    ulong rvlong_remaining_yUqT2CqWek7E = 0;
    for (int i_elbNW6axRPB0 = 0; i_elbNW6axRPB0 < rvlong_size_wNg5bTxpWZ7A - 1; i_elbNW6axRPB0++) {
        rvlong_remaining_yUqT2CqWek7E = rvlong_remaining_yUqT2CqWek7E | (((ulong)bytes[index++] << (8 * i_elbNW6axRPB0)));
    }
    long rvlong_result_pHSVjPgePB0C = (long)rvlong_remaining_yUqT2CqWek7E;
    rvlong_result_pHSVjPgePB0C = ~rvlong_result_pHSVjPgePB0C;
    if (rvlong_result_pHSVjPgePB0C == long.MaxValue) {
        rvlong_result_pHSVjPgePB0C = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_pHSVjPgePB0C += 1;
        if (rvlong_sign_xM1Xm2iPJFiG == 0) {
            rvlong_result_pHSVjPgePB0C = -rvlong_result_pHSVjPgePB0C;
        }
    }
    o.VlongValue = rvlong_result_pHSVjPgePB0C;
                    return o;
                }
            case 114:
                {
                VUShortObject o = this.instantiator.AcquireVUShortObject();
                // PRIMITIVE: VushortValue
                    ulong vuread_pzXhovCQPLUZ = 0;
                    for (int i_sTC0YJSrsziu = 0; i_sTC0YJSrsziu < 9; i_sTC0YJSrsziu++) {
                        byte b = bytes[index++];
                        if (i_sTC0YJSrsziu < 8) {
                            vuread_pzXhovCQPLUZ += (((ulong)b & (ulong)127) << (7 * i_sTC0YJSrsziu));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pzXhovCQPLUZ += (ulong)b << (7 * i_sTC0YJSrsziu);
                            break;
                        }
                    }
                    o.VushortValue = (ushort)vuread_pzXhovCQPLUZ;
                    return o;
                }
            case 115:
                {
                VUIntObject o = this.instantiator.AcquireVUIntObject();
                // PRIMITIVE: VuintValue
                    ulong vuread_tFMzd3ZTvIcx = 0;
                    for (int i_d3ivnUl9W2dA = 0; i_d3ivnUl9W2dA < 9; i_d3ivnUl9W2dA++) {
                        byte b = bytes[index++];
                        if (i_d3ivnUl9W2dA < 8) {
                            vuread_tFMzd3ZTvIcx += (((ulong)b & (ulong)127) << (7 * i_d3ivnUl9W2dA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tFMzd3ZTvIcx += (ulong)b << (7 * i_d3ivnUl9W2dA);
                            break;
                        }
                    }
                    o.VuintValue = (uint)vuread_tFMzd3ZTvIcx;
                    return o;
                }
            case 116:
                {
                VULongObject o = this.instantiator.AcquireVULongObject();
                // PRIMITIVE: VulongValue
                    ulong vuread_fppfSIklrDxT = 0;
                    for (int i_sdNWWbEiRfR5 = 0; i_sdNWWbEiRfR5 < 9; i_sdNWWbEiRfR5++) {
                        byte b = bytes[index++];
                        if (i_sdNWWbEiRfR5 < 8) {
                            vuread_fppfSIklrDxT += (((ulong)b & (ulong)127) << (7 * i_sdNWWbEiRfR5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fppfSIklrDxT += (ulong)b << (7 * i_sdNWWbEiRfR5);
                            break;
                        }
                    }
                    o.VulongValue = (ulong)vuread_fppfSIklrDxT;
                    return o;
                }
            case 117:
                {
                HighScoreObject o = this.instantiator.AcquireHighScoreObject();
                // PRIMITIVE: Name
                    ulong vuread_qUaWy0fPFyMj = 0;
                    for (int i_dynUx4SgHuNv = 0; i_dynUx4SgHuNv < 9; i_dynUx4SgHuNv++) {
                        byte b = bytes[index++];
                        if (i_dynUx4SgHuNv < 8) {
                            vuread_qUaWy0fPFyMj += (((ulong)b & (ulong)127) << (7 * i_dynUx4SgHuNv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qUaWy0fPFyMj += (ulong)b << (7 * i_dynUx4SgHuNv);
                            break;
                        }
                    }
                    ushort stringLength_lweHojH1BmmY = (ushort)vuread_qUaWy0fPFyMj;
                o.Name = Encoding.UTF8.GetString(bytes, index, stringLength_lweHojH1BmmY);
                index += stringLength_lweHojH1BmmY;
                // PRIMITIVE: HighScore
                    ulong vuread_mM7i5GsG0Yjb = 0;
                    for (int i_aSU0aczcT4A0 = 0; i_aSU0aczcT4A0 < 9; i_aSU0aczcT4A0++) {
                        byte b = bytes[index++];
                        if (i_aSU0aczcT4A0 < 8) {
                            vuread_mM7i5GsG0Yjb += (((ulong)b & (ulong)127) << (7 * i_aSU0aczcT4A0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mM7i5GsG0Yjb += (ulong)b << (7 * i_aSU0aczcT4A0);
                            break;
                        }
                    }
                    o.HighScore = (uint)vuread_mM7i5GsG0Yjb;
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
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(ShortObject o) {
            if (o != null) {
                o.ShortValue = default(short);
                this.instantiator.DiscardShortObject(o);
            }
        }
        public void Reclaim(IntObject o) {
            if (o != null) {
                o.IntValue = default(int);
                this.instantiator.DiscardIntObject(o);
            }
        }
        public void Reclaim(LongObject o) {
            if (o != null) {
                o.LongValue = default(long);
                this.instantiator.DiscardLongObject(o);
            }
        }
        public void Reclaim(UShortObject o) {
            if (o != null) {
                o.UshortValue = default(ushort);
                this.instantiator.DiscardUShortObject(o);
            }
        }
        public void Reclaim(UIntObject o) {
            if (o != null) {
                o.UintValue = default(uint);
                this.instantiator.DiscardUIntObject(o);
            }
        }
        public void Reclaim(ULongObject o) {
            if (o != null) {
                o.UlongValue = default(ulong);
                this.instantiator.DiscardULongObject(o);
            }
        }
        public void Reclaim(StringObject o) {
            if (o != null) {
                o.StringValue = default(string);
                this.instantiator.DiscardStringObject(o);
            }
        }
        public void Reclaim(DoubleObject o) {
            if (o != null) {
                o.DoubleValue = default(double);
                this.instantiator.DiscardDoubleObject(o);
            }
        }
        public void Reclaim(FloatObject o) {
            if (o != null) {
                o.FloatValue = default(float);
                this.instantiator.DiscardFloatObject(o);
            }
        }
        public void Reclaim(BoolObject o) {
            if (o != null) {
                o.BoolValue = default(bool);
                this.instantiator.DiscardBoolObject(o);
            }
        }
        public void Reclaim(ByteObject o) {
            if (o != null) {
                o.ByteValue = default(byte);
                this.instantiator.DiscardByteObject(o);
            }
        }
        public void Reclaim(EverythingObject o) {
            if (o != null) {
                o.ShortValue = default(short);
                o.IntValue = default(int);
                o.LongValue = default(long);
                o.UshortValue = default(ushort);
                o.UintValue = default(uint);
                o.UlongValue = default(ulong);
                o.StringValue = default(string);
                o.DoubleValue = default(double);
                o.FloatValue = default(float);
                o.BoolValue = default(bool);
                o.ByteValue = default(byte);
                this.instantiator.DiscardEverythingObject(o);
            }
        }
        public void Reclaim(VIntObject o) {
            if (o != null) {
                o.VintValue = default(int);
                this.instantiator.DiscardVIntObject(o);
            }
        }
        public void Reclaim(VLongObject o) {
            if (o != null) {
                o.VlongValue = default(long);
                this.instantiator.DiscardVLongObject(o);
            }
        }
        public void Reclaim(VUShortObject o) {
            if (o != null) {
                o.VushortValue = default(ushort);
                this.instantiator.DiscardVUShortObject(o);
            }
        }
        public void Reclaim(VUIntObject o) {
            if (o != null) {
                o.VuintValue = default(uint);
                this.instantiator.DiscardVUIntObject(o);
            }
        }
        public void Reclaim(VULongObject o) {
            if (o != null) {
                o.VulongValue = default(ulong);
                this.instantiator.DiscardVULongObject(o);
            }
        }
        public void Reclaim(HighScoreObject o) {
            if (o != null) {
                o.Name = default(string);
                o.HighScore = default(uint);
                this.instantiator.DiscardHighScoreObject(o);
            }
        }
    }
}
