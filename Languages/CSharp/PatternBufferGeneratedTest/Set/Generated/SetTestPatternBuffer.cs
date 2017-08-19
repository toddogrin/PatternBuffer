
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Set {
    public class SetTestPatternBuffer {
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
        private ISetTestInstantiator instantiator;
        public SetTestPatternBuffer() : this(4096, new DefaultSetTestInstantiator()) { }
        public SetTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultSetTestInstantiator()) { }
        public SetTestPatternBuffer(ISetTestInstantiator instantiator) : this (4096, instantiator) { }
        public SetTestPatternBuffer(uint bufferSize, ISetTestInstantiator instantiator) {
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
        public byte[] Energize(IntSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(StringSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing1SetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractThingSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntSetObject o) {
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
        public void Energize(IntSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: IntSetValue
                if (o.IntSetValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntSetValue == null || o.IntSetValue == null || o.IntSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSetValue.Count;
                int i_zV49QyoXE13W;
                for (i_zV49QyoXE13W = 0; i_zV49QyoXE13W < 2; i_zV49QyoXE13W++) {
                    if ((ulong)o.IntSetValue.Count < vuBoundaries[i_zV49QyoXE13W]) {
                       byteCount = (int)(i_zV49QyoXE13W + 1);
                       goto guvsgoto_k5kd6UNWW9vd;
                    }
                }
                byteCount = (int)i_zV49QyoXE13W + 1;
                guvsgoto_k5kd6UNWW9vd:
                    for (int i_gjCGRqbrXNXY = 0; i_gjCGRqbrXNXY < byteCount; i_gjCGRqbrXNXY++) {
                        if (i_gjCGRqbrXNXY < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_gjCGRqbrXNXY < byteCount - 1) {
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
                foreach (int primitive in o.IntSetValue) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
                }
        }
        public void Energize(StringSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: StringSetValue
                if (o.StringSetValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.StringSetValue == null || o.StringSetValue == null || o.StringSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.StringSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.StringSetValue.Count;
                int i_zpU2BYJGcyWW;
                for (i_zpU2BYJGcyWW = 0; i_zpU2BYJGcyWW < 2; i_zpU2BYJGcyWW++) {
                    if ((ulong)o.StringSetValue.Count < vuBoundaries[i_zpU2BYJGcyWW]) {
                       byteCount = (int)(i_zpU2BYJGcyWW + 1);
                       goto guvsgoto_qmL0Mph2NkZ0;
                    }
                }
                byteCount = (int)i_zpU2BYJGcyWW + 1;
                guvsgoto_qmL0Mph2NkZ0:
                    for (int i_hgeG8dpw7fwD = 0; i_hgeG8dpw7fwD < byteCount; i_hgeG8dpw7fwD++) {
                        if (i_hgeG8dpw7fwD < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_hgeG8dpw7fwD < byteCount - 1) {
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
                foreach (string primitive in o.StringSetValue) {
                uint stringLength_uykoUaiftMGC;
                int i_eL4K4D242rfc;
                for (i_eL4K4D242rfc = 0; i_eL4K4D242rfc < 2; i_eL4K4D242rfc++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_eL4K4D242rfc]) {
                       stringLength_uykoUaiftMGC = (uint)(i_eL4K4D242rfc + 1);
                       goto guvsgoto_ni08dqWoAYHF;
                    }
                }
                stringLength_uykoUaiftMGC = (uint)i_eL4K4D242rfc + 1;
                guvsgoto_ni08dqWoAYHF:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_quWbpQCQKMa0 = 0; i_quWbpQCQKMa0 < stringLength_uykoUaiftMGC; i_quWbpQCQKMa0++) {
                        if (i_quWbpQCQKMa0 < stringLength_uykoUaiftMGC - 1) {
                            byte b = (byte)(value & 127);
                            if (i_quWbpQCQKMa0 < stringLength_uykoUaiftMGC - 1) {
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
        public void Energize(Thing1SetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: ThingSetValue
                if (o.ThingSetValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.ThingSetValue == null || o.ThingSetValue == null || o.ThingSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingSetValue.Count;
                int i_cIkZTMJocYuS;
                for (i_cIkZTMJocYuS = 0; i_cIkZTMJocYuS < 2; i_cIkZTMJocYuS++) {
                    if ((ulong)o.ThingSetValue.Count < vuBoundaries[i_cIkZTMJocYuS]) {
                       byteCount = (int)(i_cIkZTMJocYuS + 1);
                       goto guvsgoto_fqsRshd70Oei;
                    }
                }
                byteCount = (int)i_cIkZTMJocYuS + 1;
                guvsgoto_fqsRshd70Oei:
                    for (int i_mU8Tw15HKdxO = 0; i_mU8Tw15HKdxO < byteCount; i_mU8Tw15HKdxO++) {
                        if (i_mU8Tw15HKdxO < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_mU8Tw15HKdxO < byteCount - 1) {
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
                foreach (Thing1 finalObject in o.ThingSetValue) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
                }
        }
        public void Energize(AbstractThingSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: AbstractThingSetValue
                if (o.AbstractThingSetValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.AbstractThingSetValue == null || o.AbstractThingSetValue == null || o.AbstractThingSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.AbstractThingSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.AbstractThingSetValue.Count;
                int i_nN68dWXy5JnH;
                for (i_nN68dWXy5JnH = 0; i_nN68dWXy5JnH < 2; i_nN68dWXy5JnH++) {
                    if ((ulong)o.AbstractThingSetValue.Count < vuBoundaries[i_nN68dWXy5JnH]) {
                       byteCount = (int)(i_nN68dWXy5JnH + 1);
                       goto guvsgoto_elLUohm9pN5R;
                    }
                }
                byteCount = (int)i_nN68dWXy5JnH + 1;
                guvsgoto_elLUohm9pN5R:
                    for (int i_dtL8THIckGOH = 0; i_dtL8THIckGOH < byteCount; i_dtL8THIckGOH++) {
                        if (i_dtL8THIckGOH < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dtL8THIckGOH < byteCount - 1) {
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
                foreach (ISetTestObject abstractObject in o.AbstractThingSetValue) {
                    Energize((ISetTestObject)abstractObject, bytes, ref index, true);
                }
            }
                }
        }
        public void Energize(VIntSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: VintSetValue
                if (o.VintSetValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.VintSetValue == null || o.VintSetValue == null || o.VintSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintSetValue.Count;
                int i_x7EXq8SM8dM4;
                for (i_x7EXq8SM8dM4 = 0; i_x7EXq8SM8dM4 < 2; i_x7EXq8SM8dM4++) {
                    if ((ulong)o.VintSetValue.Count < vuBoundaries[i_x7EXq8SM8dM4]) {
                       byteCount = (int)(i_x7EXq8SM8dM4 + 1);
                       goto guvsgoto_aY95LvDZZrnS;
                    }
                }
                byteCount = (int)i_x7EXq8SM8dM4 + 1;
                guvsgoto_aY95LvDZZrnS:
                    for (int i_nnpSf3G98z7o = 0; i_nnpSf3G98z7o < byteCount; i_nnpSf3G98z7o++) {
                        if (i_nnpSf3G98z7o < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_nnpSf3G98z7o < byteCount - 1) {
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
                foreach (int primitive in o.VintSetValue) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_u2WJgxS1g3dV = primitive;
    if (s2ultemp_u2WJgxS1g3dV == long.MinValue) {
        s2ultemp_u2WJgxS1g3dV = long.MaxValue;
    }
    else {
        if (s2ultemp_u2WJgxS1g3dV > 0) {
            s2ultemp_u2WJgxS1g3dV = -s2ultemp_u2WJgxS1g3dV;
        }
        s2ultemp_u2WJgxS1g3dV -= 1;
    }
    s2ultemp_u2WJgxS1g3dV = ~s2ultemp_u2WJgxS1g3dV;
    ulong s2ulresult_bUVlYcJ6mfzy = (ulong)s2ultemp_u2WJgxS1g3dV;
    //// AppendGetSignVariantSize(s2ulresult_bUVlYcJ6mfzy)
    byte vr_cUU6UoUF9qay = 1;
    for (int v_fiFLvVYMkEPu = 56; v_fiFLvVYMkEPu >= 0; v_fiFLvVYMkEPu -= 8) {
        if (((255UL << v_fiFLvVYMkEPu) & s2ulresult_bUVlYcJ6mfzy) > 0) {
            vr_cUU6UoUF9qay = (byte)(v_fiFLvVYMkEPu / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_cUU6UoUF9qay << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_dvl60bbRCyEv = 0; vi_dvl60bbRCyEv < vr_cUU6UoUF9qay - 1; vi_dvl60bbRCyEv++) {
        bytes[index++] = (byte)(s2ulresult_bUVlYcJ6mfzy & 255);
        s2ulresult_bUVlYcJ6mfzy = s2ulresult_bUVlYcJ6mfzy >> 8;
    }
                }
            }
                }
        }
        public void Energize(ISetTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
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
                    Energize((IntSetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((StringSetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((Thing1SetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((AbstractThingSetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((VIntSetObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_qWg1jHVWUx9P = 0;
                    for (int i_n8KBrWnLfzYz = 0; i_n8KBrWnLfzYz < 9; i_n8KBrWnLfzYz++) {
                        byte b = bytes[index++];
                        if (i_n8KBrWnLfzYz < 8) {
                            vuread_qWg1jHVWUx9P += (((ulong)b & (ulong)127) << (7 * i_n8KBrWnLfzYz));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qWg1jHVWUx9P += (ulong)b << (7 * i_n8KBrWnLfzYz);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_qWg1jHVWUx9P;
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
                IntSetObject o = this.instantiator.AcquireIntSetObject();
                nullFlagsIndex++;
                // SET: IntSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_bXP8ot5XOk8J;
                    ulong vuread_q6DMS2KTvFz1 = 0;
                    for (int i_lKAQk2qm7RYv = 0; i_lKAQk2qm7RYv < 9; i_lKAQk2qm7RYv++) {
                        byte b = bytes[index++];
                        if (i_lKAQk2qm7RYv < 8) {
                            vuread_q6DMS2KTvFz1 += (((ulong)b & (ulong)127) << (7 * i_lKAQk2qm7RYv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_q6DMS2KTvFz1 += (ulong)b << (7 * i_lKAQk2qm7RYv);
                            break;
                        }
                    }
                    count_bXP8ot5XOk8J = (ushort)vuread_q6DMS2KTvFz1;
            // Read list items
            if (count_bXP8ot5XOk8J > 0) {
                o.IntSetValue = this.instantiator.AcquireHashSetOfInt();
                int listValue_wWIBCmbw9bXu;
                for (int i_iL2mZfeIxXIO = 0; i_iL2mZfeIxXIO < count_bXP8ot5XOk8J; i_iL2mZfeIxXIO++) {
                    // Read Int list item
                listValue_wWIBCmbw9bXu =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_wWIBCmbw9bXu);
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
                StringSetObject o = this.instantiator.AcquireStringSetObject();
                nullFlagsIndex++;
                // SET: StringSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_wpMW3VL7iiU5;
                    ulong vuread_ijrjEd1yWfxJ = 0;
                    for (int i_zex2Mq7do3In = 0; i_zex2Mq7do3In < 9; i_zex2Mq7do3In++) {
                        byte b = bytes[index++];
                        if (i_zex2Mq7do3In < 8) {
                            vuread_ijrjEd1yWfxJ += (((ulong)b & (ulong)127) << (7 * i_zex2Mq7do3In));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ijrjEd1yWfxJ += (ulong)b << (7 * i_zex2Mq7do3In);
                            break;
                        }
                    }
                    count_wpMW3VL7iiU5 = (ushort)vuread_ijrjEd1yWfxJ;
            // Read list items
            if (count_wpMW3VL7iiU5 > 0) {
                o.StringSetValue = this.instantiator.AcquireHashSetOfString();
                string listValue_ooCoAZmk071Q;
                for (int i_u4du6j1X2cWZ = 0; i_u4du6j1X2cWZ < count_wpMW3VL7iiU5; i_u4du6j1X2cWZ++) {
                    // Read String list item
                    ulong vuread_pN872mTcmQeS = 0;
                    for (int i_fNhecVvHCN0R = 0; i_fNhecVvHCN0R < 9; i_fNhecVvHCN0R++) {
                        byte b = bytes[index++];
                        if (i_fNhecVvHCN0R < 8) {
                            vuread_pN872mTcmQeS += (((ulong)b & (ulong)127) << (7 * i_fNhecVvHCN0R));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pN872mTcmQeS += (ulong)b << (7 * i_fNhecVvHCN0R);
                            break;
                        }
                    }
                    ushort stringLength_kTu1kQRAKdJp = (ushort)vuread_pN872mTcmQeS;
                listValue_ooCoAZmk071Q = Encoding.UTF8.GetString(bytes, index, stringLength_kTu1kQRAKdJp);
                index += stringLength_kTu1kQRAKdJp;
                    o.StringSetValue.Add(listValue_ooCoAZmk071Q);
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
                Thing1SetObject o = this.instantiator.AcquireThing1SetObject();
                nullFlagsIndex++;
                // SET: ThingSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_nuajqAgTvYTs;
                    ulong vuread_e44QsUNROMPG = 0;
                    for (int i_oMyZScX7XrBI = 0; i_oMyZScX7XrBI < 9; i_oMyZScX7XrBI++) {
                        byte b = bytes[index++];
                        if (i_oMyZScX7XrBI < 8) {
                            vuread_e44QsUNROMPG += (((ulong)b & (ulong)127) << (7 * i_oMyZScX7XrBI));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_e44QsUNROMPG += (ulong)b << (7 * i_oMyZScX7XrBI);
                            break;
                        }
                    }
                    count_nuajqAgTvYTs = (ushort)vuread_e44QsUNROMPG;
            // Read list items
            if (count_nuajqAgTvYTs > 0) {
                o.ThingSetValue = this.instantiator.AcquireHashSetOfThing1();
                for (int li_eKWVKuxy3Y3h = 0; li_eKWVKuxy3Y3h < count_nuajqAgTvYTs; li_eKWVKuxy3Y3h++) {
                    o.ThingSetValue.Add((Thing1)Energize(bytes, ref index, 10));
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
                AbstractThingSetObject o = this.instantiator.AcquireAbstractThingSetObject();
                nullFlagsIndex++;
                // SET: AbstractThingSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_wPoRaic3PDKN;
                    ulong vuread_aqbsbWF4CvES = 0;
                    for (int i_z1htpqMUSr8d = 0; i_z1htpqMUSr8d < 9; i_z1htpqMUSr8d++) {
                        byte b = bytes[index++];
                        if (i_z1htpqMUSr8d < 8) {
                            vuread_aqbsbWF4CvES += (((ulong)b & (ulong)127) << (7 * i_z1htpqMUSr8d));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_aqbsbWF4CvES += (ulong)b << (7 * i_z1htpqMUSr8d);
                            break;
                        }
                    }
                    count_wPoRaic3PDKN = (ushort)vuread_aqbsbWF4CvES;
            // Read list items
            if (count_wPoRaic3PDKN > 0) {
                o.AbstractThingSetValue = this.instantiator.AcquireHashSetOfAbstractThing();
                for (int li_vf6PoI2R9iTt = 0; li_vf6PoI2R9iTt < count_wPoRaic3PDKN; li_vf6PoI2R9iTt++) {
                    o.AbstractThingSetValue.Add((AbstractThing)Energize(bytes, ref index));
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
                VIntSetObject o = this.instantiator.AcquireVIntSetObject();
                nullFlagsIndex++;
                // SET: VintSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_iexht9PEkFTi;
                    ulong vuread_aTNy005Us7D5 = 0;
                    for (int i_v0P3CWT0iXak = 0; i_v0P3CWT0iXak < 9; i_v0P3CWT0iXak++) {
                        byte b = bytes[index++];
                        if (i_v0P3CWT0iXak < 8) {
                            vuread_aTNy005Us7D5 += (((ulong)b & (ulong)127) << (7 * i_v0P3CWT0iXak));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_aTNy005Us7D5 += (ulong)b << (7 * i_v0P3CWT0iXak);
                            break;
                        }
                    }
                    count_iexht9PEkFTi = (ushort)vuread_aTNy005Us7D5;
            // Read list items
            if (count_iexht9PEkFTi > 0) {
                o.VintSetValue = this.instantiator.AcquireHashSetOfInt();
                int listValue_xFASLD2twYOF;
                for (int i_xE1jm8bvKBrC = 0; i_xE1jm8bvKBrC < count_iexht9PEkFTi; i_xE1jm8bvKBrC++) {
                    // Read VInt list item
    byte rvint_b_iVcyV29mSDFv = bytes[index++];
    byte rvint_sign_kmjYfkJblj88 = (byte)(rvint_b_iVcyV29mSDFv & 1);
    byte rvint_size_xJNkWOJBn7y0 = (byte)(rvint_b_iVcyV29mSDFv >> 1);
    ulong rvint_remaining_lEHDYCWB9GTa = 0;
    for (int i_vnqA1qrkWdCl = 0; i_vnqA1qrkWdCl < rvint_size_xJNkWOJBn7y0 - 1; i_vnqA1qrkWdCl++) {
        rvint_remaining_lEHDYCWB9GTa = rvint_remaining_lEHDYCWB9GTa | (((ulong)bytes[index++] << (8 * i_vnqA1qrkWdCl)));
    }
    int rvint_result_gZAe3dhCXswK = (int)rvint_remaining_lEHDYCWB9GTa;
    rvint_result_gZAe3dhCXswK = ~rvint_result_gZAe3dhCXswK;
    if (rvint_result_gZAe3dhCXswK == int.MaxValue) {
        rvint_result_gZAe3dhCXswK = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_gZAe3dhCXswK += 1;
        if (rvint_sign_kmjYfkJblj88 == 0) {
            rvint_result_gZAe3dhCXswK = -rvint_result_gZAe3dhCXswK;
        }
    }
    listValue_xFASLD2twYOF = rvint_result_gZAe3dhCXswK;
                    o.VintSetValue.Add(listValue_xFASLD2twYOF);
                }
            }
                }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_qgmTxH9y0NuJ = 0;
                    for (int i_kjK7Qodxbvo8 = 0; i_kjK7Qodxbvo8 < 9; i_kjK7Qodxbvo8++) {
                        byte b = bytes[index++];
                        if (i_kjK7Qodxbvo8 < 8) {
                            vuread_qgmTxH9y0NuJ += (((ulong)b & (ulong)127) << (7 * i_kjK7Qodxbvo8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qgmTxH9y0NuJ += (ulong)b << (7 * i_kjK7Qodxbvo8);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_qgmTxH9y0NuJ;
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
                IntSetObject o = this.instantiator.AcquireIntSetObject();
                nullFlagsIndex++;
                // SET: IntSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_aSH6zrmG0PXV;
                    ulong vuread_bHXpeevKF1QU = 0;
                    for (int i_mjVJo9Jr1nSP = 0; i_mjVJo9Jr1nSP < 9; i_mjVJo9Jr1nSP++) {
                        byte b = bytes[index++];
                        if (i_mjVJo9Jr1nSP < 8) {
                            vuread_bHXpeevKF1QU += (((ulong)b & (ulong)127) << (7 * i_mjVJo9Jr1nSP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bHXpeevKF1QU += (ulong)b << (7 * i_mjVJo9Jr1nSP);
                            break;
                        }
                    }
                    count_aSH6zrmG0PXV = (ushort)vuread_bHXpeevKF1QU;
            // Read list items
            if (count_aSH6zrmG0PXV > 0) {
                o.IntSetValue = this.instantiator.AcquireHashSetOfInt();
                int listValue_zc9JBXSSvY3j;
                for (int i_lYt7aNDkbXDp = 0; i_lYt7aNDkbXDp < count_aSH6zrmG0PXV; i_lYt7aNDkbXDp++) {
                    // Read Int list item
                listValue_zc9JBXSSvY3j =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_zc9JBXSSvY3j);
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
                StringSetObject o = this.instantiator.AcquireStringSetObject();
                nullFlagsIndex++;
                // SET: StringSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_nMs1gG3ZZipb;
                    ulong vuread_bWjRi8zOqMiz = 0;
                    for (int i_rLroUHNlJUdZ = 0; i_rLroUHNlJUdZ < 9; i_rLroUHNlJUdZ++) {
                        byte b = bytes[index++];
                        if (i_rLroUHNlJUdZ < 8) {
                            vuread_bWjRi8zOqMiz += (((ulong)b & (ulong)127) << (7 * i_rLroUHNlJUdZ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bWjRi8zOqMiz += (ulong)b << (7 * i_rLroUHNlJUdZ);
                            break;
                        }
                    }
                    count_nMs1gG3ZZipb = (ushort)vuread_bWjRi8zOqMiz;
            // Read list items
            if (count_nMs1gG3ZZipb > 0) {
                o.StringSetValue = this.instantiator.AcquireHashSetOfString();
                string listValue_n1LY5dusJr3o;
                for (int i_mWccyY93D2lE = 0; i_mWccyY93D2lE < count_nMs1gG3ZZipb; i_mWccyY93D2lE++) {
                    // Read String list item
                    ulong vuread_jKTmsZ0ySdU7 = 0;
                    for (int i_nLXVVkvNQhJq = 0; i_nLXVVkvNQhJq < 9; i_nLXVVkvNQhJq++) {
                        byte b = bytes[index++];
                        if (i_nLXVVkvNQhJq < 8) {
                            vuread_jKTmsZ0ySdU7 += (((ulong)b & (ulong)127) << (7 * i_nLXVVkvNQhJq));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jKTmsZ0ySdU7 += (ulong)b << (7 * i_nLXVVkvNQhJq);
                            break;
                        }
                    }
                    ushort stringLength_gPfrEdBtStlq = (ushort)vuread_jKTmsZ0ySdU7;
                listValue_n1LY5dusJr3o = Encoding.UTF8.GetString(bytes, index, stringLength_gPfrEdBtStlq);
                index += stringLength_gPfrEdBtStlq;
                    o.StringSetValue.Add(listValue_n1LY5dusJr3o);
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
                Thing1SetObject o = this.instantiator.AcquireThing1SetObject();
                nullFlagsIndex++;
                // SET: ThingSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_zcYFZJFkLVPY;
                    ulong vuread_cWLObXVm4iW2 = 0;
                    for (int i_gQIH8HJpaDop = 0; i_gQIH8HJpaDop < 9; i_gQIH8HJpaDop++) {
                        byte b = bytes[index++];
                        if (i_gQIH8HJpaDop < 8) {
                            vuread_cWLObXVm4iW2 += (((ulong)b & (ulong)127) << (7 * i_gQIH8HJpaDop));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cWLObXVm4iW2 += (ulong)b << (7 * i_gQIH8HJpaDop);
                            break;
                        }
                    }
                    count_zcYFZJFkLVPY = (ushort)vuread_cWLObXVm4iW2;
            // Read list items
            if (count_zcYFZJFkLVPY > 0) {
                o.ThingSetValue = this.instantiator.AcquireHashSetOfThing1();
                for (int li_avIjHJvT59Q8 = 0; li_avIjHJvT59Q8 < count_zcYFZJFkLVPY; li_avIjHJvT59Q8++) {
                    o.ThingSetValue.Add((Thing1)Energize(bytes, ref index, 10));
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
                AbstractThingSetObject o = this.instantiator.AcquireAbstractThingSetObject();
                nullFlagsIndex++;
                // SET: AbstractThingSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_oRM3vxvZq5pj;
                    ulong vuread_a7mdlAXLIvNP = 0;
                    for (int i_gMPvWc7q9K8r = 0; i_gMPvWc7q9K8r < 9; i_gMPvWc7q9K8r++) {
                        byte b = bytes[index++];
                        if (i_gMPvWc7q9K8r < 8) {
                            vuread_a7mdlAXLIvNP += (((ulong)b & (ulong)127) << (7 * i_gMPvWc7q9K8r));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_a7mdlAXLIvNP += (ulong)b << (7 * i_gMPvWc7q9K8r);
                            break;
                        }
                    }
                    count_oRM3vxvZq5pj = (ushort)vuread_a7mdlAXLIvNP;
            // Read list items
            if (count_oRM3vxvZq5pj > 0) {
                o.AbstractThingSetValue = this.instantiator.AcquireHashSetOfAbstractThing();
                for (int li_xQ4Niy9egyhJ = 0; li_xQ4Niy9egyhJ < count_oRM3vxvZq5pj; li_xQ4Niy9egyhJ++) {
                    o.AbstractThingSetValue.Add((AbstractThing)Energize(bytes, ref index));
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
                VIntSetObject o = this.instantiator.AcquireVIntSetObject();
                nullFlagsIndex++;
                // SET: VintSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_jrHFmfznd6OT;
                    ulong vuread_s9dn88kB85jF = 0;
                    for (int i_njCkwIJ0Ef8E = 0; i_njCkwIJ0Ef8E < 9; i_njCkwIJ0Ef8E++) {
                        byte b = bytes[index++];
                        if (i_njCkwIJ0Ef8E < 8) {
                            vuread_s9dn88kB85jF += (((ulong)b & (ulong)127) << (7 * i_njCkwIJ0Ef8E));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_s9dn88kB85jF += (ulong)b << (7 * i_njCkwIJ0Ef8E);
                            break;
                        }
                    }
                    count_jrHFmfznd6OT = (ushort)vuread_s9dn88kB85jF;
            // Read list items
            if (count_jrHFmfznd6OT > 0) {
                o.VintSetValue = this.instantiator.AcquireHashSetOfInt();
                int listValue_mCe3kVn8bk5i;
                for (int i_iVghnQKBic9c = 0; i_iVghnQKBic9c < count_jrHFmfznd6OT; i_iVghnQKBic9c++) {
                    // Read VInt list item
    byte rvint_b_qp0FwYoMbJTG = bytes[index++];
    byte rvint_sign_xqqnSkDvnuZL = (byte)(rvint_b_qp0FwYoMbJTG & 1);
    byte rvint_size_lCMXEGvCCbr5 = (byte)(rvint_b_qp0FwYoMbJTG >> 1);
    ulong rvint_remaining_xRLn6thVcKm7 = 0;
    for (int i_kxT8IOYszpd4 = 0; i_kxT8IOYszpd4 < rvint_size_lCMXEGvCCbr5 - 1; i_kxT8IOYszpd4++) {
        rvint_remaining_xRLn6thVcKm7 = rvint_remaining_xRLn6thVcKm7 | (((ulong)bytes[index++] << (8 * i_kxT8IOYszpd4)));
    }
    int rvint_result_eAhEnrd29vsa = (int)rvint_remaining_xRLn6thVcKm7;
    rvint_result_eAhEnrd29vsa = ~rvint_result_eAhEnrd29vsa;
    if (rvint_result_eAhEnrd29vsa == int.MaxValue) {
        rvint_result_eAhEnrd29vsa = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_eAhEnrd29vsa += 1;
        if (rvint_sign_xqqnSkDvnuZL == 0) {
            rvint_result_eAhEnrd29vsa = -rvint_result_eAhEnrd29vsa;
        }
    }
    listValue_mCe3kVn8bk5i = rvint_result_eAhEnrd29vsa;
                    o.VintSetValue.Add(listValue_mCe3kVn8bk5i);
                }
            }
                }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
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
                IntSetObject o = this.instantiator.AcquireIntSetObject();
                nullFlagsIndex++;
                // SET: IntSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_oqy4mdJ1pPxh;
                    ulong vuread_ux3Ym8FPORbF = 0;
                    for (int i_eMIVGu8eeTyr = 0; i_eMIVGu8eeTyr < 9; i_eMIVGu8eeTyr++) {
                        byte b = bytes[index++];
                        if (i_eMIVGu8eeTyr < 8) {
                            vuread_ux3Ym8FPORbF += (((ulong)b & (ulong)127) << (7 * i_eMIVGu8eeTyr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ux3Ym8FPORbF += (ulong)b << (7 * i_eMIVGu8eeTyr);
                            break;
                        }
                    }
                    count_oqy4mdJ1pPxh = (ushort)vuread_ux3Ym8FPORbF;
            // Read list items
            if (count_oqy4mdJ1pPxh > 0) {
                o.IntSetValue = this.instantiator.AcquireHashSetOfInt();
                int listValue_g4fwQlOGc9S0;
                for (int i_joQaZNv2o2TK = 0; i_joQaZNv2o2TK < count_oqy4mdJ1pPxh; i_joQaZNv2o2TK++) {
                    // Read Int list item
                listValue_g4fwQlOGc9S0 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_g4fwQlOGc9S0);
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
                StringSetObject o = this.instantiator.AcquireStringSetObject();
                nullFlagsIndex++;
                // SET: StringSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_nYu5Qtcc8LJs;
                    ulong vuread_xj8CcFDl3Sxs = 0;
                    for (int i_q8pByGdxkF12 = 0; i_q8pByGdxkF12 < 9; i_q8pByGdxkF12++) {
                        byte b = bytes[index++];
                        if (i_q8pByGdxkF12 < 8) {
                            vuread_xj8CcFDl3Sxs += (((ulong)b & (ulong)127) << (7 * i_q8pByGdxkF12));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xj8CcFDl3Sxs += (ulong)b << (7 * i_q8pByGdxkF12);
                            break;
                        }
                    }
                    count_nYu5Qtcc8LJs = (ushort)vuread_xj8CcFDl3Sxs;
            // Read list items
            if (count_nYu5Qtcc8LJs > 0) {
                o.StringSetValue = this.instantiator.AcquireHashSetOfString();
                string listValue_wTZT7P1VPxgQ;
                for (int i_q20TzHQWAcrS = 0; i_q20TzHQWAcrS < count_nYu5Qtcc8LJs; i_q20TzHQWAcrS++) {
                    // Read String list item
                    ulong vuread_rToo0MMq1IXF = 0;
                    for (int i_ru7NYeCYBhPv = 0; i_ru7NYeCYBhPv < 9; i_ru7NYeCYBhPv++) {
                        byte b = bytes[index++];
                        if (i_ru7NYeCYBhPv < 8) {
                            vuread_rToo0MMq1IXF += (((ulong)b & (ulong)127) << (7 * i_ru7NYeCYBhPv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rToo0MMq1IXF += (ulong)b << (7 * i_ru7NYeCYBhPv);
                            break;
                        }
                    }
                    ushort stringLength_bLOCIlhysgMt = (ushort)vuread_rToo0MMq1IXF;
                listValue_wTZT7P1VPxgQ = Encoding.UTF8.GetString(bytes, index, stringLength_bLOCIlhysgMt);
                index += stringLength_bLOCIlhysgMt;
                    o.StringSetValue.Add(listValue_wTZT7P1VPxgQ);
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
                Thing1SetObject o = this.instantiator.AcquireThing1SetObject();
                nullFlagsIndex++;
                // SET: ThingSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_azmDqSyIqHdQ;
                    ulong vuread_iC6XAb0EYiWo = 0;
                    for (int i_gEJnOX1Hd2nB = 0; i_gEJnOX1Hd2nB < 9; i_gEJnOX1Hd2nB++) {
                        byte b = bytes[index++];
                        if (i_gEJnOX1Hd2nB < 8) {
                            vuread_iC6XAb0EYiWo += (((ulong)b & (ulong)127) << (7 * i_gEJnOX1Hd2nB));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iC6XAb0EYiWo += (ulong)b << (7 * i_gEJnOX1Hd2nB);
                            break;
                        }
                    }
                    count_azmDqSyIqHdQ = (ushort)vuread_iC6XAb0EYiWo;
            // Read list items
            if (count_azmDqSyIqHdQ > 0) {
                o.ThingSetValue = this.instantiator.AcquireHashSetOfThing1();
                for (int li_kiaikopiqrtw = 0; li_kiaikopiqrtw < count_azmDqSyIqHdQ; li_kiaikopiqrtw++) {
                    o.ThingSetValue.Add((Thing1)Energize(bytes, ref index, 10));
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
                AbstractThingSetObject o = this.instantiator.AcquireAbstractThingSetObject();
                nullFlagsIndex++;
                // SET: AbstractThingSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_dOxArlH2M8pV;
                    ulong vuread_dk4CPGMAoEyr = 0;
                    for (int i_aRtJ2N76knf9 = 0; i_aRtJ2N76knf9 < 9; i_aRtJ2N76knf9++) {
                        byte b = bytes[index++];
                        if (i_aRtJ2N76knf9 < 8) {
                            vuread_dk4CPGMAoEyr += (((ulong)b & (ulong)127) << (7 * i_aRtJ2N76knf9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dk4CPGMAoEyr += (ulong)b << (7 * i_aRtJ2N76knf9);
                            break;
                        }
                    }
                    count_dOxArlH2M8pV = (ushort)vuread_dk4CPGMAoEyr;
            // Read list items
            if (count_dOxArlH2M8pV > 0) {
                o.AbstractThingSetValue = this.instantiator.AcquireHashSetOfAbstractThing();
                for (int li_kAq2uuYB3o9a = 0; li_kAq2uuYB3o9a < count_dOxArlH2M8pV; li_kAq2uuYB3o9a++) {
                    o.AbstractThingSetValue.Add((AbstractThing)Energize(bytes, ref index));
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
                VIntSetObject o = this.instantiator.AcquireVIntSetObject();
                nullFlagsIndex++;
                // SET: VintSetValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_iXDUO3hNqgzJ;
                    ulong vuread_w8a9asL5e4cp = 0;
                    for (int i_gUg4Q7yWRtof = 0; i_gUg4Q7yWRtof < 9; i_gUg4Q7yWRtof++) {
                        byte b = bytes[index++];
                        if (i_gUg4Q7yWRtof < 8) {
                            vuread_w8a9asL5e4cp += (((ulong)b & (ulong)127) << (7 * i_gUg4Q7yWRtof));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_w8a9asL5e4cp += (ulong)b << (7 * i_gUg4Q7yWRtof);
                            break;
                        }
                    }
                    count_iXDUO3hNqgzJ = (ushort)vuread_w8a9asL5e4cp;
            // Read list items
            if (count_iXDUO3hNqgzJ > 0) {
                o.VintSetValue = this.instantiator.AcquireHashSetOfInt();
                int listValue_ensrgCTtbRbv;
                for (int i_iYAKMe6AVnE4 = 0; i_iYAKMe6AVnE4 < count_iXDUO3hNqgzJ; i_iYAKMe6AVnE4++) {
                    // Read VInt list item
    byte rvint_b_um6tSM1HU4ZW = bytes[index++];
    byte rvint_sign_auZLlSoITUK1 = (byte)(rvint_b_um6tSM1HU4ZW & 1);
    byte rvint_size_nXjNwXt6TxE3 = (byte)(rvint_b_um6tSM1HU4ZW >> 1);
    ulong rvint_remaining_nALyZDLz9NKs = 0;
    for (int i_gupc96ldMfW4 = 0; i_gupc96ldMfW4 < rvint_size_nXjNwXt6TxE3 - 1; i_gupc96ldMfW4++) {
        rvint_remaining_nALyZDLz9NKs = rvint_remaining_nALyZDLz9NKs | (((ulong)bytes[index++] << (8 * i_gupc96ldMfW4)));
    }
    int rvint_result_mol6L2dMZ6gU = (int)rvint_remaining_nALyZDLz9NKs;
    rvint_result_mol6L2dMZ6gU = ~rvint_result_mol6L2dMZ6gU;
    if (rvint_result_mol6L2dMZ6gU == int.MaxValue) {
        rvint_result_mol6L2dMZ6gU = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_mol6L2dMZ6gU += 1;
        if (rvint_sign_auZLlSoITUK1 == 0) {
            rvint_result_mol6L2dMZ6gU = -rvint_result_mol6L2dMZ6gU;
        }
    }
    listValue_ensrgCTtbRbv = rvint_result_mol6L2dMZ6gU;
                    o.VintSetValue.Add(listValue_ensrgCTtbRbv);
                }
            }
                }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new SetTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
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
        public void Reclaim(IntSetObject o) {
            if (o != null) {
                this.instantiator.DiscardIntSetObject(o);
            }
        }
        public void Reclaim(StringSetObject o) {
            if (o != null) {
                this.instantiator.DiscardStringSetObject(o);
            }
        }
        public void Reclaim(Thing1SetObject o) {
            if (o != null) {
                if (o.ThingSetValue != null) {
                    foreach (Thing1 e in o.ThingSetValue) {
                        this.Reclaim(e);
                    }
                    this.instantiator.DiscardHashSetOfThing1((HashSet<Thing1>)o.ThingSetValue);
                }
                this.instantiator.DiscardThing1SetObject(o);
            }
        }
        public void Reclaim(AbstractThingSetObject o) {
            if (o != null) {
                if (o.AbstractThingSetValue != null) {
                    foreach (AbstractThing e in o.AbstractThingSetValue) {
                        this.Reclaim(e);
                    }
                    this.instantiator.DiscardHashSetOfAbstractThing((HashSet<AbstractThing>)o.AbstractThingSetValue);
                }
                this.instantiator.DiscardAbstractThingSetObject(o);
            }
        }
        public void Reclaim(VIntSetObject o) {
            if (o != null) {
                this.instantiator.DiscardVIntSetObject(o);
            }
        }
    }
}
