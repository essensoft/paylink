using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserAnalysisData Data Structure.
    /// </summary>
    [Serializable]
    public class UserAnalysisData : AlipayObject
    {
        /// <summary>
        /// 取消关注人数
        /// </summary>
        [JsonProperty("cancel_user_cnt")]
        [XmlElement("cancel_user_cnt")]
        public string CancelUserCnt { get; set; }

        /// <summary>
        /// 累积关注人数
        /// </summary>
        [JsonProperty("cumulate_user_cnt")]
        [XmlElement("cumulate_user_cnt")]
        public string CumulateUserCnt { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("date")]
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 净增关注人数
        /// </summary>
        [JsonProperty("grow_user_cnt")]
        [XmlElement("grow_user_cnt")]
        public string GrowUserCnt { get; set; }

        /// <summary>
        /// 新关注人数
        /// </summary>
        [JsonProperty("new_user_cnt")]
        [XmlElement("new_user_cnt")]
        public string NewUserCnt { get; set; }
    }
}
