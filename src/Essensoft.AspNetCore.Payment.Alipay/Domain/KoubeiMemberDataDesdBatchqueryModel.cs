using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMemberDataDesdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("desd")]
        public GavintestNewLeveaOne Desd { get; set; }
    }
}
