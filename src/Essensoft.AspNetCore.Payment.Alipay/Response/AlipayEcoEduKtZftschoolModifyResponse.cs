using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtZftschoolModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 进件单号id，查询进件接口输入参数
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
