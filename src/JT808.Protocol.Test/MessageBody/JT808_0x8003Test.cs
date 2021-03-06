﻿using System.Text;
using Xunit;
using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;

namespace JT808.Protocol.Test.MessageBodyRequest
{
    public  class JT808_0x8003Test : JT808PackageBase
    {
        [Fact]
        public void Test1()
        {
            JT808_0x8003 jT808_0X8003 = new JT808_0x8003
            {
                OriginalMsgNum = 1234,
                AgainPackageData = new byte[] { 0x01, 0x02, 0x02, 0x03 }
            };
            var hex = JT808Serializer.Serialize(jT808_0X8003).ToHexString();
            Assert.Equal("04D20201020203", hex);
        }

        [Fact]
        public void Test2()
        {
            var bytes = "04D20201020203".ToHexBytes();
            JT808_0x8003 jT808_0X8003 = JT808Serializer.Deserialize<JT808_0x8003>(bytes);
            Assert.Equal(1234, jT808_0X8003.OriginalMsgNum);
            Assert.Equal(new byte[] { 0x01, 0x02, 0x02, 0x03 }, jT808_0X8003.AgainPackageData);
            Assert.Equal(2, jT808_0X8003.AgainPackageCount);
        }
    }
}
