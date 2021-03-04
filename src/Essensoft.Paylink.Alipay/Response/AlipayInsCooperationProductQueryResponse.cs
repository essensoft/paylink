using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQueryResponse.
    /// </summary>
    public class AlipayInsCooperationProductQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保险产品
        /// </summary>
        [JsonPropertyName("product")]
        public InsProduct Product { get; set; }
    }
}
