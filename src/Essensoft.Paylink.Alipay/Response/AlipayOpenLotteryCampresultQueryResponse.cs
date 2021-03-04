using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampresultQueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中奖结果名单
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
