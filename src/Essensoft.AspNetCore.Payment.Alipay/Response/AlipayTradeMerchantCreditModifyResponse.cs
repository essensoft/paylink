using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeMerchantCreditModifyResponse.
    /// </summary>
    public class AlipayTradeMerchantCreditModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 当前最大信用额度
        /// </summary>
        [JsonPropertyName("current_credit_quota")]
        public string CurrentCreditQuota { get; set; }

        /// <summary>
        /// 卖家已经授权拆分给到买家的赊账额度
        /// </summary>
        [JsonPropertyName("granted_credit_quota")]
        public string GrantedCreditQuota { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
