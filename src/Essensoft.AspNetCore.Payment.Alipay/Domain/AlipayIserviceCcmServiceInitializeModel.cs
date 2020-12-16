using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServiceInitializeModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmServiceInitializeModel : AlipayObject
    {
        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务图标url
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务订购二维码链接
        /// </summary>
        [JsonPropertyName("service_order_url")]
        public string ServiceOrderUrl { get; set; }

        /// <summary>
        /// spi定义列表
        /// </summary>
        [JsonPropertyName("spis")]
        public List<IsvSpiDefinition> Spis { get; set; }
    }
}
