using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceDataScenicSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceDataScenicSyncModel : AlipayObject
    {
        /// <summary>
        /// 服务商名称
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 服务商维护的景区地址
        /// </summary>
        [JsonPropertyName("isv_scenic_address")]
        public string IsvScenicAddress { get; set; }

        /// <summary>
        /// 服务商维护的景区名称
        /// </summary>
        [JsonPropertyName("isv_scenic_name")]
        public string IsvScenicName { get; set; }

        /// <summary>
        /// 服务商内部每个景区的唯一ID
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 服务商负责的景区小程序APPID
        /// </summary>
        [JsonPropertyName("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 支付宝景区ID
        /// </summary>
        [JsonPropertyName("scenic_id")]
        public string ScenicId { get; set; }
    }
}
