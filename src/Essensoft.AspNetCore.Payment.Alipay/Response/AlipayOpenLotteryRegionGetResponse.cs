using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionGetResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionGetResponse : AlipayResponse
    {
        /// <summary>
        /// 入驻商家专区信息
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
