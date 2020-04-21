using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodEnquriyApplyModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodEnquriyApplyModel : AlipayObject
    {
        /// <summary>
        /// 代理人身份信息
        /// </summary>
        [JsonPropertyName("agent")]
        public InsPerson Agent { get; set; }

        /// <summary>
        /// 中介(经办)组织信息
        /// </summary>
        [JsonPropertyName("agent_organization")]
        public AgentOrganization AgentOrganization { get; set; }

        /// <summary>
        /// 技术对接主体组织信息,技术isv
        /// </summary>
        [JsonPropertyName("agent_tech_organization")]
        public AgentOrganization AgentTechOrganization { get; set; }

        /// <summary>
        /// 代理人userId
        /// </summary>
        [JsonPropertyName("agent_user_id")]
        public string AgentUserId { get; set; }

        /// <summary>
        /// 投保人身份信息
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 机构投保业务归属地信息
        /// </summary>
        [JsonPropertyName("apply_business_city")]
        public ApplyBusinessCity ApplyBusinessCity { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [JsonPropertyName("car")]
        public Car Car { get; set; }

        /// <summary>
        /// 车主身份信息
        /// </summary>
        [JsonPropertyName("car_owner")]
        public InsPerson CarOwner { get; set; }

        /// <summary>
        /// 投保城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 被保人身份信息
        /// </summary>
        [JsonPropertyName("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 外部询价申请业务单号（幂等字段）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
