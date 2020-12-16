using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceDetailQueryResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业财受理详情查询结果
        /// </summary>
        [JsonPropertyName("result")]
        public GFAOpenAPIDetailQueryResult Result { get; set; }
    }
}
