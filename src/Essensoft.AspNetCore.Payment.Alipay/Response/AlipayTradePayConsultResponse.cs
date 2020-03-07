using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePayConsultResponse.
    /// </summary>
    public class AlipayTradePayConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息，必须是json格式
        /// </summary>
        [JsonPropertyName("extend_infos")]
        public string ExtendInfos { get; set; }

        /// <summary>
        /// 参考结果。AVAILABLE：可用；UNAVAILABLE：不可用。针对不关注该字段的商户，返回为空。
        /// </summary>
        [JsonPropertyName("refer_result")]
        public string ReferResult { get; set; }

        /// <summary>
        /// 结果代码: refer_result为UNAVAILABLE时，非空。  USER_ZHIMA_AUTH_REFUSED：用户芝麻信用未授权给支付宝；  USER_ZHIMA_SCORE_REFUSED：用户芝麻分不准入；  USER_ENJOYPAY_NOT_SIGNED：用户未签约先享后付；  ENJOYPAY_AVAILABLE_AMOUNT_NOT_ENOUGH：先享后付可用额度不足；  USER_CREDIT_HAD_FREEZEN：用户授信额度被冻结
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息: refer_result为UNAVAILABLE时，非空。描述信息与result_code对应。
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
