using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CompanyRole Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyRole : AlipayObject
    {
        /// <summary>
        /// 自然人担任企业法人的企业信息
        /// </summary>
        [JsonProperty("ry_pos_fr_list")]
        public List<EpInfo> RyPosFrList { get; set; }

        /// <summary>
        /// 自然人担任股东的企业信息
        /// </summary>
        [JsonProperty("ry_pos_sha_list")]
        public List<EpInfo> RyPosShaList { get; set; }

        /// <summary>
        /// 自然人担任主要管理人员的企业信息
        /// </summary>
        [JsonProperty("share_holder_list")]
        public List<EpInfo> ShareHolderList { get; set; }
    }
}
