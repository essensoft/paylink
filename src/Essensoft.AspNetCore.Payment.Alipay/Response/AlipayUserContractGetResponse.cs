using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserContractGetResponse.
    /// </summary>
    public class AlipayUserContractGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户订购信息
        /// </summary>
        [JsonPropertyName("alipay_contract")]
        public AlipayContract AlipayContract { get; set; }
    }
}
