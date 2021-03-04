using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictresultQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预测线路结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusPredictResult Result { get; set; }
    }
}
