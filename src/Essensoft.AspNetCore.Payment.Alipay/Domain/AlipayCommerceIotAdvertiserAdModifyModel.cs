using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdModifyModel : AlipayObject
    {
        /// <summary>
        /// 下线SN列表
        /// </summary>
        [JsonPropertyName("delete_sn_list")]
        public List<string> DeleteSnList { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
