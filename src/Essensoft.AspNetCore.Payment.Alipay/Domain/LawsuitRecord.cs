using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LawsuitRecord Data Structure.
    /// </summary>
    public class LawsuitRecord : AlipayObject
    {
        /// <summary>
        /// 案件流程列表
        /// </summary>
        [JsonPropertyName("ajlc_list")]
        public List<EpInfo> AjlcList { get; set; }

        /// <summary>
        /// 曝光台列表
        /// </summary>
        [JsonPropertyName("bgt_list")]
        public List<EpInfo> BgtList { get; set; }

        /// <summary>
        /// 裁判文书列表
        /// </summary>
        [JsonPropertyName("cpws_list")]
        public List<EpInfo> CpwsList { get; set; }

        /// <summary>
        /// 法院公告列表
        /// </summary>
        [JsonPropertyName("fygg_list")]
        public List<EpInfo> FyggList { get; set; }

        /// <summary>
        /// 开庭公告列表
        /// </summary>
        [JsonPropertyName("ktgg_list")]
        public List<EpInfo> KtggList { get; set; }

        /// <summary>
        /// 失信公告列表
        /// </summary>
        [JsonPropertyName("sxgg_list")]
        public List<EpInfo> SxggList { get; set; }

        /// <summary>
        /// 执行公告列表
        /// </summary>
        [JsonPropertyName("zxgg_list")]
        public List<EpInfo> ZxggList { get; set; }
    }
}
