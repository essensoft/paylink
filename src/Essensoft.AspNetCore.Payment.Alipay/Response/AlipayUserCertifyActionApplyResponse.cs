using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertifyActionApplyResponse.
    /// </summary>
    public class AlipayUserCertifyActionApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回给商户的支付宝业务ID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }
    }
}
