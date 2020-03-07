using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoritegiftQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoritegiftQueryModel : AlipayObject
    {
        /// <summary>
        /// 收藏有礼查询每个小程序相关信息的列表
        /// </summary>
        [JsonPropertyName("activity_list")]
        public List<ActivityQueryInfo> ActivityList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
