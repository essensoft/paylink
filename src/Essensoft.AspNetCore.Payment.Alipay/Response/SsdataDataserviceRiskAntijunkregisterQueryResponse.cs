using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAntijunkregisterQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAntijunkregisterQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风险解释，即本次风险评分中TOP 3，信息代码、风险因子代码、风险因子名、风险描述。详情请参考
        /// </summary>
        [JsonPropertyName("infocode")]
        public string Infocode { get; set; }

        /// <summary>
        /// 基于传入的介质参数，计算得到的垃圾注册风险分，范围[0,100],分数越高风险程度越高
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 用户唯一请求ID
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
