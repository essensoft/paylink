using System;
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
        public InsPerson Agent { get; set; }

        /// <summary>
        /// 中介(经办)组织信息
        /// </summary>
        [JsonProperty("agent_organization")]
        public AgentOrganization AgentOrganization { get; set; }

        /// <summary>
        /// 技术对接主体组织信息,技术isv
        /// </summary>
        [JsonProperty("agent_tech_organization")]
        public AgentOrganization AgentTechOrganization { get; set; }

        /// <summary>
        /// 代理人userId
        /// </summary>
        [JsonProperty("agent_user_id")]
        public string AgentUserId { get; set; }

        /// <summary>
        /// 投保人身份信息
        /// </summary>
        [JsonProperty("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 机构投保业务归属地信息
        /// </summary>
        [JsonProperty("apply_business_city")]
        public ApplyBusinessCity ApplyBusinessCity { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [JsonProperty("car")]
        public Car Car { get; set; }

        /// <summary>
        /// 车主身份信息
        /// </summary>
        [JsonProperty("car_owner")]
        public InsPerson CarOwner { get; set; }

        /// <summary>
        /// 投保城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 被保人身份信息
        /// </summary>
        [JsonProperty("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 外部询价申请业务单号（幂等字段）
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
