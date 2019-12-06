using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteAddModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteAddModel : AlipayObject
    {
        /// <summary>
        /// 需要指定收藏的app_id，若开放平台分配的app_id与具体的小程序不同时，才需要传参
        /// </summary>
        [JsonPropertyName("designated_app_id")]
        public string DesignatedAppId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
