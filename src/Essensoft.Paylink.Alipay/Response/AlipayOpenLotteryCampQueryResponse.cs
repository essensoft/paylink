using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampQueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果，活动详情
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
