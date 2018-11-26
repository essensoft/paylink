using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserInfoAndBenefitQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class UserInfoAndBenefitQueryResult : AlipayObject
    {
        /// <summary>
        /// 用户的蚂蚁会员积分余额
        /// </summary>
        [JsonProperty("balance")]
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 蚂蚁会员权益配置信息列表
        /// </summary>
        [JsonProperty("benefit_info_list")]
        [XmlArray("benefit_info_list")]
        [XmlArrayItem("benefit_grade_point")]
        public List<BenefitGradePoint> BenefitInfoList { get; set; }

        /// <summary>
        /// 用户的蚂蚁会员等级
        /// </summary>
        [JsonProperty("grade")]
        [XmlElement("grade")]
        public string Grade { get; set; }
    }
}
