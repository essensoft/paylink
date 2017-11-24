using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// LawsuitPersonRecord Data Structure.
    /// </summary>
    public class LawsuitPersonRecord : AlipayObject
    {
        /// <summary>
        /// 曝光台列表
        /// </summary>
        [JsonProperty("bgt_list")]
        public List<EpInfo> BgtList { get; set; }

        /// <summary>
        /// 裁判文书列表
        /// </summary>
        [JsonProperty("cpws_list")]
        public List<EpInfo> CpwsList { get; set; }

        /// <summary>
        /// 失信公告列表
        /// </summary>
        [JsonProperty("sxgg_list")]
        public List<EpInfo> SxggList { get; set; }

        /// <summary>
        /// 执行公告列表
        /// </summary>
        [JsonProperty("zxgg_list")]
        public List<EpInfo> ZxggList { get; set; }
    }
}
