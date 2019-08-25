using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoritegiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappFavoritegiftQueryModel : AlipayObject
    {
        /// <summary>
        /// 收藏有礼查询每个小程序相关信息的列表
        /// </summary>
        [JsonProperty("activity_list")]
        public List<ActivityQueryInfo> ActivityList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
