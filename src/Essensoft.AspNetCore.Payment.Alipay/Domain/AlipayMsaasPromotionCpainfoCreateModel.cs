using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasPromotionCpainfoCreateModel Data Structure.
    /// </summary>
    public class AlipayMsaasPromotionCpainfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 唯一应用
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// bundle_id
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 调试数据
        /// </summary>
        [JsonPropertyName("debug")]
        public string Debug { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// IDFA
        /// </summary>
        [JsonPropertyName("idfa")]
        public string Idfa { get; set; }

        /// <summary>
        /// IOS版本
        /// </summary>
        [JsonPropertyName("ios_version")]
        public string IosVersion { get; set; }

        /// <summary>
        /// MAC
        /// </summary>
        [JsonPropertyName("mac")]
        public string Mac { get; set; }
    }
}
