using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAgentCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
