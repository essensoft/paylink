using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenDesCreateResponse.
    /// </summary>
    public class AlipayOpenDesCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("ces")]
        public GavintestNewLeveaOne Ces { get; set; }
    }
}
