using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
