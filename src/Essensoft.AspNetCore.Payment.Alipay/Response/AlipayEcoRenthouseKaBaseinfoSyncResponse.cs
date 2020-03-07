using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回kaCode唯一标识,用户查询ka信息时候用
        /// </summary>
        [JsonPropertyName("ka_code")]
        public string KaCode { get; set; }
    }
}
