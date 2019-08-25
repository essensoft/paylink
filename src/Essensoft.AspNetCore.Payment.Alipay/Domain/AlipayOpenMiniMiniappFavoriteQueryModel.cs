using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappFavoriteQueryModel : AlipayObject
    {
        /// <summary>
        /// 需要指定查询收藏的app_id，若开放平台分配的app_id与具体的小程序不同时，才需要传参
        /// </summary>
        [JsonProperty("designated_app_id")]
        public string DesignatedAppId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
