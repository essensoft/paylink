using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoSignflowsCreateResponse.
    /// </summary>
    public class AlipayEcoSignflowsCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 电子合同流程id（需记录到业务系统中，后续相关服务调用都基于此ID）
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
