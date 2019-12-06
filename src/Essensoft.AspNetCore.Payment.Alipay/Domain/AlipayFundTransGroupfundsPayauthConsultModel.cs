using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsPayauthConsultModel Data Structure.
    /// </summary>
    public class AlipayFundTransGroupfundsPayauthConsultModel : AlipayObject
    {
        /// <summary>
        /// 当前发起资金操作用户支付宝账户ID
        /// </summary>
        [JsonPropertyName("current_user_id")]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 扩展请求参数，业务扩展时使用
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 资金操作类型，"collect": 收款，"payment": 付款
        /// </summary>
        [JsonPropertyName("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 业务来源,对于聚会小程序统一透传"openParty"
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
