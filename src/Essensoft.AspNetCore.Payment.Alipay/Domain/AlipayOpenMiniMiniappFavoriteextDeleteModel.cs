using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteextDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteextDeleteModel : AlipayObject
    {
        /// <summary>
        /// 小程序收藏业务类型，需要申请分配
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// json格式，扩展信息，key是principleId，value是json串
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 收藏实体principleIds的来源，需要申请分配
        /// </summary>
        [JsonPropertyName("principal_biz_type")]
        public string PrincipalBizType { get; set; }

        /// <summary>
        /// 业务id，比如口碑店铺id
        /// </summary>
        [JsonPropertyName("principal_ids")]
        public List<string> PrincipalIds { get; set; }

        /// <summary>
        /// 收藏实体的枚举类型，ITEM：商品，SHOP：店铺，SERVICE：服务
        /// </summary>
        [JsonPropertyName("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
