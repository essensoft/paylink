using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PubChannelDTO Data Structure.
    /// </summary>
    public class PubChannelDTO : AlipayObject
    {
        /// <summary>
        /// 扩展信息，无需配置
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 1、SHOP_DETAIL:店铺详情页   2、PAYMENT_RESULT: 支付成功页（支付成功页暂不支持）
        /// </summary>
        [JsonPropertyName("pub_channel")]
        public string PubChannel { get; set; }
    }
}
