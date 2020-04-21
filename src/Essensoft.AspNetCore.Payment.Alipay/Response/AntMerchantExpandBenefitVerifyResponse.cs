using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandBenefitVerifyResponse.
    /// </summary>
    public class AntMerchantExpandBenefitVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展的业务信息
        /// </summary>
        [JsonPropertyName("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 核销结果 true/false
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
