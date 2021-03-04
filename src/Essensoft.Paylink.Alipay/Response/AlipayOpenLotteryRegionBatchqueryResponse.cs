using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商家入驻专区列表
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
