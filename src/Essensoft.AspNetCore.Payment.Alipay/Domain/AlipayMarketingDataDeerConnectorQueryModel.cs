using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDeerConnectorQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDeerConnectorQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动洞察数据查询标识
        /// </summary>
        [JsonPropertyName("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 数据请求的参数，比如活动投放日期、投放渠道等信息
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }
    }
}
