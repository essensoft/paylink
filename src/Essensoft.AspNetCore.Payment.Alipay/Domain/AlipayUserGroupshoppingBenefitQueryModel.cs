using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserGroupshoppingBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGroupshoppingBenefitQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝淘宝拼团的组团id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 拼团是否混合出资
        /// </summary>
        [JsonProperty("is_platform_invest")]
        public bool IsPlatformInvest { get; set; }

        /// <summary>
        /// 淘宝支付宝拼团的商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 拼团原始价格
        /// </summary>
        [JsonProperty("original_prize")]
        public string OriginalPrize { get; set; }

        /// <summary>
        /// 拼团的价格
        /// </summary>
        [JsonProperty("pin_prize")]
        public string PinPrize { get; set; }

        /// <summary>
        /// 1表示拼团中；2表示拼团成功；3表示拼团失败
        /// </summary>
        [JsonProperty("pin_status")]
        public string PinStatus { get; set; }

        /// <summary>
        /// DETAIL_PAGE拼团详情页，FINISH_PAGE拼团成功页
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 当前已参团的用户id
        /// </summary>
        [JsonProperty("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
