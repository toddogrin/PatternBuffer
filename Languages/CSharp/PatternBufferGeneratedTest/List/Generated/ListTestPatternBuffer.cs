
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.List {
    public class ListTestPatternBuffer {
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
        private IListTestInstantiator instantiator;
        public ListTestPatternBuffer() : this(4096, new DefaultListTestInstantiator()) { }
        public ListTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultListTestInstantiator()) { }
        public ListTestPatternBuffer(IListTestInstantiator instantiator) : this (4096, instantiator) { }
        public ListTestPatternBuffer(uint bufferSize, IListTestInstantiator instantiator) {
            this.bytes = new byte[bufferSize];
            this.instantiator = instantiator;
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(AbstractThing o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing1 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing2 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(StringListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing1ListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractThingListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(AbstractThing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 9;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
        }
        public void Energize(Thing1 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 10;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue2
                bytes[index++] = (byte)((o.IntValue2 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2 & 255);
        }
        public void Energize(Thing2 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue3
                bytes[index++] = (byte)((o.IntValue3 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue3 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue3 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue3 & 255);
        }
        public void Energize(IntListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: IntListValue
                if (o.IntListValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntListValue == null || o.IntListValue == null || o.IntListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntListValue.Count;
                int i_ja5cnZVzaTnv;
                for (i_ja5cnZVzaTnv = 0; i_ja5cnZVzaTnv < 2; i_ja5cnZVzaTnv++) {
                    if ((ulong)o.IntListValue.Count < vuBoundaries[i_ja5cnZVzaTnv]) {
                       byteCount = (int)(i_ja5cnZVzaTnv + 1);
                       goto guvsgoto_maYCiLKTpK1l;
                    }
                }
                byteCount = (int)i_ja5cnZVzaTnv + 1;
                guvsgoto_maYCiLKTpK1l:
                    for (int i_jPaSRPEwNVGp = 0; i_jPaSRPEwNVGp < byteCount; i_jPaSRPEwNVGp++) {
                        if (i_jPaSRPEwNVGp < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_jPaSRPEwNVGp < byteCount - 1) {
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
                foreach (int primitive in o.IntListValue) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
                }
        }
        public void Energize(StringListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: StringListValue
                if (o.StringListValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.StringListValue == null || o.StringListValue == null || o.StringListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.StringListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.StringListValue.Count;
                int i_i1YnXS3TXCgD;
                for (i_i1YnXS3TXCgD = 0; i_i1YnXS3TXCgD < 2; i_i1YnXS3TXCgD++) {
                    if ((ulong)o.StringListValue.Count < vuBoundaries[i_i1YnXS3TXCgD]) {
                       byteCount = (int)(i_i1YnXS3TXCgD + 1);
                       goto guvsgoto_hlJf6yXDMUnO;
                    }
                }
                byteCount = (int)i_i1YnXS3TXCgD + 1;
                guvsgoto_hlJf6yXDMUnO:
                    for (int i_p2cKgFIMDPUb = 0; i_p2cKgFIMDPUb < byteCount; i_p2cKgFIMDPUb++) {
                        if (i_p2cKgFIMDPUb < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_p2cKgFIMDPUb < byteCount - 1) {
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
                foreach (string primitive in o.StringListValue) {
                uint stringLength_gQDM5UTLCwxZ;
                int i_jnwgmKkOhW7g;
                for (i_jnwgmKkOhW7g = 0; i_jnwgmKkOhW7g < 2; i_jnwgmKkOhW7g++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_jnwgmKkOhW7g]) {
                       stringLength_gQDM5UTLCwxZ = (uint)(i_jnwgmKkOhW7g + 1);
                       goto guvsgoto_vqI42WCZegEd;
                    }
                }
                stringLength_gQDM5UTLCwxZ = (uint)i_jnwgmKkOhW7g + 1;
                guvsgoto_vqI42WCZegEd:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_gqYdTEanFmTZ = 0; i_gqYdTEanFmTZ < stringLength_gQDM5UTLCwxZ; i_gqYdTEanFmTZ++) {
                        if (i_gqYdTEanFmTZ < stringLength_gQDM5UTLCwxZ - 1) {
                            byte b = (byte)(value & 127);
                            if (i_gqYdTEanFmTZ < stringLength_gQDM5UTLCwxZ - 1) {
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
                index += Encoding.UTF8.GetBytes(primitive, 0, primitive.Length, bytes, index);
                }
            }
                }
        }
        public void Energize(Thing1ListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: ThingListValue
                if (o.ThingListValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.ThingListValue == null || o.ThingListValue == null || o.ThingListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingListValue.Count;
                int i_jMz1mSSdtCPL;
                for (i_jMz1mSSdtCPL = 0; i_jMz1mSSdtCPL < 2; i_jMz1mSSdtCPL++) {
                    if ((ulong)o.ThingListValue.Count < vuBoundaries[i_jMz1mSSdtCPL]) {
                       byteCount = (int)(i_jMz1mSSdtCPL + 1);
                       goto guvsgoto_yNURn56jlzqR;
                    }
                }
                byteCount = (int)i_jMz1mSSdtCPL + 1;
                guvsgoto_yNURn56jlzqR:
                    for (int i_zzfKfrHjEHjI = 0; i_zzfKfrHjEHjI < byteCount; i_zzfKfrHjEHjI++) {
                        if (i_zzfKfrHjEHjI < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_zzfKfrHjEHjI < byteCount - 1) {
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
                foreach (Thing1 finalObject in o.ThingListValue) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
                }
        }
        public void Energize(AbstractThingListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: AbstractThingListValue
                if (o.AbstractThingListValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.AbstractThingListValue == null || o.AbstractThingListValue == null || o.AbstractThingListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.AbstractThingListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.AbstractThingListValue.Count;
                int i_cjaXDQFE8iSX;
                for (i_cjaXDQFE8iSX = 0; i_cjaXDQFE8iSX < 2; i_cjaXDQFE8iSX++) {
                    if ((ulong)o.AbstractThingListValue.Count < vuBoundaries[i_cjaXDQFE8iSX]) {
                       byteCount = (int)(i_cjaXDQFE8iSX + 1);
                       goto guvsgoto_wCBl0X4ZagPg;
                    }
                }
                byteCount = (int)i_cjaXDQFE8iSX + 1;
                guvsgoto_wCBl0X4ZagPg:
                    for (int i_vwe31gn0C0aT = 0; i_vwe31gn0C0aT < byteCount; i_vwe31gn0C0aT++) {
                        if (i_vwe31gn0C0aT < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_vwe31gn0C0aT < byteCount - 1) {
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
                foreach (IListTestObject abstractObject in o.AbstractThingListValue) {
                    Energize((IListTestObject)abstractObject, bytes, ref index, true);
                }
            }
                }
        }
        public void Energize(VIntListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: VintListValue
                if (o.VintListValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.VintListValue == null || o.VintListValue == null || o.VintListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintListValue.Count;
                int i_hUQXbPKSUNvD;
                for (i_hUQXbPKSUNvD = 0; i_hUQXbPKSUNvD < 2; i_hUQXbPKSUNvD++) {
                    if ((ulong)o.VintListValue.Count < vuBoundaries[i_hUQXbPKSUNvD]) {
                       byteCount = (int)(i_hUQXbPKSUNvD + 1);
                       goto guvsgoto_gHnFHZL2T8F5;
                    }
                }
                byteCount = (int)i_hUQXbPKSUNvD + 1;
                guvsgoto_gHnFHZL2T8F5:
                    for (int i_sa832ZOoiqG6 = 0; i_sa832ZOoiqG6 < byteCount; i_sa832ZOoiqG6++) {
                        if (i_sa832ZOoiqG6 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_sa832ZOoiqG6 < byteCount - 1) {
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
                foreach (int primitive in o.VintListValue) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_ma7iH0d01iMg = primitive;
    if (s2ultemp_ma7iH0d01iMg == long.MinValue) {
        s2ultemp_ma7iH0d01iMg = long.MaxValue;
    }
    else {
        if (s2ultemp_ma7iH0d01iMg > 0) {
            s2ultemp_ma7iH0d01iMg = -s2ultemp_ma7iH0d01iMg;
        }
        s2ultemp_ma7iH0d01iMg -= 1;
    }
    s2ultemp_ma7iH0d01iMg = ~s2ultemp_ma7iH0d01iMg;
    ulong s2ulresult_lzZXqs9MlTWG = (ulong)s2ultemp_ma7iH0d01iMg;
    //// AppendGetSignVariantSize(s2ulresult_lzZXqs9MlTWG)
    byte vr_wR94urXaoTub = 1;
    for (int v_sBk4KEMKy1CC = 56; v_sBk4KEMKy1CC >= 0; v_sBk4KEMKy1CC -= 8) {
        if (((255UL << v_sBk4KEMKy1CC) & s2ulresult_lzZXqs9MlTWG) > 0) {
            vr_wR94urXaoTub = (byte)(v_sBk4KEMKy1CC / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_wR94urXaoTub << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_z180r3VTnAsZ = 0; vi_z180r3VTnAsZ < vr_wR94urXaoTub - 1; vi_z180r3VTnAsZ++) {
        bytes[index++] = (byte)(s2ulresult_lzZXqs9MlTWG & 255);
        s2ulresult_lzZXqs9MlTWG = s2ulresult_lzZXqs9MlTWG >> 8;
    }
                }
            }
                }
        }
        public void Energize(IListTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 9:
                    Energize((AbstractThing)o, bytes, ref index, writeTypeId);
                    break;
                case 10:
                    Energize((Thing1)o, bytes, ref index, writeTypeId);
                    break;
                case 11:
                    Energize((Thing2)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((IntListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((StringListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((Thing1ListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((AbstractThingListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((VIntListObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_viGKvM2ReYeY = 0;
                    for (int i_dfcQgmi8pH5D = 0; i_dfcQgmi8pH5D < 9; i_dfcQgmi8pH5D++) {
                        byte b = bytes[index++];
                        if (i_dfcQgmi8pH5D < 8) {
                            vuread_viGKvM2ReYeY += (((ulong)b & (ulong)127) << (7 * i_dfcQgmi8pH5D));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_viGKvM2ReYeY += (ulong)b << (7 * i_dfcQgmi8pH5D);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_viGKvM2ReYeY;
            switch (typeId) {
            case 9:
                {
                AbstractThing o = this.instantiator.AcquireAbstractThing();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 10:
                {
                Thing1 o = this.instantiator.AcquireThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2
                o.IntValue2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                Thing2 o = this.instantiator.AcquireThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue3
                o.IntValue3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntListObject o = this.instantiator.AcquireIntListObject();
                nullFlagsIndex++;
                // LIST: IntListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_h7Tu8LXrjvdB;
                    ulong vuread_zcpV9VxlWjSl = 0;
                    for (int i_weMbrtJsncry = 0; i_weMbrtJsncry < 9; i_weMbrtJsncry++) {
                        byte b = bytes[index++];
                        if (i_weMbrtJsncry < 8) {
                            vuread_zcpV9VxlWjSl += (((ulong)b & (ulong)127) << (7 * i_weMbrtJsncry));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zcpV9VxlWjSl += (ulong)b << (7 * i_weMbrtJsncry);
                            break;
                        }
                    }
                    count_h7Tu8LXrjvdB = (ushort)vuread_zcpV9VxlWjSl;
            // Read list items
            if (count_h7Tu8LXrjvdB > 0) {
                o.IntListValue = this.instantiator.AcquireListOfInt();
                int listValue_xITDaWOWbLRe;
                for (int i_yw9EjTRioIC3 = 0; i_yw9EjTRioIC3 < count_h7Tu8LXrjvdB; i_yw9EjTRioIC3++) {
                    // Read Int list item
                listValue_xITDaWOWbLRe =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_xITDaWOWbLRe);
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
                StringListObject o = this.instantiator.AcquireStringListObject();
                nullFlagsIndex++;
                // LIST: StringListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_zWa0VUn5V12B;
                    ulong vuread_a4l9F6jqwIe4 = 0;
                    for (int i_ifjEvijufZEn = 0; i_ifjEvijufZEn < 9; i_ifjEvijufZEn++) {
                        byte b = bytes[index++];
                        if (i_ifjEvijufZEn < 8) {
                            vuread_a4l9F6jqwIe4 += (((ulong)b & (ulong)127) << (7 * i_ifjEvijufZEn));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_a4l9F6jqwIe4 += (ulong)b << (7 * i_ifjEvijufZEn);
                            break;
                        }
                    }
                    count_zWa0VUn5V12B = (ushort)vuread_a4l9F6jqwIe4;
            // Read list items
            if (count_zWa0VUn5V12B > 0) {
                o.StringListValue = this.instantiator.AcquireListOfString();
                string listValue_uYarxWsfEICp;
                for (int i_oRNsymGASfGP = 0; i_oRNsymGASfGP < count_zWa0VUn5V12B; i_oRNsymGASfGP++) {
                    // Read String list item
                    ulong vuread_y22Kp9AVN46O = 0;
                    for (int i_m062teFRrvPO = 0; i_m062teFRrvPO < 9; i_m062teFRrvPO++) {
                        byte b = bytes[index++];
                        if (i_m062teFRrvPO < 8) {
                            vuread_y22Kp9AVN46O += (((ulong)b & (ulong)127) << (7 * i_m062teFRrvPO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_y22Kp9AVN46O += (ulong)b << (7 * i_m062teFRrvPO);
                            break;
                        }
                    }
                    ushort stringLength_pTKNSIvmz7mR = (ushort)vuread_y22Kp9AVN46O;
                listValue_uYarxWsfEICp = Encoding.UTF8.GetString(bytes, index, stringLength_pTKNSIvmz7mR);
                index += stringLength_pTKNSIvmz7mR;
                    o.StringListValue.Add(listValue_uYarxWsfEICp);
                }
            }
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                Thing1ListObject o = this.instantiator.AcquireThing1ListObject();
                nullFlagsIndex++;
                // LIST: ThingListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_fPx5mpZKE6xG;
                    ulong vuread_i5lSOVbRW6i1 = 0;
                    for (int i_pD3vBFzKmnyJ = 0; i_pD3vBFzKmnyJ < 9; i_pD3vBFzKmnyJ++) {
                        byte b = bytes[index++];
                        if (i_pD3vBFzKmnyJ < 8) {
                            vuread_i5lSOVbRW6i1 += (((ulong)b & (ulong)127) << (7 * i_pD3vBFzKmnyJ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_i5lSOVbRW6i1 += (ulong)b << (7 * i_pD3vBFzKmnyJ);
                            break;
                        }
                    }
                    count_fPx5mpZKE6xG = (ushort)vuread_i5lSOVbRW6i1;
            // Read list items
            if (count_fPx5mpZKE6xG > 0) {
                o.ThingListValue = this.instantiator.AcquireListOfThing1();
                for (int li_qEIyevjHDAIx = 0; li_qEIyevjHDAIx < count_fPx5mpZKE6xG; li_qEIyevjHDAIx++) {
                    o.ThingListValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                AbstractThingListObject o = this.instantiator.AcquireAbstractThingListObject();
                nullFlagsIndex++;
                // LIST: AbstractThingListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_xXdGt81pHFuT;
                    ulong vuread_jEj9HXtgHLgj = 0;
                    for (int i_fNMBXKyl5GCO = 0; i_fNMBXKyl5GCO < 9; i_fNMBXKyl5GCO++) {
                        byte b = bytes[index++];
                        if (i_fNMBXKyl5GCO < 8) {
                            vuread_jEj9HXtgHLgj += (((ulong)b & (ulong)127) << (7 * i_fNMBXKyl5GCO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jEj9HXtgHLgj += (ulong)b << (7 * i_fNMBXKyl5GCO);
                            break;
                        }
                    }
                    count_xXdGt81pHFuT = (ushort)vuread_jEj9HXtgHLgj;
            // Read list items
            if (count_xXdGt81pHFuT > 0) {
                o.AbstractThingListValue = this.instantiator.AcquireListOfAbstractThing();
                for (int li_l3qowicgkZbK = 0; li_l3qowicgkZbK < count_xXdGt81pHFuT; li_l3qowicgkZbK++) {
                    o.AbstractThingListValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                VIntListObject o = this.instantiator.AcquireVIntListObject();
                nullFlagsIndex++;
                // LIST: VintListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_fjaQhB0rQ4tP;
                    ulong vuread_iAC6hiY0cEIO = 0;
                    for (int i_neUyJ98xMcpN = 0; i_neUyJ98xMcpN < 9; i_neUyJ98xMcpN++) {
                        byte b = bytes[index++];
                        if (i_neUyJ98xMcpN < 8) {
                            vuread_iAC6hiY0cEIO += (((ulong)b & (ulong)127) << (7 * i_neUyJ98xMcpN));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iAC6hiY0cEIO += (ulong)b << (7 * i_neUyJ98xMcpN);
                            break;
                        }
                    }
                    count_fjaQhB0rQ4tP = (ushort)vuread_iAC6hiY0cEIO;
            // Read list items
            if (count_fjaQhB0rQ4tP > 0) {
                o.VintListValue = this.instantiator.AcquireListOfInt();
                int listValue_pReDQk7HJL36;
                for (int i_rf9bblHRKwjc = 0; i_rf9bblHRKwjc < count_fjaQhB0rQ4tP; i_rf9bblHRKwjc++) {
                    // Read VInt list item
    byte rvint_b_sBSR56dskYwz = bytes[index++];
    byte rvint_sign_buk1Gae5lYSD = (byte)(rvint_b_sBSR56dskYwz & 1);
    byte rvint_size_a6vBEHcnHbVo = (byte)(rvint_b_sBSR56dskYwz >> 1);
    ulong rvint_remaining_lqMNHKV1SJ7Q = 0;
    for (int i_aQkKso13TpQ8 = 0; i_aQkKso13TpQ8 < rvint_size_a6vBEHcnHbVo - 1; i_aQkKso13TpQ8++) {
        rvint_remaining_lqMNHKV1SJ7Q = rvint_remaining_lqMNHKV1SJ7Q | (((ulong)bytes[index++] << (8 * i_aQkKso13TpQ8)));
    }
    int rvint_result_pMXNVj1cJ6Aq = (int)rvint_remaining_lqMNHKV1SJ7Q;
    rvint_result_pMXNVj1cJ6Aq = ~rvint_result_pMXNVj1cJ6Aq;
    if (rvint_result_pMXNVj1cJ6Aq == int.MaxValue) {
        rvint_result_pMXNVj1cJ6Aq = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_pMXNVj1cJ6Aq += 1;
        if (rvint_sign_buk1Gae5lYSD == 0) {
            rvint_result_pMXNVj1cJ6Aq = -rvint_result_pMXNVj1cJ6Aq;
        }
    }
    listValue_pReDQk7HJL36 = rvint_result_pMXNVj1cJ6Aq;
                    o.VintListValue.Add(listValue_pReDQk7HJL36);
                }
            }
                }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_kBxKc0UA9PAY = 0;
                    for (int i_jC5tj1EmJNc5 = 0; i_jC5tj1EmJNc5 < 9; i_jC5tj1EmJNc5++) {
                        byte b = bytes[index++];
                        if (i_jC5tj1EmJNc5 < 8) {
                            vuread_kBxKc0UA9PAY += (((ulong)b & (ulong)127) << (7 * i_jC5tj1EmJNc5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kBxKc0UA9PAY += (ulong)b << (7 * i_jC5tj1EmJNc5);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_kBxKc0UA9PAY;
            switch (typeId) {
            case 9:
                {
                AbstractThing o = this.instantiator.AcquireAbstractThing();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 10:
                {
                Thing1 o = this.instantiator.AcquireThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2
                o.IntValue2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                Thing2 o = this.instantiator.AcquireThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue3
                o.IntValue3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntListObject o = this.instantiator.AcquireIntListObject();
                nullFlagsIndex++;
                // LIST: IntListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_uifJR4gep4m0;
                    ulong vuread_wr12Ep94l8qt = 0;
                    for (int i_fI3RBnQUyCX4 = 0; i_fI3RBnQUyCX4 < 9; i_fI3RBnQUyCX4++) {
                        byte b = bytes[index++];
                        if (i_fI3RBnQUyCX4 < 8) {
                            vuread_wr12Ep94l8qt += (((ulong)b & (ulong)127) << (7 * i_fI3RBnQUyCX4));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wr12Ep94l8qt += (ulong)b << (7 * i_fI3RBnQUyCX4);
                            break;
                        }
                    }
                    count_uifJR4gep4m0 = (ushort)vuread_wr12Ep94l8qt;
            // Read list items
            if (count_uifJR4gep4m0 > 0) {
                o.IntListValue = this.instantiator.AcquireListOfInt();
                int listValue_tlTeIwICqeB2;
                for (int i_aLStOhTY2Wwj = 0; i_aLStOhTY2Wwj < count_uifJR4gep4m0; i_aLStOhTY2Wwj++) {
                    // Read Int list item
                listValue_tlTeIwICqeB2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_tlTeIwICqeB2);
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
                StringListObject o = this.instantiator.AcquireStringListObject();
                nullFlagsIndex++;
                // LIST: StringListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_azMcnBCyD6ht;
                    ulong vuread_n4wZAXdjgaQ0 = 0;
                    for (int i_mxgqT9c8ZJdj = 0; i_mxgqT9c8ZJdj < 9; i_mxgqT9c8ZJdj++) {
                        byte b = bytes[index++];
                        if (i_mxgqT9c8ZJdj < 8) {
                            vuread_n4wZAXdjgaQ0 += (((ulong)b & (ulong)127) << (7 * i_mxgqT9c8ZJdj));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_n4wZAXdjgaQ0 += (ulong)b << (7 * i_mxgqT9c8ZJdj);
                            break;
                        }
                    }
                    count_azMcnBCyD6ht = (ushort)vuread_n4wZAXdjgaQ0;
            // Read list items
            if (count_azMcnBCyD6ht > 0) {
                o.StringListValue = this.instantiator.AcquireListOfString();
                string listValue_sGpYLdyeDzWT;
                for (int i_u3xeSmcaSWH0 = 0; i_u3xeSmcaSWH0 < count_azMcnBCyD6ht; i_u3xeSmcaSWH0++) {
                    // Read String list item
                    ulong vuread_opHdLMwfKxEZ = 0;
                    for (int i_p7qMHcA68yCA = 0; i_p7qMHcA68yCA < 9; i_p7qMHcA68yCA++) {
                        byte b = bytes[index++];
                        if (i_p7qMHcA68yCA < 8) {
                            vuread_opHdLMwfKxEZ += (((ulong)b & (ulong)127) << (7 * i_p7qMHcA68yCA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_opHdLMwfKxEZ += (ulong)b << (7 * i_p7qMHcA68yCA);
                            break;
                        }
                    }
                    ushort stringLength_ilPE4iE71mg3 = (ushort)vuread_opHdLMwfKxEZ;
                listValue_sGpYLdyeDzWT = Encoding.UTF8.GetString(bytes, index, stringLength_ilPE4iE71mg3);
                index += stringLength_ilPE4iE71mg3;
                    o.StringListValue.Add(listValue_sGpYLdyeDzWT);
                }
            }
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                Thing1ListObject o = this.instantiator.AcquireThing1ListObject();
                nullFlagsIndex++;
                // LIST: ThingListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_j4ju5Z1JWEFD;
                    ulong vuread_r8yfACp8QZ26 = 0;
                    for (int i_x1zYVk5jWhPR = 0; i_x1zYVk5jWhPR < 9; i_x1zYVk5jWhPR++) {
                        byte b = bytes[index++];
                        if (i_x1zYVk5jWhPR < 8) {
                            vuread_r8yfACp8QZ26 += (((ulong)b & (ulong)127) << (7 * i_x1zYVk5jWhPR));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_r8yfACp8QZ26 += (ulong)b << (7 * i_x1zYVk5jWhPR);
                            break;
                        }
                    }
                    count_j4ju5Z1JWEFD = (ushort)vuread_r8yfACp8QZ26;
            // Read list items
            if (count_j4ju5Z1JWEFD > 0) {
                o.ThingListValue = this.instantiator.AcquireListOfThing1();
                for (int li_mbkUF5dhBW7J = 0; li_mbkUF5dhBW7J < count_j4ju5Z1JWEFD; li_mbkUF5dhBW7J++) {
                    o.ThingListValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                AbstractThingListObject o = this.instantiator.AcquireAbstractThingListObject();
                nullFlagsIndex++;
                // LIST: AbstractThingListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_quFGjETHbmBd;
                    ulong vuread_lcXMIvRHsRMz = 0;
                    for (int i_hECVWVFg40lA = 0; i_hECVWVFg40lA < 9; i_hECVWVFg40lA++) {
                        byte b = bytes[index++];
                        if (i_hECVWVFg40lA < 8) {
                            vuread_lcXMIvRHsRMz += (((ulong)b & (ulong)127) << (7 * i_hECVWVFg40lA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lcXMIvRHsRMz += (ulong)b << (7 * i_hECVWVFg40lA);
                            break;
                        }
                    }
                    count_quFGjETHbmBd = (ushort)vuread_lcXMIvRHsRMz;
            // Read list items
            if (count_quFGjETHbmBd > 0) {
                o.AbstractThingListValue = this.instantiator.AcquireListOfAbstractThing();
                for (int li_qyaryiPqJhuC = 0; li_qyaryiPqJhuC < count_quFGjETHbmBd; li_qyaryiPqJhuC++) {
                    o.AbstractThingListValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                VIntListObject o = this.instantiator.AcquireVIntListObject();
                nullFlagsIndex++;
                // LIST: VintListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_dAIgezq5SgpO;
                    ulong vuread_a7VqRviK1x8k = 0;
                    for (int i_iAjkcvZkkaNw = 0; i_iAjkcvZkkaNw < 9; i_iAjkcvZkkaNw++) {
                        byte b = bytes[index++];
                        if (i_iAjkcvZkkaNw < 8) {
                            vuread_a7VqRviK1x8k += (((ulong)b & (ulong)127) << (7 * i_iAjkcvZkkaNw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_a7VqRviK1x8k += (ulong)b << (7 * i_iAjkcvZkkaNw);
                            break;
                        }
                    }
                    count_dAIgezq5SgpO = (ushort)vuread_a7VqRviK1x8k;
            // Read list items
            if (count_dAIgezq5SgpO > 0) {
                o.VintListValue = this.instantiator.AcquireListOfInt();
                int listValue_fycFJpSHjwpA;
                for (int i_jyJo8UKUCyUN = 0; i_jyJo8UKUCyUN < count_dAIgezq5SgpO; i_jyJo8UKUCyUN++) {
                    // Read VInt list item
    byte rvint_b_gf3wrfEbuzds = bytes[index++];
    byte rvint_sign_hMaMOAa8lTXN = (byte)(rvint_b_gf3wrfEbuzds & 1);
    byte rvint_size_uLlzz24YNypE = (byte)(rvint_b_gf3wrfEbuzds >> 1);
    ulong rvint_remaining_jwqe2nf7ur5v = 0;
    for (int i_t8gbxWCGrpJP = 0; i_t8gbxWCGrpJP < rvint_size_uLlzz24YNypE - 1; i_t8gbxWCGrpJP++) {
        rvint_remaining_jwqe2nf7ur5v = rvint_remaining_jwqe2nf7ur5v | (((ulong)bytes[index++] << (8 * i_t8gbxWCGrpJP)));
    }
    int rvint_result_xeMCEpO4xGps = (int)rvint_remaining_jwqe2nf7ur5v;
    rvint_result_xeMCEpO4xGps = ~rvint_result_xeMCEpO4xGps;
    if (rvint_result_xeMCEpO4xGps == int.MaxValue) {
        rvint_result_xeMCEpO4xGps = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_xeMCEpO4xGps += 1;
        if (rvint_sign_hMaMOAa8lTXN == 0) {
            rvint_result_xeMCEpO4xGps = -rvint_result_xeMCEpO4xGps;
        }
    }
    listValue_fycFJpSHjwpA = rvint_result_xeMCEpO4xGps;
                    o.VintListValue.Add(listValue_fycFJpSHjwpA);
                }
            }
                }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 9:
                {
                AbstractThing o = this.instantiator.AcquireAbstractThing();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 10:
                {
                Thing1 o = this.instantiator.AcquireThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2
                o.IntValue2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                Thing2 o = this.instantiator.AcquireThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue3
                o.IntValue3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntListObject o = this.instantiator.AcquireIntListObject();
                nullFlagsIndex++;
                // LIST: IntListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_e6g8N0sFQZOA;
                    ulong vuread_u2A16TmgWKkX = 0;
                    for (int i_pNCeMa8oSX0B = 0; i_pNCeMa8oSX0B < 9; i_pNCeMa8oSX0B++) {
                        byte b = bytes[index++];
                        if (i_pNCeMa8oSX0B < 8) {
                            vuread_u2A16TmgWKkX += (((ulong)b & (ulong)127) << (7 * i_pNCeMa8oSX0B));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_u2A16TmgWKkX += (ulong)b << (7 * i_pNCeMa8oSX0B);
                            break;
                        }
                    }
                    count_e6g8N0sFQZOA = (ushort)vuread_u2A16TmgWKkX;
            // Read list items
            if (count_e6g8N0sFQZOA > 0) {
                o.IntListValue = this.instantiator.AcquireListOfInt();
                int listValue_rE2B7e9ezlPL;
                for (int i_vW8NtjGKVtw9 = 0; i_vW8NtjGKVtw9 < count_e6g8N0sFQZOA; i_vW8NtjGKVtw9++) {
                    // Read Int list item
                listValue_rE2B7e9ezlPL =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_rE2B7e9ezlPL);
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
                StringListObject o = this.instantiator.AcquireStringListObject();
                nullFlagsIndex++;
                // LIST: StringListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_jn2P0AR8c8mB;
                    ulong vuread_wUiRKgxz70pZ = 0;
                    for (int i_bv4IrqQvh2dT = 0; i_bv4IrqQvh2dT < 9; i_bv4IrqQvh2dT++) {
                        byte b = bytes[index++];
                        if (i_bv4IrqQvh2dT < 8) {
                            vuread_wUiRKgxz70pZ += (((ulong)b & (ulong)127) << (7 * i_bv4IrqQvh2dT));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wUiRKgxz70pZ += (ulong)b << (7 * i_bv4IrqQvh2dT);
                            break;
                        }
                    }
                    count_jn2P0AR8c8mB = (ushort)vuread_wUiRKgxz70pZ;
            // Read list items
            if (count_jn2P0AR8c8mB > 0) {
                o.StringListValue = this.instantiator.AcquireListOfString();
                string listValue_eun9ERJ1KGWJ;
                for (int i_aY9O67bG8cME = 0; i_aY9O67bG8cME < count_jn2P0AR8c8mB; i_aY9O67bG8cME++) {
                    // Read String list item
                    ulong vuread_wx4qrxpGJvHC = 0;
                    for (int i_hbzj0GVjRTDv = 0; i_hbzj0GVjRTDv < 9; i_hbzj0GVjRTDv++) {
                        byte b = bytes[index++];
                        if (i_hbzj0GVjRTDv < 8) {
                            vuread_wx4qrxpGJvHC += (((ulong)b & (ulong)127) << (7 * i_hbzj0GVjRTDv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wx4qrxpGJvHC += (ulong)b << (7 * i_hbzj0GVjRTDv);
                            break;
                        }
                    }
                    ushort stringLength_niRWr0u8QzFq = (ushort)vuread_wx4qrxpGJvHC;
                listValue_eun9ERJ1KGWJ = Encoding.UTF8.GetString(bytes, index, stringLength_niRWr0u8QzFq);
                index += stringLength_niRWr0u8QzFq;
                    o.StringListValue.Add(listValue_eun9ERJ1KGWJ);
                }
            }
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                Thing1ListObject o = this.instantiator.AcquireThing1ListObject();
                nullFlagsIndex++;
                // LIST: ThingListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_zXJTlX2LsTWI;
                    ulong vuread_bVpKXg5kKoFq = 0;
                    for (int i_llhjOwIj4JqD = 0; i_llhjOwIj4JqD < 9; i_llhjOwIj4JqD++) {
                        byte b = bytes[index++];
                        if (i_llhjOwIj4JqD < 8) {
                            vuread_bVpKXg5kKoFq += (((ulong)b & (ulong)127) << (7 * i_llhjOwIj4JqD));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bVpKXg5kKoFq += (ulong)b << (7 * i_llhjOwIj4JqD);
                            break;
                        }
                    }
                    count_zXJTlX2LsTWI = (ushort)vuread_bVpKXg5kKoFq;
            // Read list items
            if (count_zXJTlX2LsTWI > 0) {
                o.ThingListValue = this.instantiator.AcquireListOfThing1();
                for (int li_vFuVD5jHp0gf = 0; li_vFuVD5jHp0gf < count_zXJTlX2LsTWI; li_vFuVD5jHp0gf++) {
                    o.ThingListValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                AbstractThingListObject o = this.instantiator.AcquireAbstractThingListObject();
                nullFlagsIndex++;
                // LIST: AbstractThingListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_hkvLXtUVstsa;
                    ulong vuread_rS76kNODEWWr = 0;
                    for (int i_tjQPe7bKec2D = 0; i_tjQPe7bKec2D < 9; i_tjQPe7bKec2D++) {
                        byte b = bytes[index++];
                        if (i_tjQPe7bKec2D < 8) {
                            vuread_rS76kNODEWWr += (((ulong)b & (ulong)127) << (7 * i_tjQPe7bKec2D));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rS76kNODEWWr += (ulong)b << (7 * i_tjQPe7bKec2D);
                            break;
                        }
                    }
                    count_hkvLXtUVstsa = (ushort)vuread_rS76kNODEWWr;
            // Read list items
            if (count_hkvLXtUVstsa > 0) {
                o.AbstractThingListValue = this.instantiator.AcquireListOfAbstractThing();
                for (int li_a7vLYFlEnufV = 0; li_a7vLYFlEnufV < count_hkvLXtUVstsa; li_a7vLYFlEnufV++) {
                    o.AbstractThingListValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                VIntListObject o = this.instantiator.AcquireVIntListObject();
                nullFlagsIndex++;
                // LIST: VintListValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_znxLmNLFxe0N;
                    ulong vuread_qfQusS6NZD5m = 0;
                    for (int i_hdO9KreAe5R1 = 0; i_hdO9KreAe5R1 < 9; i_hdO9KreAe5R1++) {
                        byte b = bytes[index++];
                        if (i_hdO9KreAe5R1 < 8) {
                            vuread_qfQusS6NZD5m += (((ulong)b & (ulong)127) << (7 * i_hdO9KreAe5R1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qfQusS6NZD5m += (ulong)b << (7 * i_hdO9KreAe5R1);
                            break;
                        }
                    }
                    count_znxLmNLFxe0N = (ushort)vuread_qfQusS6NZD5m;
            // Read list items
            if (count_znxLmNLFxe0N > 0) {
                o.VintListValue = this.instantiator.AcquireListOfInt();
                int listValue_pzxBAxf6gS8S;
                for (int i_v1mEyB6Eskuj = 0; i_v1mEyB6Eskuj < count_znxLmNLFxe0N; i_v1mEyB6Eskuj++) {
                    // Read VInt list item
    byte rvint_b_zM4gazJRyZT2 = bytes[index++];
    byte rvint_sign_iEmBy8fJe5kT = (byte)(rvint_b_zM4gazJRyZT2 & 1);
    byte rvint_size_bJcM9mJAfnCY = (byte)(rvint_b_zM4gazJRyZT2 >> 1);
    ulong rvint_remaining_m96Riru9htk3 = 0;
    for (int i_gEgteUfcBlbA = 0; i_gEgteUfcBlbA < rvint_size_bJcM9mJAfnCY - 1; i_gEgteUfcBlbA++) {
        rvint_remaining_m96Riru9htk3 = rvint_remaining_m96Riru9htk3 | (((ulong)bytes[index++] << (8 * i_gEgteUfcBlbA)));
    }
    int rvint_result_j6SlqtXgcy8y = (int)rvint_remaining_m96Riru9htk3;
    rvint_result_j6SlqtXgcy8y = ~rvint_result_j6SlqtXgcy8y;
    if (rvint_result_j6SlqtXgcy8y == int.MaxValue) {
        rvint_result_j6SlqtXgcy8y = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_j6SlqtXgcy8y += 1;
        if (rvint_sign_iEmBy8fJe5kT == 0) {
            rvint_result_j6SlqtXgcy8y = -rvint_result_j6SlqtXgcy8y;
        }
    }
    listValue_pzxBAxf6gS8S = rvint_result_j6SlqtXgcy8y;
                    o.VintListValue.Add(listValue_pzxBAxf6gS8S);
                }
            }
                }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new ListTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(AbstractThing o) {
            if (o != null) {
                if (o is Thing1) {
                    this.Reclaim((Thing1)o);
                }
                else if (o is Thing2) {
                    this.Reclaim((Thing2)o);
                }
                o.IntValue1 = default(int);
            }
        }
        public void Reclaim(Thing1 o) {
            if (o != null) {
                o.IntValue2 = default(int);
                this.instantiator.DiscardThing1(o);
            }
        }
        public void Reclaim(Thing2 o) {
            if (o != null) {
                o.IntValue3 = default(int);
                this.instantiator.DiscardThing2(o);
            }
        }
        public void Reclaim(IntListObject o) {
            if (o != null) {
                this.instantiator.DiscardIntListObject(o);
            }
        }
        public void Reclaim(StringListObject o) {
            if (o != null) {
                this.instantiator.DiscardStringListObject(o);
            }
        }
        public void Reclaim(Thing1ListObject o) {
            if (o != null) {
                if (o.ThingListValue != null) {
                    foreach (Thing1 e in o.ThingListValue) {
                        this.Reclaim(e);
                    }
                    o.ThingListValue.Clear();
                    this.instantiator.DiscardListOfThing1((List<Thing1>)o.ThingListValue);
                }
                this.instantiator.DiscardThing1ListObject(o);
            }
        }
        public void Reclaim(AbstractThingListObject o) {
            if (o != null) {
                if (o.AbstractThingListValue != null) {
                    foreach (AbstractThing e in o.AbstractThingListValue) {
                        this.Reclaim(e);
                    }
                    o.AbstractThingListValue.Clear();
                    this.instantiator.DiscardListOfAbstractThing((List<AbstractThing>)o.AbstractThingListValue);
                }
                this.instantiator.DiscardAbstractThingListObject(o);
            }
        }
        public void Reclaim(VIntListObject o) {
            if (o != null) {
                this.instantiator.DiscardVIntListObject(o);
            }
        }
    }
}
