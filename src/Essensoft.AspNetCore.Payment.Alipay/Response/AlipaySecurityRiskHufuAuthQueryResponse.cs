using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHufuAuthQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务系统创建时传入的序列号
        /// </summary>
        [JsonPropertyName("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// 接入业务系统生成虎符时传入的uid
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 接入业务系统传入的通过验证的用户信息
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; }
    }
}
