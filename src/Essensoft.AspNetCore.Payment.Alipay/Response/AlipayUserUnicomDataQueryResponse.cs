using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserUnicomDataQueryResponse.
    /// </summary>
    public class AlipayUserUnicomDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁宝卡流量余额，单位M
        /// </summary>
        [JsonPropertyName("data_balance")]
        public long DataBalance { get; set; }
    }
}
