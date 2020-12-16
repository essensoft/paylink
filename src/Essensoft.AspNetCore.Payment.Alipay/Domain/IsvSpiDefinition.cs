using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvSpiDefinition Data Structure.
    /// </summary>
    public class IsvSpiDefinition : AlipayObject
    {
        /// <summary>
        /// ISV自定义的标识功能的业务代码，不可重复
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// spi功能描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 功能图标文件url
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// spi接口服务地址
        /// </summary>
        [JsonPropertyName("spi_endpoint")]
        public string SpiEndpoint { get; set; }

        /// <summary>
        /// spi接口扩展参数，json格式字符串
        /// </summary>
        [JsonPropertyName("spi_ext_property")]
        public string SpiExtProperty { get; set; }

        /// <summary>
        /// CCM预先定义的spi key，与插件位置有关
        /// </summary>
        [JsonPropertyName("spi_key")]
        public string SpiKey { get; set; }

        /// <summary>
        /// SPI 名称
        /// </summary>
        [JsonPropertyName("spi_name")]
        public string SpiName { get; set; }
    }
}
