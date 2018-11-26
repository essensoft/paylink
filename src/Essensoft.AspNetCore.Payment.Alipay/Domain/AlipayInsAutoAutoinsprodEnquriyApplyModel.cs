using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodEnquriyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodEnquriyApplyModel : AlipayObject
    {
        /// <summary>
        /// 代理人身份信息
        /// </summary>
        [JsonProperty("agent")]
        [XmlElement("agent")]
        public InsPerson Agent { get; set; }

        /// <summary>
        /// 代理人userId
        /// </summary>
        [JsonProperty("agent_user_id")]
        [XmlElement("agent_user_id")]
        public string AgentUserId { get; set; }

        /// <summary>
        /// 投保人身份信息
        /// </summary>
        [JsonProperty("applicant")]
        [XmlElement("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [JsonProperty("car")]
        [XmlElement("car")]
        public Car Car { get; set; }

        /// <summary>
        /// 车主身份信息
        /// </summary>
        [JsonProperty("car_owner")]
        [XmlElement("car_owner")]
        public InsPerson CarOwner { get; set; }

        /// <summary>
        /// 投保城市编码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 被保人身份信息
        /// </summary>
        [JsonProperty("insured")]
        [XmlElement("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 外部询价申请业务单号（幂等字段）
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
