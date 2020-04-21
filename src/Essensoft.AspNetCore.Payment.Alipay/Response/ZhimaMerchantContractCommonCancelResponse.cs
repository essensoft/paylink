using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantContractCommonCancelResponse.
    /// </summary>
    public class ZhimaMerchantContractCommonCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果返回值
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 业务结果，成功或失败
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }
    }
}
