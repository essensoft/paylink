using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasOpenAccountConsultResponse.
    /// </summary>
    public class AlipayOverseasOpenAccountConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 账号
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// isv请求结果
        /// </summary>
        [JsonPropertyName("result")]
        public TuitionISVResult Result { get; set; }
    }
}
