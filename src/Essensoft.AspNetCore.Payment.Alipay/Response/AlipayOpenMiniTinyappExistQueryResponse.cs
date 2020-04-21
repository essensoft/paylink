using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTinyappExistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是小程序开发者
        /// </summary>
        [JsonPropertyName("exist_mini")]
        public string ExistMini { get; set; }
    }
}
