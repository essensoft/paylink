using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppRechargeUserDetectResponse.
    /// </summary>
    public class AlipayEbppRechargeUserDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是合法用户
        /// </summary>
        [JsonPropertyName("check_result")]
        public bool CheckResult { get; set; }
    }
}
