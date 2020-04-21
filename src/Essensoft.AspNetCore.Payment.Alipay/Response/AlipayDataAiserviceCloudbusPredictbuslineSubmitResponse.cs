using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineSubmitResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusSubmitPredictItem Result { get; set; }
    }
}
