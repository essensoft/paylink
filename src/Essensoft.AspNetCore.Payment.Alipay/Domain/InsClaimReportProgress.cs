using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaimReportProgress Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimReportProgress : AlipayObject
    {
        /// <summary>
        /// 案件更新内容
        /// </summary>
        [JsonProperty("progress_update_content")]
        [XmlElement("progress_update_content")]
        public string ProgressUpdateContent { get; set; }

        /// <summary>
        /// 案件更新进度时间
        /// </summary>
        [JsonProperty("progress_update_time")]
        [XmlElement("progress_update_time")]
        public string ProgressUpdateTime { get; set; }

        /// <summary>
        /// 进度状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
