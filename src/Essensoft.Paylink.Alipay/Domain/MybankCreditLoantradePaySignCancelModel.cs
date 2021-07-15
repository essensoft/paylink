using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradePaySignCancelModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradePaySignCancelModel : AlipayObject
    {
        /// <summary>
        /// 支付宝ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点用户ID
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 子业务场景
        /// </summary>
        [JsonPropertyName("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
