using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetrodetailQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetrodetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public MetroOdDetailResult Result { get; set; }
    }
}
