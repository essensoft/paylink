using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampBatchqueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动搜索列表
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
