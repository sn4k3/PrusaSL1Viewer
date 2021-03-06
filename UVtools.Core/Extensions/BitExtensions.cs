﻿/*
 *                     GNU AFFERO GENERAL PUBLIC LICENSE
 *                       Version 3, 19 November 2007
 *  Copyright (C) 2007 Free Software Foundation, Inc. <https://fsf.org/>
 *  Everyone is permitted to copy and distribute verbatim copies
 *  of this license document, but changing it is not allowed.
 */
namespace UVtools.Core.Extensions
{
    public static class BitExtensions
    {
        public static ushort ToUShortLittleEndian(byte byte1, byte byte2) => (ushort)(byte1 + (byte2 << 8));
        public static ushort ToUShortBigEndian(byte byte1, byte byte2) => (ushort)((byte1 << 8) + byte2);

        public static ushort ToUShortLittleEndian(byte[] buffer, int offset = 0)
            => (ushort)(buffer[offset] + (buffer[offset+1] << 8));
        public static ushort ToUShortBigEndian(byte[] buffer, int offset = 0)
            => (ushort)((buffer[offset] << 8) + buffer[offset+1]);

        public static uint ToUIntLittleEndian(byte byte1, byte byte2, byte byte3, byte byte4) 
            => (uint)(byte1 + (byte2 << 8) + (byte3 << 16) + (byte4 << 24));
        public static uint ToUIntBigEndian(byte byte1, byte byte2, byte byte3, byte byte4) 
            => (uint)((byte1 << 24) + (byte1 << 16) + (byte1 << 8) + byte2);

        public static uint ToUIntLittleEndian(byte[] buffer, int offset = 0)
            => (uint)(buffer[offset] + (buffer[offset + 1] << 8) + (buffer[offset + 2] << 16) + (buffer[offset + 3] << 24));
        public static uint ToUIntBigEndian(byte[] buffer, int offset = 0)
            => (uint)((buffer[offset] << 24) + (buffer[offset+1] << 16) + (buffer[offset+2] << 8) + buffer[offset+3]);

        public static byte[] ToBytesLittleEndian(ushort value)
        {
            var bytes = new byte[2];
            ToBytesLittleEndian(value, bytes);
            return bytes;
        }

        public static void ToBytesLittleEndian(ushort value, byte[] buffer, uint offset = 0)
        {
            buffer[offset] = (byte)value;
            buffer[offset + 1] = (byte)(value >> 8);
        }

        public static byte[] ToBytesBigEndian(ushort value)
        {
            var bytes = new byte[2];
            ToBytesBigEndian(value, bytes);
            return bytes;
        }

        public static void ToBytesBigEndian(ushort value, byte[] buffer, uint offset = 0)
        {
            buffer[offset] = (byte)(value >> 8);
            buffer[offset + 1] = (byte)value;
        }

        public static byte[] ToBytesLittleEndian(uint value)
        {
            var bytes = new byte[4];
            ToBytesLittleEndian(value, bytes);
            return bytes;
        }

        public static void ToBytesLittleEndian(uint value, byte[] buffer, uint offset = 0)
        {
            buffer[offset] = (byte)value;
            buffer[offset + 1] = (byte)(value >> 8);
            buffer[offset + 2] = (byte)(value >> 16);
            buffer[offset + 3] = (byte)(value >> 24);
        }

        public static byte[] ToBytesBigEndian(uint value)
        {
            var bytes = new byte[4];
            ToBytesBigEndian(value, bytes);
            return bytes;
        }

        public static void ToBytesBigEndian(uint value, byte[] buffer, uint offset = 0)
        {
            buffer[offset] = (byte)(value >> 24);
            buffer[offset + 1] = (byte)(value >> 16);
            buffer[offset + 2] = (byte)(value >> 8);
            buffer[offset + 3] = (byte)value;
        }


    }
}
