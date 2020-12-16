using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSyncResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipaldmpSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 关联结果：true-成功；false-失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
