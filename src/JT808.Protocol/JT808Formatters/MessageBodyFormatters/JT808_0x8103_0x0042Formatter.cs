﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.JT808Formatters.MessageBodyFormatters
{
    public class JT808_0x8103_0x0042Formatter : IJT808Formatter<JT808_0x8103_0x0042>
    {
        public JT808_0x8103_0x0042 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT808_0x8103_0x0042 jT808_0x8103_0x0042 = new JT808_0x8103_0x0042();
            jT808_0x8103_0x0042.ParamLength = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0x8103_0x0042.ParamValue = JT808BinaryExtensions.ReadStringLittle(bytes, ref offset, jT808_0x8103_0x0042.ParamLength);
            readSize = offset;
            return jT808_0x8103_0x0042;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8103_0x0042 value)
        {
            offset += 1;
            var lenth = JT808BinaryExtensions.WriteStringLittle(bytes, offset, value.ParamValue);         
            JT808BinaryExtensions.WriteByteLittle(bytes, offset-1, (byte)lenth);
            offset += lenth;
            return offset;
        }
    }
}