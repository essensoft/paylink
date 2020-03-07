using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPortraitQueryModel Data Structure.
    /// </summary>
    public class AlipayUserPortraitQueryModel : AlipayObject
    {
        /// <summary>
        /// 1688端传递havanaId的列表过来，单次传递不超过2个
        /// </summary>
        [JsonPropertyName("havana_id")]
        public List<string> HavanaId { get; set; }
    }
}
