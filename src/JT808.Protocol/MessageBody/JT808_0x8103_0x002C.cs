﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 缺省距离汇报间隔，单位为米（m），>0
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x002CFormatter))]
    public class JT808_0x8103_0x002C : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x002C;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// 缺省距离汇报间隔，单位为米（m），>0
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
