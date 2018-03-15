using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskCustomerriskQueryModel : AlipayObject
    {
        /// <summary>
        /// 银行卡号不唯一，用于传递服务商查询接入的商户的银行卡卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 身份证号不唯一，用于传递服务商查询接入的商户风险所需要的身份证号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 手机号不唯一，用于传递服务商查询接入的商户的手机号
        /// </summary>
        [JsonProperty("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 风险类型不唯一，用于服务商查询接入的商户风险，例如：merchant_general（综合风险），merchant_fraud（欺诈风险），merchant_business（资质风险）等，签约时指定查询风险类型，且一次调用可以传递多个风险类型，用逗号隔开
        /// </summary>
        [JsonProperty("risk_type")]
        public string RiskType { get; set; }
    }
}
