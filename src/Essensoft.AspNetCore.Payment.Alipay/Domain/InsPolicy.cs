using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsPolicy Data Structure.
    /// </summary>
    public class InsPolicy : AlipayObject
    {
        /// <summary>
        /// 保单邮寄地址
        /// </summary>
        [JsonPropertyName("addressee")]
        public InsAddressee Addressee { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 投保参数;标准json 格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 赔案
        /// </summary>
        [JsonPropertyName("claims")]
        public List<InsClaim> Claims { get; set; }

        /// <summary>
        /// 险种列表
        /// </summary>
        [JsonPropertyName("coverages")]
        public List<InsCoverage> Coverages { get; set; }

        /// <summary>
        /// 保单失效时间
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保单生效时间
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 标的列表
        /// </summary>
        [JsonPropertyName("ins_objects")]
        public List<InsObject> InsObjects { get; set; }

        /// <summary>
        /// 被保险人
        /// </summary>
        [JsonPropertyName("insureds")]
        public List<InsPerson> Insureds { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部保单号
        /// </summary>
        [JsonPropertyName("out_policy_no")]
        public string OutPolicyNo { get; set; }

        /// <summary>
        /// 终缴时间，用于健康险、寿险等场景，用户需要按期缴费使用
        /// </summary>
        [JsonPropertyName("pay_end_time")]
        public string PayEndTime { get; set; }

        /// <summary>
        /// 缴至时间，用于健康险、寿险等场景，用户需要按期缴费使用
        /// </summary>
        [JsonPropertyName("pay_to_time")]
        public string PayToTime { get; set; }

        /// <summary>
        /// 保单凭证号;蚂蚁保险平台生成的保单凭证号,用户可以通过此单号去保险公司查询保单信息.
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单状态.INEFFECTIVE:未生效、GUARANTEE:保障中、EXPIRED:已失效、SURRENDER:已退保
        /// </summary>
        [JsonPropertyName("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 保费 ;单位分
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 保额 ;单位分
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 退保金额
        /// </summary>
        [JsonPropertyName("surrender_fee")]
        public long SurrenderFee { get; set; }

        /// <summary>
        /// 退保时间
        /// </summary>
        [JsonPropertyName("surrender_time")]
        public string SurrenderTime { get; set; }
    }
}
