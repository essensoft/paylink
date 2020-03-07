using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
