using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeCustomsQueryModel Data Structure.
    /// </summary>
    public class AlipayTradeCustomsQueryModel : AlipayObject
    {
        /// <summary>
        /// 报关请求号。需要查询的商户端报关请求号，支持批量查询，  多个值用英文半角逗号分隔，单次请求最多10个;
        /// </summary>
        [JsonPropertyName("out_request_nos")]
        public string OutRequestNos { get; set; }
    }
}
