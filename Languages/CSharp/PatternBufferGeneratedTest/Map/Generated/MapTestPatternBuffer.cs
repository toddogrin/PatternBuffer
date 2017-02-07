
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Map {
    public class MapTestPatternBuffer {
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
                "MyEnum",
                new Dictionary<byte,string>() {
                    {(byte)1, "value1"},
                    {(byte)2, "value2"},
                    {(byte)3, "value3"}
                }
            }
        };
        public static readonly Dictionary<string, Dictionary<string, byte>> enumValueIndexMap = new Dictionary<string, Dictionary<string, byte>> {
            {
                "MyEnum",
                new Dictionary<string,byte>() {
                    {"value1", (byte)1},
                    {"value2", (byte)2},
                    {"value3", (byte)3}
                }
            }
        };
        private byte[] bytes;
        public MapTestPatternBuffer() : this(4096) { }
        public MapTestPatternBuffer(uint bufferSize) {
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
        public byte[] Energize(IntThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingIntMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntStringMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumIntMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntVLongMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(Thing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 10;
            }
                // PRIMITIVE: IntValue
                bytes[index++] = (byte)((o.IntValue >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue & 255);
        }
        public void Energize(IntThingMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // MAP: IntThingMap
            if (o.IntThingMap.Keys == null || o.IntThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntThingMap.Keys.Count;
                int i_wxAEeGKPoVlb;
                for (i_wxAEeGKPoVlb = 0; i_wxAEeGKPoVlb < 2; i_wxAEeGKPoVlb++) {
                    if ((ulong)o.IntThingMap.Keys.Count < vuBoundaries[i_wxAEeGKPoVlb]) {
                       byteCount = (int)(i_wxAEeGKPoVlb + 1);
                       goto guvsgoto_dbDHzaYhh0oU;
                    }
                }
                byteCount = (int)i_wxAEeGKPoVlb + 1;
                guvsgoto_dbDHzaYhh0oU:
                    for (int i_aFJhfz5UaQdc = 0; i_aFJhfz5UaQdc < byteCount; i_aFJhfz5UaQdc++) {
                        if (i_aFJhfz5UaQdc < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_aFJhfz5UaQdc < byteCount - 1) {
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
                foreach (int primitive in o.IntThingMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntThingMap.Values == null || o.IntThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntThingMap.Values.Count;
                int i_w3U3OhmwZBF3;
                for (i_w3U3OhmwZBF3 = 0; i_w3U3OhmwZBF3 < 2; i_w3U3OhmwZBF3++) {
                    if ((ulong)o.IntThingMap.Values.Count < vuBoundaries[i_w3U3OhmwZBF3]) {
                       byteCount = (int)(i_w3U3OhmwZBF3 + 1);
                       goto guvsgoto_qVlLiEUiMm5B;
                    }
                }
                byteCount = (int)i_w3U3OhmwZBF3 + 1;
                guvsgoto_qVlLiEUiMm5B:
                    for (int i_lQcS5DUmuy1t = 0; i_lQcS5DUmuy1t < byteCount; i_lQcS5DUmuy1t++) {
                        if (i_lQcS5DUmuy1t < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lQcS5DUmuy1t < byteCount - 1) {
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
                foreach (Thing finalObject in o.IntThingMap.Values) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
        }
        public void Energize(ThingIntMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // MAP: ThingIntMap
            if (o.ThingIntMap.Keys == null || o.ThingIntMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingIntMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingIntMap.Keys.Count;
                int i_qcg2DQmlpskB;
                for (i_qcg2DQmlpskB = 0; i_qcg2DQmlpskB < 2; i_qcg2DQmlpskB++) {
                    if ((ulong)o.ThingIntMap.Keys.Count < vuBoundaries[i_qcg2DQmlpskB]) {
                       byteCount = (int)(i_qcg2DQmlpskB + 1);
                       goto guvsgoto_i8HTaczZKhpl;
                    }
                }
                byteCount = (int)i_qcg2DQmlpskB + 1;
                guvsgoto_i8HTaczZKhpl:
                    for (int i_lbniBThDcBIQ = 0; i_lbniBThDcBIQ < byteCount; i_lbniBThDcBIQ++) {
                        if (i_lbniBThDcBIQ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lbniBThDcBIQ < byteCount - 1) {
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
                foreach (Thing finalObject in o.ThingIntMap.Keys) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
            if (o.ThingIntMap.Values == null || o.ThingIntMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingIntMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingIntMap.Values.Count;
                int i_j1SNmPdcYfr9;
                for (i_j1SNmPdcYfr9 = 0; i_j1SNmPdcYfr9 < 2; i_j1SNmPdcYfr9++) {
                    if ((ulong)o.ThingIntMap.Values.Count < vuBoundaries[i_j1SNmPdcYfr9]) {
                       byteCount = (int)(i_j1SNmPdcYfr9 + 1);
                       goto guvsgoto_pCwWcQtuA0e3;
                    }
                }
                byteCount = (int)i_j1SNmPdcYfr9 + 1;
                guvsgoto_pCwWcQtuA0e3:
                    for (int i_vqy1aWimDzsa = 0; i_vqy1aWimDzsa < byteCount; i_vqy1aWimDzsa++) {
                        if (i_vqy1aWimDzsa < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_vqy1aWimDzsa < byteCount - 1) {
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
                foreach (int primitive in o.ThingIntMap.Values) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(IntStringMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // MAP: IntStringMap
            if (o.IntStringMap.Keys == null || o.IntStringMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntStringMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntStringMap.Keys.Count;
                int i_aDrxyF2Elw7V;
                for (i_aDrxyF2Elw7V = 0; i_aDrxyF2Elw7V < 2; i_aDrxyF2Elw7V++) {
                    if ((ulong)o.IntStringMap.Keys.Count < vuBoundaries[i_aDrxyF2Elw7V]) {
                       byteCount = (int)(i_aDrxyF2Elw7V + 1);
                       goto guvsgoto_iziJ80aL7tUJ;
                    }
                }
                byteCount = (int)i_aDrxyF2Elw7V + 1;
                guvsgoto_iziJ80aL7tUJ:
                    for (int i_hBuOS1z7JRtW = 0; i_hBuOS1z7JRtW < byteCount; i_hBuOS1z7JRtW++) {
                        if (i_hBuOS1z7JRtW < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_hBuOS1z7JRtW < byteCount - 1) {
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
                foreach (int primitive in o.IntStringMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntStringMap.Values == null || o.IntStringMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntStringMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntStringMap.Values.Count;
                int i_nVY8HYY7CxrH;
                for (i_nVY8HYY7CxrH = 0; i_nVY8HYY7CxrH < 2; i_nVY8HYY7CxrH++) {
                    if ((ulong)o.IntStringMap.Values.Count < vuBoundaries[i_nVY8HYY7CxrH]) {
                       byteCount = (int)(i_nVY8HYY7CxrH + 1);
                       goto guvsgoto_nEd7fPcFGY0G;
                    }
                }
                byteCount = (int)i_nVY8HYY7CxrH + 1;
                guvsgoto_nEd7fPcFGY0G:
                    for (int i_nw3f4WatjE04 = 0; i_nw3f4WatjE04 < byteCount; i_nw3f4WatjE04++) {
                        if (i_nw3f4WatjE04 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_nw3f4WatjE04 < byteCount - 1) {
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
                foreach (string primitive in o.IntStringMap.Values) {
                uint stringLength_l4yGuBpDKXi6;
                int i_u7LTYHwb44HN;
                for (i_u7LTYHwb44HN = 0; i_u7LTYHwb44HN < 2; i_u7LTYHwb44HN++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_u7LTYHwb44HN]) {
                       stringLength_l4yGuBpDKXi6 = (uint)(i_u7LTYHwb44HN + 1);
                       goto guvsgoto_bAAU2vujmGBT;
                    }
                }
                stringLength_l4yGuBpDKXi6 = (uint)i_u7LTYHwb44HN + 1;
                guvsgoto_bAAU2vujmGBT:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_lsNbhX6Sn6cD = 0; i_lsNbhX6Sn6cD < stringLength_l4yGuBpDKXi6; i_lsNbhX6Sn6cD++) {
                        if (i_lsNbhX6Sn6cD < stringLength_l4yGuBpDKXi6 - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lsNbhX6Sn6cD < stringLength_l4yGuBpDKXi6 - 1) {
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
        public void Energize(ThingThingMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // MAP: ThingThingMap
            if (o.ThingThingMap.Keys == null || o.ThingThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingThingMap.Keys.Count;
                int i_vFOdAhci3XtK;
                for (i_vFOdAhci3XtK = 0; i_vFOdAhci3XtK < 2; i_vFOdAhci3XtK++) {
                    if ((ulong)o.ThingThingMap.Keys.Count < vuBoundaries[i_vFOdAhci3XtK]) {
                       byteCount = (int)(i_vFOdAhci3XtK + 1);
                       goto guvsgoto_jqAYkRR4COTx;
                    }
                }
                byteCount = (int)i_vFOdAhci3XtK + 1;
                guvsgoto_jqAYkRR4COTx:
                    for (int i_stbzKTG04ixI = 0; i_stbzKTG04ixI < byteCount; i_stbzKTG04ixI++) {
                        if (i_stbzKTG04ixI < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_stbzKTG04ixI < byteCount - 1) {
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
                foreach (Thing finalObject in o.ThingThingMap.Keys) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
            if (o.ThingThingMap.Values == null || o.ThingThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingThingMap.Values.Count;
                int i_d3rf34JJ60g1;
                for (i_d3rf34JJ60g1 = 0; i_d3rf34JJ60g1 < 2; i_d3rf34JJ60g1++) {
                    if ((ulong)o.ThingThingMap.Values.Count < vuBoundaries[i_d3rf34JJ60g1]) {
                       byteCount = (int)(i_d3rf34JJ60g1 + 1);
                       goto guvsgoto_dI0nnNkVIqlM;
                    }
                }
                byteCount = (int)i_d3rf34JJ60g1 + 1;
                guvsgoto_dI0nnNkVIqlM:
                    for (int i_rrtTi3CQhg52 = 0; i_rrtTi3CQhg52 < byteCount; i_rrtTi3CQhg52++) {
                        if (i_rrtTi3CQhg52 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_rrtTi3CQhg52 < byteCount - 1) {
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
                foreach (Thing finalObject in o.ThingThingMap.Values) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
        }
        public void Energize(EnumIntMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // MAP: EnumIntMap
            if (o.EnumIntMap.Keys == null || o.EnumIntMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.EnumIntMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.EnumIntMap.Keys.Count;
                int i_lA6aIYMrC9H5;
                for (i_lA6aIYMrC9H5 = 0; i_lA6aIYMrC9H5 < 2; i_lA6aIYMrC9H5++) {
                    if ((ulong)o.EnumIntMap.Keys.Count < vuBoundaries[i_lA6aIYMrC9H5]) {
                       byteCount = (int)(i_lA6aIYMrC9H5 + 1);
                       goto guvsgoto_hZ5qMHbBhzqR;
                    }
                }
                byteCount = (int)i_lA6aIYMrC9H5 + 1;
                guvsgoto_hZ5qMHbBhzqR:
                    for (int i_iBNOXEEc7zZe = 0; i_iBNOXEEc7zZe < byteCount; i_iBNOXEEc7zZe++) {
                        if (i_iBNOXEEc7zZe < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_iBNOXEEc7zZe < byteCount - 1) {
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
                foreach (MyEnum enumValue in o.EnumIntMap.Keys) {
                bytes[index++] = enumValueIndexMap["MyEnum"][enumValue.ToString()];
;
                }
            }
            if (o.EnumIntMap.Values == null || o.EnumIntMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.EnumIntMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.EnumIntMap.Values.Count;
                int i_yBitEOzrs96k;
                for (i_yBitEOzrs96k = 0; i_yBitEOzrs96k < 2; i_yBitEOzrs96k++) {
                    if ((ulong)o.EnumIntMap.Values.Count < vuBoundaries[i_yBitEOzrs96k]) {
                       byteCount = (int)(i_yBitEOzrs96k + 1);
                       goto guvsgoto_zt6yYOTqbMrS;
                    }
                }
                byteCount = (int)i_yBitEOzrs96k + 1;
                guvsgoto_zt6yYOTqbMrS:
                    for (int i_xwNM4nUbL2bo = 0; i_xwNM4nUbL2bo < byteCount; i_xwNM4nUbL2bo++) {
                        if (i_xwNM4nUbL2bo < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_xwNM4nUbL2bo < byteCount - 1) {
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
                foreach (int primitive in o.EnumIntMap.Values) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(VIntVLongMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // MAP: VintVlongMap
            if (o.VintVlongMap.Keys == null || o.VintVlongMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintVlongMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintVlongMap.Keys.Count;
                int i_jlIs9IV9wWEC;
                for (i_jlIs9IV9wWEC = 0; i_jlIs9IV9wWEC < 2; i_jlIs9IV9wWEC++) {
                    if ((ulong)o.VintVlongMap.Keys.Count < vuBoundaries[i_jlIs9IV9wWEC]) {
                       byteCount = (int)(i_jlIs9IV9wWEC + 1);
                       goto guvsgoto_wnCXpq3Rk5Rv;
                    }
                }
                byteCount = (int)i_jlIs9IV9wWEC + 1;
                guvsgoto_wnCXpq3Rk5Rv:
                    for (int i_agwX1pgfA3Bq = 0; i_agwX1pgfA3Bq < byteCount; i_agwX1pgfA3Bq++) {
                        if (i_agwX1pgfA3Bq < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_agwX1pgfA3Bq < byteCount - 1) {
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
                foreach (int primitive in o.VintVlongMap.Keys) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_eLbbfp98OsqT = primitive;
    if (s2ultemp_eLbbfp98OsqT == long.MinValue) {
        s2ultemp_eLbbfp98OsqT = long.MaxValue;
    }
    else {
        if (s2ultemp_eLbbfp98OsqT > 0) {
            s2ultemp_eLbbfp98OsqT = -s2ultemp_eLbbfp98OsqT;
        }
        s2ultemp_eLbbfp98OsqT -= 1;
    }
    s2ultemp_eLbbfp98OsqT = ~s2ultemp_eLbbfp98OsqT;
    ulong s2ulresult_rBcdgc2fSaXj = (ulong)s2ultemp_eLbbfp98OsqT;
    //// AppendGetSignVariantSize(s2ulresult_rBcdgc2fSaXj)
    byte vr_xfZ4YM5CTrhx = 1;
    for (int v_nU3gWGXS0MiA = 56; v_nU3gWGXS0MiA >= 0; v_nU3gWGXS0MiA -= 8) {
        if (((255UL << v_nU3gWGXS0MiA) & s2ulresult_rBcdgc2fSaXj) > 0) {
            vr_xfZ4YM5CTrhx = (byte)(v_nU3gWGXS0MiA / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_xfZ4YM5CTrhx << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_fd9ybwIlY2ha = 0; vi_fd9ybwIlY2ha < vr_xfZ4YM5CTrhx - 1; vi_fd9ybwIlY2ha++) {
        bytes[index++] = (byte)(s2ulresult_rBcdgc2fSaXj & 255);
        s2ulresult_rBcdgc2fSaXj = s2ulresult_rBcdgc2fSaXj >> 8;
    }
                }
            }
            if (o.VintVlongMap.Values == null || o.VintVlongMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintVlongMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintVlongMap.Values.Count;
                int i_dVsmnfsr7yRU;
                for (i_dVsmnfsr7yRU = 0; i_dVsmnfsr7yRU < 2; i_dVsmnfsr7yRU++) {
                    if ((ulong)o.VintVlongMap.Values.Count < vuBoundaries[i_dVsmnfsr7yRU]) {
                       byteCount = (int)(i_dVsmnfsr7yRU + 1);
                       goto guvsgoto_lfjcwX9xtOGw;
                    }
                }
                byteCount = (int)i_dVsmnfsr7yRU + 1;
                guvsgoto_lfjcwX9xtOGw:
                    for (int i_qHBxT6JOM3QR = 0; i_qHBxT6JOM3QR < byteCount; i_qHBxT6JOM3QR++) {
                        if (i_qHBxT6JOM3QR < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_qHBxT6JOM3QR < byteCount - 1) {
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
                foreach (long primitive in o.VintVlongMap.Values) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_jUvcNUgIHMpq = primitive;
    if (s2ultemp_jUvcNUgIHMpq == long.MinValue) {
        s2ultemp_jUvcNUgIHMpq = long.MaxValue;
    }
    else {
        if (s2ultemp_jUvcNUgIHMpq > 0) {
            s2ultemp_jUvcNUgIHMpq = -s2ultemp_jUvcNUgIHMpq;
        }
        s2ultemp_jUvcNUgIHMpq -= 1;
    }
    s2ultemp_jUvcNUgIHMpq = ~s2ultemp_jUvcNUgIHMpq;
    ulong s2ulresult_bv7TJZdbxyzZ = (ulong)s2ultemp_jUvcNUgIHMpq;
    //// AppendGetSignVariantSize(s2ulresult_bv7TJZdbxyzZ)
    byte vr_jLOxf1TpeL0C = 1;
    for (int v_sqOmsinarktx = 56; v_sqOmsinarktx >= 0; v_sqOmsinarktx -= 8) {
        if (((255UL << v_sqOmsinarktx) & s2ulresult_bv7TJZdbxyzZ) > 0) {
            vr_jLOxf1TpeL0C = (byte)(v_sqOmsinarktx / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_jLOxf1TpeL0C << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_z0fW0Ot7vGPb = 0; vi_z0fW0Ot7vGPb < vr_jLOxf1TpeL0C - 1; vi_z0fW0Ot7vGPb++) {
        bytes[index++] = (byte)(s2ulresult_bv7TJZdbxyzZ & 255);
        s2ulresult_bv7TJZdbxyzZ = s2ulresult_bv7TJZdbxyzZ >> 8;
    }
                }
            }
        }
        public void Energize(IMapTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 10:
                    Energize((Thing)o, bytes, ref index, writeTypeId);
                    break;
                case 11:
                    Energize((IntThingMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((ThingIntMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((IntStringMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((ThingThingMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((EnumIntMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((VIntVLongMapObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_cSDP3alCFF9s = 0;
                    for (int i_e0TplzHlrrzo = 0; i_e0TplzHlrrzo < 9; i_e0TplzHlrrzo++) {
                        byte b = bytes[index++];
                        if (i_e0TplzHlrrzo < 8) {
                            vuread_cSDP3alCFF9s += (((ulong)b & (ulong)127) << (7 * i_e0TplzHlrrzo));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cSDP3alCFF9s += (ulong)b << (7 * i_e0TplzHlrrzo);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_cSDP3alCFF9s;
            switch (typeId) {
            case 10:
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
            case 11:
                {
                IntThingMapObject o = new IntThingMapObject();
                // MAP: IntThingMap
                IList<int> intThingMapKeys = new List<int>();
                IList<Thing> intThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_u6yAr2hmKMfJ;
                    ulong vuread_rHgr901D0WL9 = 0;
                    for (int i_xeV69DUZto36 = 0; i_xeV69DUZto36 < 9; i_xeV69DUZto36++) {
                        byte b = bytes[index++];
                        if (i_xeV69DUZto36 < 8) {
                            vuread_rHgr901D0WL9 += (((ulong)b & (ulong)127) << (7 * i_xeV69DUZto36));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rHgr901D0WL9 += (ulong)b << (7 * i_xeV69DUZto36);
                            break;
                        }
                    }
                    count_u6yAr2hmKMfJ = (ushort)vuread_rHgr901D0WL9;
            // Read list items
            if (count_u6yAr2hmKMfJ > 0) {
                intThingMapKeys = new List<int>();
                int listValue_pVlMxXSJUkKN;
                for (int i_hpmAz6y9vzFn = 0; i_hpmAz6y9vzFn < count_u6yAr2hmKMfJ; i_hpmAz6y9vzFn++) {
                    // Read Int list item
                listValue_pVlMxXSJUkKN =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_pVlMxXSJUkKN);
                }
            }
            // Read list item count
            ushort count_clmg2qpzOkQo;
                    ulong vuread_rofcecoUDiNU = 0;
                    for (int i_htzx03Llq8Gl = 0; i_htzx03Llq8Gl < 9; i_htzx03Llq8Gl++) {
                        byte b = bytes[index++];
                        if (i_htzx03Llq8Gl < 8) {
                            vuread_rofcecoUDiNU += (((ulong)b & (ulong)127) << (7 * i_htzx03Llq8Gl));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rofcecoUDiNU += (ulong)b << (7 * i_htzx03Llq8Gl);
                            break;
                        }
                    }
                    count_clmg2qpzOkQo = (ushort)vuread_rofcecoUDiNU;
            // Read list items
            if (count_clmg2qpzOkQo > 0) {
                intThingMapValues = new List<Thing>();
                for (int li_pLRD4k9iI7Vk = 0; li_pLRD4k9iI7Vk < count_clmg2qpzOkQo; li_pLRD4k9iI7Vk++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.IntThingMap = new Dictionary<int,Thing>(intThingMapKeys.Count);
                for (int i_vw5skUT8HCZJ = 0; i_vw5skUT8HCZJ < intThingMapKeys.Count; i_vw5skUT8HCZJ++) {
                    o.IntThingMap[intThingMapKeys[i_vw5skUT8HCZJ]] = intThingMapValues[i_vw5skUT8HCZJ];
                }
                    return o;
                }
            case 12:
                {
                ThingIntMapObject o = new ThingIntMapObject();
                // MAP: ThingIntMap
                IList<Thing> thingIntMapKeys = new List<Thing>();
                IList<int> thingIntMapValues = new List<int>();
            // Read list item count
            ushort count_w2JUIE8RS3CD;
                    ulong vuread_iU0siFltHpGE = 0;
                    for (int i_zsbFoHOhWiNc = 0; i_zsbFoHOhWiNc < 9; i_zsbFoHOhWiNc++) {
                        byte b = bytes[index++];
                        if (i_zsbFoHOhWiNc < 8) {
                            vuread_iU0siFltHpGE += (((ulong)b & (ulong)127) << (7 * i_zsbFoHOhWiNc));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iU0siFltHpGE += (ulong)b << (7 * i_zsbFoHOhWiNc);
                            break;
                        }
                    }
                    count_w2JUIE8RS3CD = (ushort)vuread_iU0siFltHpGE;
            // Read list items
            if (count_w2JUIE8RS3CD > 0) {
                thingIntMapKeys = new List<Thing>();
                for (int li_ppJe9eB63B7z = 0; li_ppJe9eB63B7z < count_w2JUIE8RS3CD; li_ppJe9eB63B7z++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_xAZbrFbLvfVp;
                    ulong vuread_mCCkpuRnhXR3 = 0;
                    for (int i_yguDXKKGvLLX = 0; i_yguDXKKGvLLX < 9; i_yguDXKKGvLLX++) {
                        byte b = bytes[index++];
                        if (i_yguDXKKGvLLX < 8) {
                            vuread_mCCkpuRnhXR3 += (((ulong)b & (ulong)127) << (7 * i_yguDXKKGvLLX));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mCCkpuRnhXR3 += (ulong)b << (7 * i_yguDXKKGvLLX);
                            break;
                        }
                    }
                    count_xAZbrFbLvfVp = (ushort)vuread_mCCkpuRnhXR3;
            // Read list items
            if (count_xAZbrFbLvfVp > 0) {
                thingIntMapValues = new List<int>();
                int listValue_sM0rgbQFDtLH;
                for (int i_pqRJUUrgS6fk = 0; i_pqRJUUrgS6fk < count_xAZbrFbLvfVp; i_pqRJUUrgS6fk++) {
                    // Read Int list item
                listValue_sM0rgbQFDtLH =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_sM0rgbQFDtLH);
                }
            }
                o.ThingIntMap = new Dictionary<Thing,int>(thingIntMapKeys.Count);
                for (int i_eHXVFo411PCN = 0; i_eHXVFo411PCN < thingIntMapKeys.Count; i_eHXVFo411PCN++) {
                    o.ThingIntMap[thingIntMapKeys[i_eHXVFo411PCN]] = thingIntMapValues[i_eHXVFo411PCN];
                }
                    return o;
                }
            case 13:
                {
                IntStringMapObject o = new IntStringMapObject();
                // MAP: IntStringMap
                IList<int> intStringMapKeys = new List<int>();
                IList<string> intStringMapValues = new List<string>();
            // Read list item count
            ushort count_mzgghmzMFX2H;
                    ulong vuread_xaVKtEeVGPgJ = 0;
                    for (int i_f59ozUP5Xefu = 0; i_f59ozUP5Xefu < 9; i_f59ozUP5Xefu++) {
                        byte b = bytes[index++];
                        if (i_f59ozUP5Xefu < 8) {
                            vuread_xaVKtEeVGPgJ += (((ulong)b & (ulong)127) << (7 * i_f59ozUP5Xefu));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xaVKtEeVGPgJ += (ulong)b << (7 * i_f59ozUP5Xefu);
                            break;
                        }
                    }
                    count_mzgghmzMFX2H = (ushort)vuread_xaVKtEeVGPgJ;
            // Read list items
            if (count_mzgghmzMFX2H > 0) {
                intStringMapKeys = new List<int>();
                int listValue_ql9GGDPxOq2E;
                for (int i_mtHwKRgZtH1m = 0; i_mtHwKRgZtH1m < count_mzgghmzMFX2H; i_mtHwKRgZtH1m++) {
                    // Read Int list item
                listValue_ql9GGDPxOq2E =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_ql9GGDPxOq2E);
                }
            }
            // Read list item count
            ushort count_flmVh6TZ5A6i;
                    ulong vuread_nIpd9S47cFVf = 0;
                    for (int i_fsvg7pbgtWtv = 0; i_fsvg7pbgtWtv < 9; i_fsvg7pbgtWtv++) {
                        byte b = bytes[index++];
                        if (i_fsvg7pbgtWtv < 8) {
                            vuread_nIpd9S47cFVf += (((ulong)b & (ulong)127) << (7 * i_fsvg7pbgtWtv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nIpd9S47cFVf += (ulong)b << (7 * i_fsvg7pbgtWtv);
                            break;
                        }
                    }
                    count_flmVh6TZ5A6i = (ushort)vuread_nIpd9S47cFVf;
            // Read list items
            if (count_flmVh6TZ5A6i > 0) {
                intStringMapValues = new List<string>();
                string listValue_g4qSHcIbxz1b;
                for (int i_lcZKM3jRzhIY = 0; i_lcZKM3jRzhIY < count_flmVh6TZ5A6i; i_lcZKM3jRzhIY++) {
                    // Read String list item
                    ulong vuread_lmAa6TSXBtO5 = 0;
                    for (int i_kAEzNM5ivBg4 = 0; i_kAEzNM5ivBg4 < 9; i_kAEzNM5ivBg4++) {
                        byte b = bytes[index++];
                        if (i_kAEzNM5ivBg4 < 8) {
                            vuread_lmAa6TSXBtO5 += (((ulong)b & (ulong)127) << (7 * i_kAEzNM5ivBg4));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lmAa6TSXBtO5 += (ulong)b << (7 * i_kAEzNM5ivBg4);
                            break;
                        }
                    }
                    ushort stringLength_pM1QzZYSo3Xf = (ushort)vuread_lmAa6TSXBtO5;
                listValue_g4qSHcIbxz1b = Encoding.UTF8.GetString(bytes, index, stringLength_pM1QzZYSo3Xf);
                index += stringLength_pM1QzZYSo3Xf;
                    intStringMapValues.Add(listValue_g4qSHcIbxz1b);
                }
            }
                o.IntStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
                for (int i_e2MHKiXIpUiA = 0; i_e2MHKiXIpUiA < intStringMapKeys.Count; i_e2MHKiXIpUiA++) {
                    o.IntStringMap[intStringMapKeys[i_e2MHKiXIpUiA]] = intStringMapValues[i_e2MHKiXIpUiA];
                }
                    return o;
                }
            case 14:
                {
                ThingThingMapObject o = new ThingThingMapObject();
                // MAP: ThingThingMap
                IList<Thing> thingThingMapKeys = new List<Thing>();
                IList<Thing> thingThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_mjUPzVxr76q9;
                    ulong vuread_iyfM8OTafFYd = 0;
                    for (int i_dkmsGgPPrd6D = 0; i_dkmsGgPPrd6D < 9; i_dkmsGgPPrd6D++) {
                        byte b = bytes[index++];
                        if (i_dkmsGgPPrd6D < 8) {
                            vuread_iyfM8OTafFYd += (((ulong)b & (ulong)127) << (7 * i_dkmsGgPPrd6D));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iyfM8OTafFYd += (ulong)b << (7 * i_dkmsGgPPrd6D);
                            break;
                        }
                    }
                    count_mjUPzVxr76q9 = (ushort)vuread_iyfM8OTafFYd;
            // Read list items
            if (count_mjUPzVxr76q9 > 0) {
                thingThingMapKeys = new List<Thing>();
                for (int li_wpTKdZ7pMNmm = 0; li_wpTKdZ7pMNmm < count_mjUPzVxr76q9; li_wpTKdZ7pMNmm++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_blKLahv7uQIp;
                    ulong vuread_ofU0qKRrBLUS = 0;
                    for (int i_xj6pIJBD7apv = 0; i_xj6pIJBD7apv < 9; i_xj6pIJBD7apv++) {
                        byte b = bytes[index++];
                        if (i_xj6pIJBD7apv < 8) {
                            vuread_ofU0qKRrBLUS += (((ulong)b & (ulong)127) << (7 * i_xj6pIJBD7apv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ofU0qKRrBLUS += (ulong)b << (7 * i_xj6pIJBD7apv);
                            break;
                        }
                    }
                    count_blKLahv7uQIp = (ushort)vuread_ofU0qKRrBLUS;
            // Read list items
            if (count_blKLahv7uQIp > 0) {
                thingThingMapValues = new List<Thing>();
                for (int li_neOkS9jlREc8 = 0; li_neOkS9jlREc8 < count_blKLahv7uQIp; li_neOkS9jlREc8++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.ThingThingMap = new Dictionary<Thing,Thing>(thingThingMapKeys.Count);
                for (int i_cg8c64VBB1Q1 = 0; i_cg8c64VBB1Q1 < thingThingMapKeys.Count; i_cg8c64VBB1Q1++) {
                    o.ThingThingMap[thingThingMapKeys[i_cg8c64VBB1Q1]] = thingThingMapValues[i_cg8c64VBB1Q1];
                }
                    return o;
                }
            case 15:
                {
                EnumIntMapObject o = new EnumIntMapObject();
                // MAP: EnumIntMap
                IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
                IList<int> enumIntMapValues = new List<int>();
            // Read list item count
            ushort count_efyVperIZyum;
                    ulong vuread_yGJBCIaAh7kC = 0;
                    for (int i_pyHcpX4OyW9M = 0; i_pyHcpX4OyW9M < 9; i_pyHcpX4OyW9M++) {
                        byte b = bytes[index++];
                        if (i_pyHcpX4OyW9M < 8) {
                            vuread_yGJBCIaAh7kC += (((ulong)b & (ulong)127) << (7 * i_pyHcpX4OyW9M));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yGJBCIaAh7kC += (ulong)b << (7 * i_pyHcpX4OyW9M);
                            break;
                        }
                    }
                    count_efyVperIZyum = (ushort)vuread_yGJBCIaAh7kC;
            // Read list items
            if (count_efyVperIZyum > 0) {
                enumIntMapKeys = new List<MyEnum>();
                for (int i_px5MmDjPVVgz = 0; i_px5MmDjPVVgz < count_efyVperIZyum; i_px5MmDjPVVgz++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_it921pUn46k0;
                    ulong vuread_notcEPXjH60e = 0;
                    for (int i_qxoNYEQZsiR5 = 0; i_qxoNYEQZsiR5 < 9; i_qxoNYEQZsiR5++) {
                        byte b = bytes[index++];
                        if (i_qxoNYEQZsiR5 < 8) {
                            vuread_notcEPXjH60e += (((ulong)b & (ulong)127) << (7 * i_qxoNYEQZsiR5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_notcEPXjH60e += (ulong)b << (7 * i_qxoNYEQZsiR5);
                            break;
                        }
                    }
                    count_it921pUn46k0 = (ushort)vuread_notcEPXjH60e;
            // Read list items
            if (count_it921pUn46k0 > 0) {
                enumIntMapValues = new List<int>();
                int listValue_vcXicVSOnef7;
                for (int i_ehlg871yC4oD = 0; i_ehlg871yC4oD < count_it921pUn46k0; i_ehlg871yC4oD++) {
                    // Read Int list item
                listValue_vcXicVSOnef7 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_vcXicVSOnef7);
                }
            }
                o.EnumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
                for (int i_ahyzquHzHxnB = 0; i_ahyzquHzHxnB < enumIntMapKeys.Count; i_ahyzquHzHxnB++) {
                    o.EnumIntMap[enumIntMapKeys[i_ahyzquHzHxnB]] = enumIntMapValues[i_ahyzquHzHxnB];
                }
                    return o;
                }
            case 16:
                {
                VIntVLongMapObject o = new VIntVLongMapObject();
                // MAP: VintVlongMap
                IList<int> vintVlongMapKeys = new List<int>();
                IList<long> vintVlongMapValues = new List<long>();
            // Read list item count
            ushort count_wPhVom0IsqCR;
                    ulong vuread_iK1vqtD3Xth4 = 0;
                    for (int i_jsy3GQAW3Tns = 0; i_jsy3GQAW3Tns < 9; i_jsy3GQAW3Tns++) {
                        byte b = bytes[index++];
                        if (i_jsy3GQAW3Tns < 8) {
                            vuread_iK1vqtD3Xth4 += (((ulong)b & (ulong)127) << (7 * i_jsy3GQAW3Tns));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iK1vqtD3Xth4 += (ulong)b << (7 * i_jsy3GQAW3Tns);
                            break;
                        }
                    }
                    count_wPhVom0IsqCR = (ushort)vuread_iK1vqtD3Xth4;
            // Read list items
            if (count_wPhVom0IsqCR > 0) {
                vintVlongMapKeys = new List<int>();
                int listValue_vfjqePlVOQgP;
                for (int i_mmin4uNIHmy6 = 0; i_mmin4uNIHmy6 < count_wPhVom0IsqCR; i_mmin4uNIHmy6++) {
                    // Read VInt list item
    byte rvint_b_u7cLZQYJwIFk = bytes[index++];
    byte rvint_sign_enYhiwqQlSzu = (byte)(rvint_b_u7cLZQYJwIFk & 1);
    byte rvint_size_om2IfOVNRmCh = (byte)(rvint_b_u7cLZQYJwIFk >> 1);
    ulong rvint_remaining_qJ582Ht5Q7dR = 0;
    for (int i_nFAl6RUeHRdN = 0; i_nFAl6RUeHRdN < rvint_size_om2IfOVNRmCh - 1; i_nFAl6RUeHRdN++) {
        rvint_remaining_qJ582Ht5Q7dR = rvint_remaining_qJ582Ht5Q7dR | (((ulong)bytes[index++] << (8 * i_nFAl6RUeHRdN)));
    }
    int rvint_result_upDRW2D7UREJ = (int)rvint_remaining_qJ582Ht5Q7dR;
    rvint_result_upDRW2D7UREJ = ~rvint_result_upDRW2D7UREJ;
    if (rvint_result_upDRW2D7UREJ == int.MaxValue) {
        rvint_result_upDRW2D7UREJ = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_upDRW2D7UREJ += 1;
        if (rvint_sign_enYhiwqQlSzu == 0) {
            rvint_result_upDRW2D7UREJ = -rvint_result_upDRW2D7UREJ;
        }
    }
    listValue_vfjqePlVOQgP = rvint_result_upDRW2D7UREJ;
                    vintVlongMapKeys.Add(listValue_vfjqePlVOQgP);
                }
            }
            // Read list item count
            ushort count_lrYOzEOKildJ;
                    ulong vuread_gJQ9ByJ6FslM = 0;
                    for (int i_bLiXDg6Xb0UP = 0; i_bLiXDg6Xb0UP < 9; i_bLiXDg6Xb0UP++) {
                        byte b = bytes[index++];
                        if (i_bLiXDg6Xb0UP < 8) {
                            vuread_gJQ9ByJ6FslM += (((ulong)b & (ulong)127) << (7 * i_bLiXDg6Xb0UP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gJQ9ByJ6FslM += (ulong)b << (7 * i_bLiXDg6Xb0UP);
                            break;
                        }
                    }
                    count_lrYOzEOKildJ = (ushort)vuread_gJQ9ByJ6FslM;
            // Read list items
            if (count_lrYOzEOKildJ > 0) {
                vintVlongMapValues = new List<long>();
                long listValue_xgOddDELm3Dm;
                for (int i_eEFwhHdiglKY = 0; i_eEFwhHdiglKY < count_lrYOzEOKildJ; i_eEFwhHdiglKY++) {
                    // Read VLong list item
    byte rvlong_b_j0gbopIyZbfv = bytes[index++];
    byte rvlong_sign_tG3cYJzkh5M9 = (byte)(rvlong_b_j0gbopIyZbfv & 1);
    byte rvlong_size_pKQDXLIRFZQm = (byte)(rvlong_b_j0gbopIyZbfv >> 1);
    ulong rvlong_remaining_jCw7vfxjyjML = 0;
    for (int i_qauGVAQAohAN = 0; i_qauGVAQAohAN < rvlong_size_pKQDXLIRFZQm - 1; i_qauGVAQAohAN++) {
        rvlong_remaining_jCw7vfxjyjML = rvlong_remaining_jCw7vfxjyjML | (((ulong)bytes[index++] << (8 * i_qauGVAQAohAN)));
    }
    long rvlong_result_oeKnDyZ3ZQQv = (long)rvlong_remaining_jCw7vfxjyjML;
    rvlong_result_oeKnDyZ3ZQQv = ~rvlong_result_oeKnDyZ3ZQQv;
    if (rvlong_result_oeKnDyZ3ZQQv == long.MaxValue) {
        rvlong_result_oeKnDyZ3ZQQv = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_oeKnDyZ3ZQQv += 1;
        if (rvlong_sign_tG3cYJzkh5M9 == 0) {
            rvlong_result_oeKnDyZ3ZQQv = -rvlong_result_oeKnDyZ3ZQQv;
        }
    }
    listValue_xgOddDELm3Dm = rvlong_result_oeKnDyZ3ZQQv;
                    vintVlongMapValues.Add(listValue_xgOddDELm3Dm);
                }
            }
                o.VintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
                for (int i_fCYcHCKB8eZW = 0; i_fCYcHCKB8eZW < vintVlongMapKeys.Count; i_fCYcHCKB8eZW++) {
                    o.VintVlongMap[vintVlongMapKeys[i_fCYcHCKB8eZW]] = vintVlongMapValues[i_fCYcHCKB8eZW];
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_hc5ejq7ocTyq = 0;
                    for (int i_mjQauTV7t8tt = 0; i_mjQauTV7t8tt < 9; i_mjQauTV7t8tt++) {
                        byte b = bytes[index++];
                        if (i_mjQauTV7t8tt < 8) {
                            vuread_hc5ejq7ocTyq += (((ulong)b & (ulong)127) << (7 * i_mjQauTV7t8tt));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hc5ejq7ocTyq += (ulong)b << (7 * i_mjQauTV7t8tt);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_hc5ejq7ocTyq;
            switch (typeId) {
            case 10:
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
            case 11:
                {
                IntThingMapObject o = new IntThingMapObject();
                // MAP: IntThingMap
                IList<int> intThingMapKeys = new List<int>();
                IList<Thing> intThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_pN2VH8PEoX6A;
                    ulong vuread_lUUJTCtDeHIx = 0;
                    for (int i_uJhps1CsSMDF = 0; i_uJhps1CsSMDF < 9; i_uJhps1CsSMDF++) {
                        byte b = bytes[index++];
                        if (i_uJhps1CsSMDF < 8) {
                            vuread_lUUJTCtDeHIx += (((ulong)b & (ulong)127) << (7 * i_uJhps1CsSMDF));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lUUJTCtDeHIx += (ulong)b << (7 * i_uJhps1CsSMDF);
                            break;
                        }
                    }
                    count_pN2VH8PEoX6A = (ushort)vuread_lUUJTCtDeHIx;
            // Read list items
            if (count_pN2VH8PEoX6A > 0) {
                intThingMapKeys = new List<int>();
                int listValue_jmQed3bQnpIJ;
                for (int i_zmo1P0odfE97 = 0; i_zmo1P0odfE97 < count_pN2VH8PEoX6A; i_zmo1P0odfE97++) {
                    // Read Int list item
                listValue_jmQed3bQnpIJ =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_jmQed3bQnpIJ);
                }
            }
            // Read list item count
            ushort count_vAlxvNSZrpmG;
                    ulong vuread_toAkF1kGbIqg = 0;
                    for (int i_qLM2xzz2mSoN = 0; i_qLM2xzz2mSoN < 9; i_qLM2xzz2mSoN++) {
                        byte b = bytes[index++];
                        if (i_qLM2xzz2mSoN < 8) {
                            vuread_toAkF1kGbIqg += (((ulong)b & (ulong)127) << (7 * i_qLM2xzz2mSoN));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_toAkF1kGbIqg += (ulong)b << (7 * i_qLM2xzz2mSoN);
                            break;
                        }
                    }
                    count_vAlxvNSZrpmG = (ushort)vuread_toAkF1kGbIqg;
            // Read list items
            if (count_vAlxvNSZrpmG > 0) {
                intThingMapValues = new List<Thing>();
                for (int li_sOvKHSrTaRgB = 0; li_sOvKHSrTaRgB < count_vAlxvNSZrpmG; li_sOvKHSrTaRgB++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.IntThingMap = new Dictionary<int,Thing>(intThingMapKeys.Count);
                for (int i_kdHnuD6rjeTU = 0; i_kdHnuD6rjeTU < intThingMapKeys.Count; i_kdHnuD6rjeTU++) {
                    o.IntThingMap[intThingMapKeys[i_kdHnuD6rjeTU]] = intThingMapValues[i_kdHnuD6rjeTU];
                }
                    return o;
                }
            case 12:
                {
                ThingIntMapObject o = new ThingIntMapObject();
                // MAP: ThingIntMap
                IList<Thing> thingIntMapKeys = new List<Thing>();
                IList<int> thingIntMapValues = new List<int>();
            // Read list item count
            ushort count_aZB2ZtucaWC1;
                    ulong vuread_nJ8sqGg5FlCt = 0;
                    for (int i_wmHTV6DN5LJR = 0; i_wmHTV6DN5LJR < 9; i_wmHTV6DN5LJR++) {
                        byte b = bytes[index++];
                        if (i_wmHTV6DN5LJR < 8) {
                            vuread_nJ8sqGg5FlCt += (((ulong)b & (ulong)127) << (7 * i_wmHTV6DN5LJR));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nJ8sqGg5FlCt += (ulong)b << (7 * i_wmHTV6DN5LJR);
                            break;
                        }
                    }
                    count_aZB2ZtucaWC1 = (ushort)vuread_nJ8sqGg5FlCt;
            // Read list items
            if (count_aZB2ZtucaWC1 > 0) {
                thingIntMapKeys = new List<Thing>();
                for (int li_hz4QxdAMKQQV = 0; li_hz4QxdAMKQQV < count_aZB2ZtucaWC1; li_hz4QxdAMKQQV++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_mOaM8XoZxhaM;
                    ulong vuread_uLqdtZ65ara1 = 0;
                    for (int i_qAIBVZSkFWoh = 0; i_qAIBVZSkFWoh < 9; i_qAIBVZSkFWoh++) {
                        byte b = bytes[index++];
                        if (i_qAIBVZSkFWoh < 8) {
                            vuread_uLqdtZ65ara1 += (((ulong)b & (ulong)127) << (7 * i_qAIBVZSkFWoh));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uLqdtZ65ara1 += (ulong)b << (7 * i_qAIBVZSkFWoh);
                            break;
                        }
                    }
                    count_mOaM8XoZxhaM = (ushort)vuread_uLqdtZ65ara1;
            // Read list items
            if (count_mOaM8XoZxhaM > 0) {
                thingIntMapValues = new List<int>();
                int listValue_y0PhwUujzr3V;
                for (int i_uwtVUVUnNjaH = 0; i_uwtVUVUnNjaH < count_mOaM8XoZxhaM; i_uwtVUVUnNjaH++) {
                    // Read Int list item
                listValue_y0PhwUujzr3V =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_y0PhwUujzr3V);
                }
            }
                o.ThingIntMap = new Dictionary<Thing,int>(thingIntMapKeys.Count);
                for (int i_gXdHyZgawjhC = 0; i_gXdHyZgawjhC < thingIntMapKeys.Count; i_gXdHyZgawjhC++) {
                    o.ThingIntMap[thingIntMapKeys[i_gXdHyZgawjhC]] = thingIntMapValues[i_gXdHyZgawjhC];
                }
                    return o;
                }
            case 13:
                {
                IntStringMapObject o = new IntStringMapObject();
                // MAP: IntStringMap
                IList<int> intStringMapKeys = new List<int>();
                IList<string> intStringMapValues = new List<string>();
            // Read list item count
            ushort count_eYJq61CuGXPy;
                    ulong vuread_n7AUbbDW0h2J = 0;
                    for (int i_rXUJl3yMo0K5 = 0; i_rXUJl3yMo0K5 < 9; i_rXUJl3yMo0K5++) {
                        byte b = bytes[index++];
                        if (i_rXUJl3yMo0K5 < 8) {
                            vuread_n7AUbbDW0h2J += (((ulong)b & (ulong)127) << (7 * i_rXUJl3yMo0K5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_n7AUbbDW0h2J += (ulong)b << (7 * i_rXUJl3yMo0K5);
                            break;
                        }
                    }
                    count_eYJq61CuGXPy = (ushort)vuread_n7AUbbDW0h2J;
            // Read list items
            if (count_eYJq61CuGXPy > 0) {
                intStringMapKeys = new List<int>();
                int listValue_fEqWQPaBhPaB;
                for (int i_kw8vQuLc6aJj = 0; i_kw8vQuLc6aJj < count_eYJq61CuGXPy; i_kw8vQuLc6aJj++) {
                    // Read Int list item
                listValue_fEqWQPaBhPaB =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_fEqWQPaBhPaB);
                }
            }
            // Read list item count
            ushort count_d2jNycjPwEIH;
                    ulong vuread_tQgkgABbWskY = 0;
                    for (int i_xd64pH8m4hOY = 0; i_xd64pH8m4hOY < 9; i_xd64pH8m4hOY++) {
                        byte b = bytes[index++];
                        if (i_xd64pH8m4hOY < 8) {
                            vuread_tQgkgABbWskY += (((ulong)b & (ulong)127) << (7 * i_xd64pH8m4hOY));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tQgkgABbWskY += (ulong)b << (7 * i_xd64pH8m4hOY);
                            break;
                        }
                    }
                    count_d2jNycjPwEIH = (ushort)vuread_tQgkgABbWskY;
            // Read list items
            if (count_d2jNycjPwEIH > 0) {
                intStringMapValues = new List<string>();
                string listValue_nxdfFve5YBK9;
                for (int i_gB6GIIwYSuSu = 0; i_gB6GIIwYSuSu < count_d2jNycjPwEIH; i_gB6GIIwYSuSu++) {
                    // Read String list item
                    ulong vuread_jvFBop9DC6PX = 0;
                    for (int i_pCNvU0flPS8p = 0; i_pCNvU0flPS8p < 9; i_pCNvU0flPS8p++) {
                        byte b = bytes[index++];
                        if (i_pCNvU0flPS8p < 8) {
                            vuread_jvFBop9DC6PX += (((ulong)b & (ulong)127) << (7 * i_pCNvU0flPS8p));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jvFBop9DC6PX += (ulong)b << (7 * i_pCNvU0flPS8p);
                            break;
                        }
                    }
                    ushort stringLength_cpAYFvMNbrNT = (ushort)vuread_jvFBop9DC6PX;
                listValue_nxdfFve5YBK9 = Encoding.UTF8.GetString(bytes, index, stringLength_cpAYFvMNbrNT);
                index += stringLength_cpAYFvMNbrNT;
                    intStringMapValues.Add(listValue_nxdfFve5YBK9);
                }
            }
                o.IntStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
                for (int i_xpzCY786Xmjn = 0; i_xpzCY786Xmjn < intStringMapKeys.Count; i_xpzCY786Xmjn++) {
                    o.IntStringMap[intStringMapKeys[i_xpzCY786Xmjn]] = intStringMapValues[i_xpzCY786Xmjn];
                }
                    return o;
                }
            case 14:
                {
                ThingThingMapObject o = new ThingThingMapObject();
                // MAP: ThingThingMap
                IList<Thing> thingThingMapKeys = new List<Thing>();
                IList<Thing> thingThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_b5JDvo2kKMnd;
                    ulong vuread_sq2lmCeOwqG8 = 0;
                    for (int i_vHPF8SaysAtZ = 0; i_vHPF8SaysAtZ < 9; i_vHPF8SaysAtZ++) {
                        byte b = bytes[index++];
                        if (i_vHPF8SaysAtZ < 8) {
                            vuread_sq2lmCeOwqG8 += (((ulong)b & (ulong)127) << (7 * i_vHPF8SaysAtZ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sq2lmCeOwqG8 += (ulong)b << (7 * i_vHPF8SaysAtZ);
                            break;
                        }
                    }
                    count_b5JDvo2kKMnd = (ushort)vuread_sq2lmCeOwqG8;
            // Read list items
            if (count_b5JDvo2kKMnd > 0) {
                thingThingMapKeys = new List<Thing>();
                for (int li_gL0A0YOscwTH = 0; li_gL0A0YOscwTH < count_b5JDvo2kKMnd; li_gL0A0YOscwTH++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_bWUviF0WyLOX;
                    ulong vuread_owm2MYUs7c4K = 0;
                    for (int i_pNXILo6CXhAl = 0; i_pNXILo6CXhAl < 9; i_pNXILo6CXhAl++) {
                        byte b = bytes[index++];
                        if (i_pNXILo6CXhAl < 8) {
                            vuread_owm2MYUs7c4K += (((ulong)b & (ulong)127) << (7 * i_pNXILo6CXhAl));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_owm2MYUs7c4K += (ulong)b << (7 * i_pNXILo6CXhAl);
                            break;
                        }
                    }
                    count_bWUviF0WyLOX = (ushort)vuread_owm2MYUs7c4K;
            // Read list items
            if (count_bWUviF0WyLOX > 0) {
                thingThingMapValues = new List<Thing>();
                for (int li_zPqWKGAP7d1E = 0; li_zPqWKGAP7d1E < count_bWUviF0WyLOX; li_zPqWKGAP7d1E++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.ThingThingMap = new Dictionary<Thing,Thing>(thingThingMapKeys.Count);
                for (int i_qWQnLBKb2jTE = 0; i_qWQnLBKb2jTE < thingThingMapKeys.Count; i_qWQnLBKb2jTE++) {
                    o.ThingThingMap[thingThingMapKeys[i_qWQnLBKb2jTE]] = thingThingMapValues[i_qWQnLBKb2jTE];
                }
                    return o;
                }
            case 15:
                {
                EnumIntMapObject o = new EnumIntMapObject();
                // MAP: EnumIntMap
                IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
                IList<int> enumIntMapValues = new List<int>();
            // Read list item count
            ushort count_sskkOlaA5b36;
                    ulong vuread_o8SAMpNIVt5Y = 0;
                    for (int i_oS1vHzsZ5Ves = 0; i_oS1vHzsZ5Ves < 9; i_oS1vHzsZ5Ves++) {
                        byte b = bytes[index++];
                        if (i_oS1vHzsZ5Ves < 8) {
                            vuread_o8SAMpNIVt5Y += (((ulong)b & (ulong)127) << (7 * i_oS1vHzsZ5Ves));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_o8SAMpNIVt5Y += (ulong)b << (7 * i_oS1vHzsZ5Ves);
                            break;
                        }
                    }
                    count_sskkOlaA5b36 = (ushort)vuread_o8SAMpNIVt5Y;
            // Read list items
            if (count_sskkOlaA5b36 > 0) {
                enumIntMapKeys = new List<MyEnum>();
                for (int i_jqaWcAIL3TPN = 0; i_jqaWcAIL3TPN < count_sskkOlaA5b36; i_jqaWcAIL3TPN++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_tjzNFkSywwM6;
                    ulong vuread_iO3GSeaW3Aev = 0;
                    for (int i_g1FuUu5YcnMy = 0; i_g1FuUu5YcnMy < 9; i_g1FuUu5YcnMy++) {
                        byte b = bytes[index++];
                        if (i_g1FuUu5YcnMy < 8) {
                            vuread_iO3GSeaW3Aev += (((ulong)b & (ulong)127) << (7 * i_g1FuUu5YcnMy));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iO3GSeaW3Aev += (ulong)b << (7 * i_g1FuUu5YcnMy);
                            break;
                        }
                    }
                    count_tjzNFkSywwM6 = (ushort)vuread_iO3GSeaW3Aev;
            // Read list items
            if (count_tjzNFkSywwM6 > 0) {
                enumIntMapValues = new List<int>();
                int listValue_zPtUcP59NeCy;
                for (int i_oc2YS3TtedyO = 0; i_oc2YS3TtedyO < count_tjzNFkSywwM6; i_oc2YS3TtedyO++) {
                    // Read Int list item
                listValue_zPtUcP59NeCy =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_zPtUcP59NeCy);
                }
            }
                o.EnumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
                for (int i_ryOcAY3gcFGc = 0; i_ryOcAY3gcFGc < enumIntMapKeys.Count; i_ryOcAY3gcFGc++) {
                    o.EnumIntMap[enumIntMapKeys[i_ryOcAY3gcFGc]] = enumIntMapValues[i_ryOcAY3gcFGc];
                }
                    return o;
                }
            case 16:
                {
                VIntVLongMapObject o = new VIntVLongMapObject();
                // MAP: VintVlongMap
                IList<int> vintVlongMapKeys = new List<int>();
                IList<long> vintVlongMapValues = new List<long>();
            // Read list item count
            ushort count_tpToEfSkzhXR;
                    ulong vuread_lgfjEst5rOfO = 0;
                    for (int i_a2JYkvwcG0dC = 0; i_a2JYkvwcG0dC < 9; i_a2JYkvwcG0dC++) {
                        byte b = bytes[index++];
                        if (i_a2JYkvwcG0dC < 8) {
                            vuread_lgfjEst5rOfO += (((ulong)b & (ulong)127) << (7 * i_a2JYkvwcG0dC));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lgfjEst5rOfO += (ulong)b << (7 * i_a2JYkvwcG0dC);
                            break;
                        }
                    }
                    count_tpToEfSkzhXR = (ushort)vuread_lgfjEst5rOfO;
            // Read list items
            if (count_tpToEfSkzhXR > 0) {
                vintVlongMapKeys = new List<int>();
                int listValue_eFY9vnpHK6Lt;
                for (int i_tULTlKVgjemL = 0; i_tULTlKVgjemL < count_tpToEfSkzhXR; i_tULTlKVgjemL++) {
                    // Read VInt list item
    byte rvint_b_n3adVUlKdM98 = bytes[index++];
    byte rvint_sign_muKdzIdfrpfz = (byte)(rvint_b_n3adVUlKdM98 & 1);
    byte rvint_size_tM15e6sesnDB = (byte)(rvint_b_n3adVUlKdM98 >> 1);
    ulong rvint_remaining_flW0UapgUMp1 = 0;
    for (int i_aRRLbhuqYKti = 0; i_aRRLbhuqYKti < rvint_size_tM15e6sesnDB - 1; i_aRRLbhuqYKti++) {
        rvint_remaining_flW0UapgUMp1 = rvint_remaining_flW0UapgUMp1 | (((ulong)bytes[index++] << (8 * i_aRRLbhuqYKti)));
    }
    int rvint_result_xpGht4Qq0i0n = (int)rvint_remaining_flW0UapgUMp1;
    rvint_result_xpGht4Qq0i0n = ~rvint_result_xpGht4Qq0i0n;
    if (rvint_result_xpGht4Qq0i0n == int.MaxValue) {
        rvint_result_xpGht4Qq0i0n = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_xpGht4Qq0i0n += 1;
        if (rvint_sign_muKdzIdfrpfz == 0) {
            rvint_result_xpGht4Qq0i0n = -rvint_result_xpGht4Qq0i0n;
        }
    }
    listValue_eFY9vnpHK6Lt = rvint_result_xpGht4Qq0i0n;
                    vintVlongMapKeys.Add(listValue_eFY9vnpHK6Lt);
                }
            }
            // Read list item count
            ushort count_tnuq98Phxa5w;
                    ulong vuread_gRdl2nNM2O7E = 0;
                    for (int i_mhX068a21E0X = 0; i_mhX068a21E0X < 9; i_mhX068a21E0X++) {
                        byte b = bytes[index++];
                        if (i_mhX068a21E0X < 8) {
                            vuread_gRdl2nNM2O7E += (((ulong)b & (ulong)127) << (7 * i_mhX068a21E0X));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gRdl2nNM2O7E += (ulong)b << (7 * i_mhX068a21E0X);
                            break;
                        }
                    }
                    count_tnuq98Phxa5w = (ushort)vuread_gRdl2nNM2O7E;
            // Read list items
            if (count_tnuq98Phxa5w > 0) {
                vintVlongMapValues = new List<long>();
                long listValue_udqZ5mV2uj3M;
                for (int i_wFyNEougpZW2 = 0; i_wFyNEougpZW2 < count_tnuq98Phxa5w; i_wFyNEougpZW2++) {
                    // Read VLong list item
    byte rvlong_b_eYky9cFU0pxZ = bytes[index++];
    byte rvlong_sign_yYRQ3ejuol9B = (byte)(rvlong_b_eYky9cFU0pxZ & 1);
    byte rvlong_size_pxxMjTI7qyOg = (byte)(rvlong_b_eYky9cFU0pxZ >> 1);
    ulong rvlong_remaining_aw3sNjVKhIQQ = 0;
    for (int i_nOnlPCN9YTXM = 0; i_nOnlPCN9YTXM < rvlong_size_pxxMjTI7qyOg - 1; i_nOnlPCN9YTXM++) {
        rvlong_remaining_aw3sNjVKhIQQ = rvlong_remaining_aw3sNjVKhIQQ | (((ulong)bytes[index++] << (8 * i_nOnlPCN9YTXM)));
    }
    long rvlong_result_r2KgRzIIjKOG = (long)rvlong_remaining_aw3sNjVKhIQQ;
    rvlong_result_r2KgRzIIjKOG = ~rvlong_result_r2KgRzIIjKOG;
    if (rvlong_result_r2KgRzIIjKOG == long.MaxValue) {
        rvlong_result_r2KgRzIIjKOG = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_r2KgRzIIjKOG += 1;
        if (rvlong_sign_yYRQ3ejuol9B == 0) {
            rvlong_result_r2KgRzIIjKOG = -rvlong_result_r2KgRzIIjKOG;
        }
    }
    listValue_udqZ5mV2uj3M = rvlong_result_r2KgRzIIjKOG;
                    vintVlongMapValues.Add(listValue_udqZ5mV2uj3M);
                }
            }
                o.VintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
                for (int i_e1QfzztcQRfF = 0; i_e1QfzztcQRfF < vintVlongMapKeys.Count; i_e1QfzztcQRfF++) {
                    o.VintVlongMap[vintVlongMapKeys[i_e1QfzztcQRfF]] = vintVlongMapValues[i_e1QfzztcQRfF];
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 10:
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
            case 11:
                {
                IntThingMapObject o = new IntThingMapObject();
                // MAP: IntThingMap
                IList<int> intThingMapKeys = new List<int>();
                IList<Thing> intThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_nxsXUOssJrNU;
                    ulong vuread_oP2R9hG79QaX = 0;
                    for (int i_uHKzzV57XfJu = 0; i_uHKzzV57XfJu < 9; i_uHKzzV57XfJu++) {
                        byte b = bytes[index++];
                        if (i_uHKzzV57XfJu < 8) {
                            vuread_oP2R9hG79QaX += (((ulong)b & (ulong)127) << (7 * i_uHKzzV57XfJu));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oP2R9hG79QaX += (ulong)b << (7 * i_uHKzzV57XfJu);
                            break;
                        }
                    }
                    count_nxsXUOssJrNU = (ushort)vuread_oP2R9hG79QaX;
            // Read list items
            if (count_nxsXUOssJrNU > 0) {
                intThingMapKeys = new List<int>();
                int listValue_dVXFrw73o5HT;
                for (int i_nMcJliF0xEcn = 0; i_nMcJliF0xEcn < count_nxsXUOssJrNU; i_nMcJliF0xEcn++) {
                    // Read Int list item
                listValue_dVXFrw73o5HT =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_dVXFrw73o5HT);
                }
            }
            // Read list item count
            ushort count_b32YwP7CfIKo;
                    ulong vuread_ibPMTgJ0a13X = 0;
                    for (int i_swWOJT7MTKBy = 0; i_swWOJT7MTKBy < 9; i_swWOJT7MTKBy++) {
                        byte b = bytes[index++];
                        if (i_swWOJT7MTKBy < 8) {
                            vuread_ibPMTgJ0a13X += (((ulong)b & (ulong)127) << (7 * i_swWOJT7MTKBy));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ibPMTgJ0a13X += (ulong)b << (7 * i_swWOJT7MTKBy);
                            break;
                        }
                    }
                    count_b32YwP7CfIKo = (ushort)vuread_ibPMTgJ0a13X;
            // Read list items
            if (count_b32YwP7CfIKo > 0) {
                intThingMapValues = new List<Thing>();
                for (int li_miHI8eO7bXoj = 0; li_miHI8eO7bXoj < count_b32YwP7CfIKo; li_miHI8eO7bXoj++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.IntThingMap = new Dictionary<int,Thing>(intThingMapKeys.Count);
                for (int i_m2gq5lmmaffa = 0; i_m2gq5lmmaffa < intThingMapKeys.Count; i_m2gq5lmmaffa++) {
                    o.IntThingMap[intThingMapKeys[i_m2gq5lmmaffa]] = intThingMapValues[i_m2gq5lmmaffa];
                }
                    return o;
                }
            case 12:
                {
                ThingIntMapObject o = new ThingIntMapObject();
                // MAP: ThingIntMap
                IList<Thing> thingIntMapKeys = new List<Thing>();
                IList<int> thingIntMapValues = new List<int>();
            // Read list item count
            ushort count_xs2vL7FTJqjK;
                    ulong vuread_oa25m5V4hMlR = 0;
                    for (int i_qQRHxoyydHOP = 0; i_qQRHxoyydHOP < 9; i_qQRHxoyydHOP++) {
                        byte b = bytes[index++];
                        if (i_qQRHxoyydHOP < 8) {
                            vuread_oa25m5V4hMlR += (((ulong)b & (ulong)127) << (7 * i_qQRHxoyydHOP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oa25m5V4hMlR += (ulong)b << (7 * i_qQRHxoyydHOP);
                            break;
                        }
                    }
                    count_xs2vL7FTJqjK = (ushort)vuread_oa25m5V4hMlR;
            // Read list items
            if (count_xs2vL7FTJqjK > 0) {
                thingIntMapKeys = new List<Thing>();
                for (int li_eswdsEJmTGS4 = 0; li_eswdsEJmTGS4 < count_xs2vL7FTJqjK; li_eswdsEJmTGS4++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_ir9etk2rhlS4;
                    ulong vuread_g8wu2VHawmU4 = 0;
                    for (int i_oSMMc97h8Xng = 0; i_oSMMc97h8Xng < 9; i_oSMMc97h8Xng++) {
                        byte b = bytes[index++];
                        if (i_oSMMc97h8Xng < 8) {
                            vuread_g8wu2VHawmU4 += (((ulong)b & (ulong)127) << (7 * i_oSMMc97h8Xng));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_g8wu2VHawmU4 += (ulong)b << (7 * i_oSMMc97h8Xng);
                            break;
                        }
                    }
                    count_ir9etk2rhlS4 = (ushort)vuread_g8wu2VHawmU4;
            // Read list items
            if (count_ir9etk2rhlS4 > 0) {
                thingIntMapValues = new List<int>();
                int listValue_gte2OxIaJCXu;
                for (int i_dou88RIhHeGL = 0; i_dou88RIhHeGL < count_ir9etk2rhlS4; i_dou88RIhHeGL++) {
                    // Read Int list item
                listValue_gte2OxIaJCXu =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_gte2OxIaJCXu);
                }
            }
                o.ThingIntMap = new Dictionary<Thing,int>(thingIntMapKeys.Count);
                for (int i_oqohnL6DUqfI = 0; i_oqohnL6DUqfI < thingIntMapKeys.Count; i_oqohnL6DUqfI++) {
                    o.ThingIntMap[thingIntMapKeys[i_oqohnL6DUqfI]] = thingIntMapValues[i_oqohnL6DUqfI];
                }
                    return o;
                }
            case 13:
                {
                IntStringMapObject o = new IntStringMapObject();
                // MAP: IntStringMap
                IList<int> intStringMapKeys = new List<int>();
                IList<string> intStringMapValues = new List<string>();
            // Read list item count
            ushort count_rOw8OTug4sDX;
                    ulong vuread_r9iqpgJkXDty = 0;
                    for (int i_dAW8FuJ1jVrt = 0; i_dAW8FuJ1jVrt < 9; i_dAW8FuJ1jVrt++) {
                        byte b = bytes[index++];
                        if (i_dAW8FuJ1jVrt < 8) {
                            vuread_r9iqpgJkXDty += (((ulong)b & (ulong)127) << (7 * i_dAW8FuJ1jVrt));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_r9iqpgJkXDty += (ulong)b << (7 * i_dAW8FuJ1jVrt);
                            break;
                        }
                    }
                    count_rOw8OTug4sDX = (ushort)vuread_r9iqpgJkXDty;
            // Read list items
            if (count_rOw8OTug4sDX > 0) {
                intStringMapKeys = new List<int>();
                int listValue_jJCXUAQqWACn;
                for (int i_mQnOR5Vmv8Yo = 0; i_mQnOR5Vmv8Yo < count_rOw8OTug4sDX; i_mQnOR5Vmv8Yo++) {
                    // Read Int list item
                listValue_jJCXUAQqWACn =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_jJCXUAQqWACn);
                }
            }
            // Read list item count
            ushort count_ywKKSMO3RY4P;
                    ulong vuread_qVAwWcLS7IFZ = 0;
                    for (int i_c4koae8xUoZy = 0; i_c4koae8xUoZy < 9; i_c4koae8xUoZy++) {
                        byte b = bytes[index++];
                        if (i_c4koae8xUoZy < 8) {
                            vuread_qVAwWcLS7IFZ += (((ulong)b & (ulong)127) << (7 * i_c4koae8xUoZy));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qVAwWcLS7IFZ += (ulong)b << (7 * i_c4koae8xUoZy);
                            break;
                        }
                    }
                    count_ywKKSMO3RY4P = (ushort)vuread_qVAwWcLS7IFZ;
            // Read list items
            if (count_ywKKSMO3RY4P > 0) {
                intStringMapValues = new List<string>();
                string listValue_vgIkWJGOVIa5;
                for (int i_nyAswgry0UEX = 0; i_nyAswgry0UEX < count_ywKKSMO3RY4P; i_nyAswgry0UEX++) {
                    // Read String list item
                    ulong vuread_mA6xc0eH4oSM = 0;
                    for (int i_rPaO6BHfLUSw = 0; i_rPaO6BHfLUSw < 9; i_rPaO6BHfLUSw++) {
                        byte b = bytes[index++];
                        if (i_rPaO6BHfLUSw < 8) {
                            vuread_mA6xc0eH4oSM += (((ulong)b & (ulong)127) << (7 * i_rPaO6BHfLUSw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mA6xc0eH4oSM += (ulong)b << (7 * i_rPaO6BHfLUSw);
                            break;
                        }
                    }
                    ushort stringLength_lA2MZH4z5cGQ = (ushort)vuread_mA6xc0eH4oSM;
                listValue_vgIkWJGOVIa5 = Encoding.UTF8.GetString(bytes, index, stringLength_lA2MZH4z5cGQ);
                index += stringLength_lA2MZH4z5cGQ;
                    intStringMapValues.Add(listValue_vgIkWJGOVIa5);
                }
            }
                o.IntStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
                for (int i_s3YoOK9D1TX5 = 0; i_s3YoOK9D1TX5 < intStringMapKeys.Count; i_s3YoOK9D1TX5++) {
                    o.IntStringMap[intStringMapKeys[i_s3YoOK9D1TX5]] = intStringMapValues[i_s3YoOK9D1TX5];
                }
                    return o;
                }
            case 14:
                {
                ThingThingMapObject o = new ThingThingMapObject();
                // MAP: ThingThingMap
                IList<Thing> thingThingMapKeys = new List<Thing>();
                IList<Thing> thingThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_e3w9Q63nRq7j;
                    ulong vuread_npDEEBeUSKQi = 0;
                    for (int i_aZ3uopU52eFd = 0; i_aZ3uopU52eFd < 9; i_aZ3uopU52eFd++) {
                        byte b = bytes[index++];
                        if (i_aZ3uopU52eFd < 8) {
                            vuread_npDEEBeUSKQi += (((ulong)b & (ulong)127) << (7 * i_aZ3uopU52eFd));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_npDEEBeUSKQi += (ulong)b << (7 * i_aZ3uopU52eFd);
                            break;
                        }
                    }
                    count_e3w9Q63nRq7j = (ushort)vuread_npDEEBeUSKQi;
            // Read list items
            if (count_e3w9Q63nRq7j > 0) {
                thingThingMapKeys = new List<Thing>();
                for (int li_bHzP1FOA5OSy = 0; li_bHzP1FOA5OSy < count_e3w9Q63nRq7j; li_bHzP1FOA5OSy++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_dF8AOdnJnn70;
                    ulong vuread_bJ8BFcrBUzA7 = 0;
                    for (int i_az3m5pnxhEmT = 0; i_az3m5pnxhEmT < 9; i_az3m5pnxhEmT++) {
                        byte b = bytes[index++];
                        if (i_az3m5pnxhEmT < 8) {
                            vuread_bJ8BFcrBUzA7 += (((ulong)b & (ulong)127) << (7 * i_az3m5pnxhEmT));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bJ8BFcrBUzA7 += (ulong)b << (7 * i_az3m5pnxhEmT);
                            break;
                        }
                    }
                    count_dF8AOdnJnn70 = (ushort)vuread_bJ8BFcrBUzA7;
            // Read list items
            if (count_dF8AOdnJnn70 > 0) {
                thingThingMapValues = new List<Thing>();
                for (int li_huqZ06Z0KJMs = 0; li_huqZ06Z0KJMs < count_dF8AOdnJnn70; li_huqZ06Z0KJMs++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.ThingThingMap = new Dictionary<Thing,Thing>(thingThingMapKeys.Count);
                for (int i_nm52xrORfbyp = 0; i_nm52xrORfbyp < thingThingMapKeys.Count; i_nm52xrORfbyp++) {
                    o.ThingThingMap[thingThingMapKeys[i_nm52xrORfbyp]] = thingThingMapValues[i_nm52xrORfbyp];
                }
                    return o;
                }
            case 15:
                {
                EnumIntMapObject o = new EnumIntMapObject();
                // MAP: EnumIntMap
                IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
                IList<int> enumIntMapValues = new List<int>();
            // Read list item count
            ushort count_ebN7aKSIwokk;
                    ulong vuread_uCKYJJxCXLPS = 0;
                    for (int i_iua00FOq6aPZ = 0; i_iua00FOq6aPZ < 9; i_iua00FOq6aPZ++) {
                        byte b = bytes[index++];
                        if (i_iua00FOq6aPZ < 8) {
                            vuread_uCKYJJxCXLPS += (((ulong)b & (ulong)127) << (7 * i_iua00FOq6aPZ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uCKYJJxCXLPS += (ulong)b << (7 * i_iua00FOq6aPZ);
                            break;
                        }
                    }
                    count_ebN7aKSIwokk = (ushort)vuread_uCKYJJxCXLPS;
            // Read list items
            if (count_ebN7aKSIwokk > 0) {
                enumIntMapKeys = new List<MyEnum>();
                for (int i_h20a0d5scUg4 = 0; i_h20a0d5scUg4 < count_ebN7aKSIwokk; i_h20a0d5scUg4++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_s0hGO6CIw4NQ;
                    ulong vuread_p2S1K4oVXUFR = 0;
                    for (int i_swLTPwQKofj9 = 0; i_swLTPwQKofj9 < 9; i_swLTPwQKofj9++) {
                        byte b = bytes[index++];
                        if (i_swLTPwQKofj9 < 8) {
                            vuread_p2S1K4oVXUFR += (((ulong)b & (ulong)127) << (7 * i_swLTPwQKofj9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_p2S1K4oVXUFR += (ulong)b << (7 * i_swLTPwQKofj9);
                            break;
                        }
                    }
                    count_s0hGO6CIw4NQ = (ushort)vuread_p2S1K4oVXUFR;
            // Read list items
            if (count_s0hGO6CIw4NQ > 0) {
                enumIntMapValues = new List<int>();
                int listValue_jiL9IgCxpkA8;
                for (int i_ieShFuh6uAXr = 0; i_ieShFuh6uAXr < count_s0hGO6CIw4NQ; i_ieShFuh6uAXr++) {
                    // Read Int list item
                listValue_jiL9IgCxpkA8 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_jiL9IgCxpkA8);
                }
            }
                o.EnumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
                for (int i_iT3aocBESTDC = 0; i_iT3aocBESTDC < enumIntMapKeys.Count; i_iT3aocBESTDC++) {
                    o.EnumIntMap[enumIntMapKeys[i_iT3aocBESTDC]] = enumIntMapValues[i_iT3aocBESTDC];
                }
                    return o;
                }
            case 16:
                {
                VIntVLongMapObject o = new VIntVLongMapObject();
                // MAP: VintVlongMap
                IList<int> vintVlongMapKeys = new List<int>();
                IList<long> vintVlongMapValues = new List<long>();
            // Read list item count
            ushort count_honRriCI6NyK;
                    ulong vuread_qJe38nO7uuPZ = 0;
                    for (int i_fCjmS6pMKpYq = 0; i_fCjmS6pMKpYq < 9; i_fCjmS6pMKpYq++) {
                        byte b = bytes[index++];
                        if (i_fCjmS6pMKpYq < 8) {
                            vuread_qJe38nO7uuPZ += (((ulong)b & (ulong)127) << (7 * i_fCjmS6pMKpYq));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qJe38nO7uuPZ += (ulong)b << (7 * i_fCjmS6pMKpYq);
                            break;
                        }
                    }
                    count_honRriCI6NyK = (ushort)vuread_qJe38nO7uuPZ;
            // Read list items
            if (count_honRriCI6NyK > 0) {
                vintVlongMapKeys = new List<int>();
                int listValue_czOm7ouQvsvP;
                for (int i_zIFFeGh8JyEZ = 0; i_zIFFeGh8JyEZ < count_honRriCI6NyK; i_zIFFeGh8JyEZ++) {
                    // Read VInt list item
    byte rvint_b_zp0axVayUYWI = bytes[index++];
    byte rvint_sign_oC9ga8D3hEoj = (byte)(rvint_b_zp0axVayUYWI & 1);
    byte rvint_size_lUHdi0RS5ZnS = (byte)(rvint_b_zp0axVayUYWI >> 1);
    ulong rvint_remaining_kutJs64jV76M = 0;
    for (int i_ob7K4KRFaQKM = 0; i_ob7K4KRFaQKM < rvint_size_lUHdi0RS5ZnS - 1; i_ob7K4KRFaQKM++) {
        rvint_remaining_kutJs64jV76M = rvint_remaining_kutJs64jV76M | (((ulong)bytes[index++] << (8 * i_ob7K4KRFaQKM)));
    }
    int rvint_result_f6q3hdNToqRQ = (int)rvint_remaining_kutJs64jV76M;
    rvint_result_f6q3hdNToqRQ = ~rvint_result_f6q3hdNToqRQ;
    if (rvint_result_f6q3hdNToqRQ == int.MaxValue) {
        rvint_result_f6q3hdNToqRQ = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_f6q3hdNToqRQ += 1;
        if (rvint_sign_oC9ga8D3hEoj == 0) {
            rvint_result_f6q3hdNToqRQ = -rvint_result_f6q3hdNToqRQ;
        }
    }
    listValue_czOm7ouQvsvP = rvint_result_f6q3hdNToqRQ;
                    vintVlongMapKeys.Add(listValue_czOm7ouQvsvP);
                }
            }
            // Read list item count
            ushort count_r4LkJfxCY5Gg;
                    ulong vuread_wgYuhSRSTQvw = 0;
                    for (int i_rbcSumxqtr59 = 0; i_rbcSumxqtr59 < 9; i_rbcSumxqtr59++) {
                        byte b = bytes[index++];
                        if (i_rbcSumxqtr59 < 8) {
                            vuread_wgYuhSRSTQvw += (((ulong)b & (ulong)127) << (7 * i_rbcSumxqtr59));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wgYuhSRSTQvw += (ulong)b << (7 * i_rbcSumxqtr59);
                            break;
                        }
                    }
                    count_r4LkJfxCY5Gg = (ushort)vuread_wgYuhSRSTQvw;
            // Read list items
            if (count_r4LkJfxCY5Gg > 0) {
                vintVlongMapValues = new List<long>();
                long listValue_zH55shYsAjaa;
                for (int i_gsMGJ968IpDH = 0; i_gsMGJ968IpDH < count_r4LkJfxCY5Gg; i_gsMGJ968IpDH++) {
                    // Read VLong list item
    byte rvlong_b_bPiMIpXKlYuJ = bytes[index++];
    byte rvlong_sign_uWzM1d5GbcCb = (byte)(rvlong_b_bPiMIpXKlYuJ & 1);
    byte rvlong_size_o0Rtv6AUdy2M = (byte)(rvlong_b_bPiMIpXKlYuJ >> 1);
    ulong rvlong_remaining_zmTkwzYA7cUX = 0;
    for (int i_ptgFt7GamhcR = 0; i_ptgFt7GamhcR < rvlong_size_o0Rtv6AUdy2M - 1; i_ptgFt7GamhcR++) {
        rvlong_remaining_zmTkwzYA7cUX = rvlong_remaining_zmTkwzYA7cUX | (((ulong)bytes[index++] << (8 * i_ptgFt7GamhcR)));
    }
    long rvlong_result_oDpoxKGy3WOP = (long)rvlong_remaining_zmTkwzYA7cUX;
    rvlong_result_oDpoxKGy3WOP = ~rvlong_result_oDpoxKGy3WOP;
    if (rvlong_result_oDpoxKGy3WOP == long.MaxValue) {
        rvlong_result_oDpoxKGy3WOP = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_oDpoxKGy3WOP += 1;
        if (rvlong_sign_uWzM1d5GbcCb == 0) {
            rvlong_result_oDpoxKGy3WOP = -rvlong_result_oDpoxKGy3WOP;
        }
    }
    listValue_zH55shYsAjaa = rvlong_result_oDpoxKGy3WOP;
                    vintVlongMapValues.Add(listValue_zH55shYsAjaa);
                }
            }
                o.VintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
                for (int i_iVkLncdGg4Tb = 0; i_iVkLncdGg4Tb < vintVlongMapKeys.Count; i_iVkLncdGg4Tb++) {
                    o.VintVlongMap[vintVlongMapKeys[i_iVkLncdGg4Tb]] = vintVlongMapValues[i_iVkLncdGg4Tb];
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new MapTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
