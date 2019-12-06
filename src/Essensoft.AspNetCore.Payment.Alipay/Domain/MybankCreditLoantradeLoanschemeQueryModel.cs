using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanschemeQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeLoanschemeQueryModel : AlipayObject
    {
        /// <summary>
        /// 授信编号
        /// </summary>
        [JsonPropertyName("biz")]
        public string Biz { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 客户身份编码-个人是身份证号码、企业是工商注册号、会员是会员编号-具体的数字编号
        /// </summary>
        [JsonPropertyName("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 客户身份标识-个人是姓名、企业是公司名称、会员是会员名称，如支付宝的手机号或者邮箱号
        /// </summary>
        [JsonPropertyName("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 客户身份类型-个人是PERSON、企业是COMPAY、会员是具体的站点如ALIPAY或者MYBANK
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 微贷政策码
        /// </summary>
        [JsonPropertyName("loan_policy_code")]
        public string LoanPolicyCode { get; set; }

        /// <summary>
        /// 外部产品码，外部机构与网商合作的方案产品码，用于标识所属的合作业务，pd_code为空是必传。
        /// </summary>
        [JsonPropertyName("out_uni_code")]
        public string OutUniCode { get; set; }

        /// <summary>
        /// 金融云产品码
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 基于哪个场景查询授信方案(FIXED_CREDIT:固化授信；PROD：产品；APPLY：申请；BL:保理；TYZBL：通用自保理；DYNAMIC：动态授信；CREDIT_LIST_FILTER：列表过滤授信方案)
        /// </summary>
        [JsonPropertyName("scen")]
        public string Scen { get; set; }
    }
}
