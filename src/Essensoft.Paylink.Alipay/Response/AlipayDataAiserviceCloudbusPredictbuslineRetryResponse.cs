using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineRetryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineRetryResponse : AlipayResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusRetryPredictItem Result { get; set; }
    }
}
