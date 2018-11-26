using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsPolicy Data Structure.
    /// </summary>
    [Serializable]
    public class InsPolicy : AlipayObject
    {
        /// <summary>
        /// 保单邮寄地址
        /// </summary>
        [JsonProperty("addressee")]
        [XmlElement("addressee")]
        public InsAddressee Addressee { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [JsonProperty("applicant")]
        [XmlElement("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 投保参数;标准json 格式
        /// </summary>
        [JsonProperty("biz_data")]
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 赔案
        /// </summary>
        [JsonProperty("claims")]
        [XmlArray("claims")]
        [XmlArrayItem("ins_claim")]
        public List<InsClaim> Claims { get; set; }

        /// <summary>
        /// 险种列表
        /// </summary>
        [JsonProperty("coverages")]
        [XmlArray("coverages")]
        [XmlArrayItem("ins_coverage")]
        public List<InsCoverage> Coverages { get; set; }

        /// <summary>
        /// 保单失效时间
        /// </summary>
        [JsonProperty("effect_end_time")]
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保单生效时间
        /// </summary>
        [JsonProperty("effect_start_time")]
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 标的列表
        /// </summary>
        [JsonProperty("ins_objects")]
        [XmlArray("ins_objects")]
        [XmlArrayItem("ins_object")]
        public List<InsObject> InsObjects { get; set; }

        /// <summary>
        /// 被保险人
        /// </summary>
        [JsonProperty("insureds")]
        [XmlArray("insureds")]
        [XmlArrayItem("ins_person")]
        public List<InsPerson> Insureds { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [JsonProperty("merchant_name")]
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部保单号
        /// </summary>
        [JsonProperty("out_policy_no")]
        [XmlElement("out_policy_no")]
        public string OutPolicyNo { get; set; }

        /// <summary>
        /// 终缴时间，用于健康险、寿险等场景，用户需要按期缴费使用
        /// </summary>
        [JsonProperty("pay_end_time")]
        [XmlElement("pay_end_time")]
        public string PayEndTime { get; set; }

        /// <summary>
        /// 缴至时间，用于健康险、寿险等场景，用户需要按期缴费使用
        /// </summary>
        [JsonProperty("pay_to_time")]
        [XmlElement("pay_to_time")]
        public string PayToTime { get; set; }

        /// <summary>
        /// 保单凭证号;蚂蚁保险平台生成的保单凭证号,用户可以通过此单号去保险公司查询保单信息.
        /// </summary>
        [JsonProperty("policy_no")]
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单状态.INEFFECTIVE:未生效、GUARANTEE:保障中、EXPIRED:已失效、SURRENDER:已退保
        /// </summary>
        [JsonProperty("policy_status")]
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 保费 ;单位分
        /// </summary>
        [JsonProperty("premium")]
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("prod_name")]
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 保额 ;单位分
        /// </summary>
        [JsonProperty("sum_insured")]
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 退保金额
        /// </summary>
        [JsonProperty("surrender_fee")]
        [XmlElement("surrender_fee")]
        public long SurrenderFee { get; set; }

        /// <summary>
        /// 退保时间
        /// </summary>
        [JsonProperty("surrender_time")]
        [XmlElement("surrender_time")]
        public string SurrenderTime { get; set; }
    }
}
