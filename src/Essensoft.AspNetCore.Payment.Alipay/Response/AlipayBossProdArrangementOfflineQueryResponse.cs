using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdArrangementOfflineQueryResponse.
    /// </summary>
    public class AlipayBossProdArrangementOfflineQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户的签约状态
        /// </summary>
        [JsonPropertyName("sign_status")]
        public string SignStatus { get; set; }
    }
}
