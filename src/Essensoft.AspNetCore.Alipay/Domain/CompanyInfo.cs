using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// CompanyInfo Data Structure.
    /// </summary>
    public class CompanyInfo : AlipayObject
    {
        /// <summary>
        /// 企业历史变更信息
        /// </summary>
        [JsonProperty("alter_list")]
        public List<EpInfo> AlterList { get; set; }

        /// <summary>
        /// 企业工商照面信息
        /// </summary>
        [JsonProperty("basic_info")]
        public EpInfo BasicInfo { get; set; }

        /// <summary>
        /// 企业行政处罚信息
        /// </summary>
        [JsonProperty("case_info_list")]
        public List<EpInfo> CaseInfoList { get; set; }

        /// <summary>
        /// 企业对外投资信息
        /// </summary>
        [JsonProperty("entinv_list")]
        public List<EpInfo> EntinvList { get; set; }

        /// <summary>
        /// 企业法定代表人在其他公司任职信息
        /// </summary>
        [JsonProperty("fr_position_list")]
        public List<EpInfo> FrPositionList { get; set; }

        /// <summary>
        /// 企业法定代表人对外投资信息
        /// </summary>
        [JsonProperty("frinv_list")]
        public List<EpInfo> FrinvList { get; set; }

        /// <summary>
        /// 企业主要管理人员信息
        /// </summary>
        [JsonProperty("person_list")]
        public List<EpInfo> PersonList { get; set; }

        /// <summary>
        /// 企业股东及出资信息
        /// </summary>
        [JsonProperty("share_holder_list")]
        public List<EpInfo> ShareHolderList { get; set; }
    }
}
