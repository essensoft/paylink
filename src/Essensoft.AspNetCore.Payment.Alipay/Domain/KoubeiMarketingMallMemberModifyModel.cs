using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingMallMemberModifyModel : AlipayObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [JsonProperty("card_info")]
        public MallCardUpdate CardInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
