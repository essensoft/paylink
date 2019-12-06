using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeSettleReceivablesQueryModel Data Structure.
    /// </summary>
    public class AlipayTradeSettleReceivablesQueryModel : AlipayObject
    {
        /// <summary>
        /// 收单产品码，商家和支付宝签约的产品码
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public SettleEntity MerchantInfo { get; set; }

        /// <summary>
        /// 外部请求号，32个字符以内，可包含字母、数字、下划线。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
