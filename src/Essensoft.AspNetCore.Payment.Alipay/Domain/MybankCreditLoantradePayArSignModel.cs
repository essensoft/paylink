using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayArSignModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradePayArSignModel : AlipayObject
    {
        /// <summary>
        /// 用户支付宝ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约动态参数
        /// </summary>
        [JsonPropertyName("sign_param")]
        public string SignParam { get; set; }

        /// <summary>
        /// 客户授信基于什么维度产出，并不一定淘宝客户就写TAOBAO，要看具体情况 ALIPAY=支付宝 TAOBAO=淘系
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 根据站点的用户id，如果站点是淘宝或者天猫卖家，此处当填sellerId
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 业务子场景
        /// </summary>
        [JsonPropertyName("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
