using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopMallMemberQueryModel Data Structure.
    /// </summary>
    public class KoubeiShopMallMemberQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
