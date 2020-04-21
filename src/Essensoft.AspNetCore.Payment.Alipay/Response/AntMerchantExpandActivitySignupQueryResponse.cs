using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandActivitySignupQueryResponse.
    /// </summary>
    public class AntMerchantExpandActivitySignupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 接口返回描述：e.g.报名失败:没有报名资格/报名成功/报名确认
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝商户ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 报名接口状态，SUCCESS成功，FAIL失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
