using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSubcertQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignSubcertQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户登录账号名：邮箱或手机号。已知支付宝账号的活动触发调用中，user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 营销平台凭证批次号
        /// </summary>
        [JsonPropertyName("lot_num")]
        public string LotNum { get; set; }

        /// <summary>
        /// 支付宝用户uid：支付宝用户唯一标识。该参数用于已知支付宝账号的活动触发。user_id、login_id两个参数至少有一个非空。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
