using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataServiceOpenAnalyzeResponse.
    /// </summary>
    public class AlipayDataServiceOpenAnalyzeResponse : AlipayResponse
    {
        /// <summary>
        /// 调用返回
        /// </summary>
        [JsonPropertyName("result")]
        public AlipayDataServiceResult Result { get; set; }
    }
}
