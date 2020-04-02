using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdAntlawOrderhitstatusQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlawOrderhitstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否存在有效的纸质用印, true表示存在, false表示不存在
        /// </summary>
        [JsonPropertyName("hit_result")]
        public bool HitResult { get; set; }
    }
}
