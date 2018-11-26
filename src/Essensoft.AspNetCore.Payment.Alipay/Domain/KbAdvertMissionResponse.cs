using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertMissionResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertMissionResponse : AlipayObject
    {
        /// <summary>
        /// 任务领取时间
        /// </summary>
        [JsonProperty("gmt_claimed")]
        [XmlElement("gmt_claimed")]
        public string GmtClaimed { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("gmt_end")]
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonProperty("gmt_start")]
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("mission_id")]
        [XmlElement("mission_id")]
        public string MissionId { get; set; }

        /// <summary>
        /// 推广状态  EFFECTIVE-有效  INVALID-无效
        /// </summary>
        [JsonProperty("promote_status")]
        [XmlElement("promote_status")]
        public string PromoteStatus { get; set; }

        /// <summary>
        /// 任务标的列表
        /// </summary>
        [JsonProperty("subjects")]
        [XmlArray("subjects")]
        [XmlArrayItem("kb_advert_subject_response")]
        public List<KbAdvertSubjectResponse> Subjects { get; set; }
    }
}
