
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Reference {
    public class ReferenceTestPatternBuffer {
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
        public ReferenceTestPatternBuffer() : this(4096) { }
        public ReferenceTestPatternBuffer(uint bufferSize) {
            this.bytes = new byte[bufferSize];
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(Thing o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FinalObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractThing o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FinalThing1 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FinalThing2 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractReferenceObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(Thing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // PRIMITIVE: IntValue
                bytes[index++] = (byte)((o.IntValue >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue & 255);
        }
        public void Energize(FinalObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // REFERENCE: ThingValue
                Energize(o.ThingValue, bytes, ref index, false);
        }
        public void Energize(AbstractThing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 0;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
        }
        public void Energize(FinalThing1 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 22;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue2a
                bytes[index++] = (byte)((o.IntValue2a >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2a & 255);
        }
        public void Energize(FinalThing2 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 23;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue2a
                bytes[index++] = (byte)((o.IntValue2a >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2a & 255);
        }
        public void Energize(AbstractReferenceObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 24;
            }
                // REFERENCE: Thing
                Energize((IReferenceTestObject)o.Thing, bytes, ref index, true);
        }
        public void Energize(IReferenceTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 11:
                    Energize((Thing)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((FinalObject)o, bytes, ref index, writeTypeId);
                    break;
                case 0:
                    Energize((AbstractThing)o, bytes, ref index, writeTypeId);
                    break;
                case 22:
                    Energize((FinalThing1)o, bytes, ref index, writeTypeId);
                    break;
                case 23:
                    Energize((FinalThing2)o, bytes, ref index, writeTypeId);
                    break;
                case 24:
                    Energize((AbstractReferenceObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_oDIlp1gAWDML = 0;
                    for (int i_sKjeFqT278hN = 0; i_sKjeFqT278hN < 9; i_sKjeFqT278hN++) {
                        byte b = bytes[index++];
                        if (i_sKjeFqT278hN < 8) {
                            vuread_oDIlp1gAWDML += (((ulong)b & (ulong)127) << (7 * i_sKjeFqT278hN));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oDIlp1gAWDML += (ulong)b << (7 * i_sKjeFqT278hN);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_oDIlp1gAWDML;
            switch (typeId) {
            case 11:
                {
                Thing o = new Thing();
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
            case 12:
                {
                FinalObject o = new FinalObject();
                // REFERENCE: ThingValue
                o.ThingValue = (Thing)Energize(bytes, ref index, 11);
                    return o;
                }
            case 0:
                {
                AbstractThing o = new AbstractThing();
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
            case 22:
                {
                FinalThing1 o = new FinalThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 23:
                {
                FinalThing2 o = new FinalThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 24:
                {
                AbstractReferenceObject o = new AbstractReferenceObject();
                // REFERENCE: Thing
                o.Thing = (AbstractThing)Energize(bytes, ref index);
                    return o;
                }
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_x9009gYT8KlL = 0;
                    for (int i_va1eK7Sgb1bl = 0; i_va1eK7Sgb1bl < 9; i_va1eK7Sgb1bl++) {
                        byte b = bytes[index++];
                        if (i_va1eK7Sgb1bl < 8) {
                            vuread_x9009gYT8KlL += (((ulong)b & (ulong)127) << (7 * i_va1eK7Sgb1bl));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_x9009gYT8KlL += (ulong)b << (7 * i_va1eK7Sgb1bl);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_x9009gYT8KlL;
            switch (typeId) {
            case 11:
                {
                Thing o = new Thing();
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
            case 12:
                {
                FinalObject o = new FinalObject();
                // REFERENCE: ThingValue
                o.ThingValue = (Thing)Energize(bytes, ref index, 11);
                    return o;
                }
            case 0:
                {
                AbstractThing o = new AbstractThing();
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
            case 22:
                {
                FinalThing1 o = new FinalThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 23:
                {
                FinalThing2 o = new FinalThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 24:
                {
                AbstractReferenceObject o = new AbstractReferenceObject();
                // REFERENCE: Thing
                o.Thing = (AbstractThing)Energize(bytes, ref index);
                    return o;
                }
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 11:
                {
                Thing o = new Thing();
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
            case 12:
                {
                FinalObject o = new FinalObject();
                // REFERENCE: ThingValue
                o.ThingValue = (Thing)Energize(bytes, ref index, 11);
                    return o;
                }
            case 0:
                {
                AbstractThing o = new AbstractThing();
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
            case 22:
                {
                FinalThing1 o = new FinalThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 23:
                {
                FinalThing2 o = new FinalThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 24:
                {
                AbstractReferenceObject o = new AbstractReferenceObject();
                // REFERENCE: Thing
                o.Thing = (AbstractThing)Energize(bytes, ref index);
                    return o;
                }
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new ReferenceTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
