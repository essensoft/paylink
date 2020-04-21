using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncPidUnwriteoffQueryResponse.
    /// </summary>
    public class AlipayBossFncPidUnwriteoffQueryResponse : AlipayResponse
    {
        /// <summary>
        /// true表示正在核销，false表示当前没有核销的单据
        /// </summary>
        [JsonPropertyName("result_set")]
        public string ResultSet { get; set; }
    }
}
