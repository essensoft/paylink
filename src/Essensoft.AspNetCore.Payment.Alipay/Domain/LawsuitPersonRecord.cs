using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LawsuitPersonRecord Data Structure.
    /// </summary>
    public class LawsuitPersonRecord : AlipayObject
    {
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
