using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// LawsuitRecord Data Structure.
    /// </summary>
    public class LawsuitRecord : AlipayObject
    {
        /// <summary>
        /// 案件流程列表
        /// </summary>
        [JsonProperty("ajlc_list")]
        public List<EpInfo> AjlcList { get; set; }

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
        /// 法院公告列表
        /// </summary>
        [JsonProperty("fygg_list")]
        public List<EpInfo> FyggList { get; set; }

        /// <summary>
        /// 开庭公告列表
        /// </summary>
        [JsonProperty("ktgg_list")]
        public List<EpInfo> KtggList { get; set; }

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
