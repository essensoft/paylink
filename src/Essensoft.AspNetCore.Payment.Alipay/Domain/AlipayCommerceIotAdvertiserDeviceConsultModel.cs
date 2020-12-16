using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceConsultModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceConsultModel : AlipayObject
    {
        /// <summary>
        /// sn列表，最多100个
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<string> SnList { get; set; }
    }
}
