using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中再核保模型查询结果
        /// </summary>
        [JsonPropertyName("result")]
        public AlipayChinareModelResult Result { get; set; }
    }
}
