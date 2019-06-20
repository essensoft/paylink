using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserGroupshoppingNewbieQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGroupshoppingNewbieQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝淘宝拼团的组团id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 淘宝支付宝拼团的商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
