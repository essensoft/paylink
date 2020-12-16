using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSetResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipaldmpSetResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果：true-成功；false-失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
