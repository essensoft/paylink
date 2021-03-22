using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
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
        /// 服务图标url。支持 http(s) 链接。
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 服务编码。可在服务上架后，在服务市场上查询此信息。
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称。可在服务上架后，在服务市场上查询此信息。
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
