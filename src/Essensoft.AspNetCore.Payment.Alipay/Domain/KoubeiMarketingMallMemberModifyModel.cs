using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingMallMemberModifyModel : AlipayObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [JsonPropertyName("card_info")]
        public MallCardUpdate CardInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
