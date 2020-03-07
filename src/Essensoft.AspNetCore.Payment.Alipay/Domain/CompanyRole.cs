using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CompanyRole Data Structure.
    /// </summary>
    public class CompanyRole : AlipayObject
    {
        /// <summary>
        /// 自然人担任企业法人的企业信息
        /// </summary>
        [JsonPropertyName("ry_pos_fr_list")]
        public List<EpInfo> RyPosFrList { get; set; }

        /// <summary>
        /// 自然人担任股东的企业信息
        /// </summary>
        [JsonPropertyName("ry_pos_sha_list")]
        public List<EpInfo> RyPosShaList { get; set; }

        /// <summary>
        /// 自然人担任主要管理人员的企业信息
        /// </summary>
        [JsonPropertyName("share_holder_list")]
        public List<EpInfo> ShareHolderList { get; set; }
    }
}
