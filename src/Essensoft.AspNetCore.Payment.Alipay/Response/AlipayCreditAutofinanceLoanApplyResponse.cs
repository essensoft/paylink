using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanApplyResponse.
    /// </summary>
    public class AlipayCreditAutofinanceLoanApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 汽车金融内部订单号
        /// </summary>
        [JsonPropertyName("applyno")]
        public string Applyno { get; set; }

        /// <summary>
        /// 是否需要引导认证
        /// </summary>
        [JsonPropertyName("needauth")]
        public bool Needauth { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("outorderno")]
        public string Outorderno { get; set; }
    }
}
