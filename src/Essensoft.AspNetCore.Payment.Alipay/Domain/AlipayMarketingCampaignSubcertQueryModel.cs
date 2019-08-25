using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSubcertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignSubcertQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户登录账号名：邮箱或手机号。已知支付宝账号的活动触发调用中，user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 营销平台凭证批次号
        /// </summary>
        [JsonProperty("lot_num")]
        public string LotNum { get; set; }

        /// <summary>
        /// 支付宝用户uid：支付宝用户唯一标识。该参数用于已知支付宝账号的活动触发。user_id、login_id两个参数至少有一个非空。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
