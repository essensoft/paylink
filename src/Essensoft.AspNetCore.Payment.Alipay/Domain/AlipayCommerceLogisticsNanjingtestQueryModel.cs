using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsNanjingtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsNanjingtestQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonProperty("user_info")]
        public UserInfoFromNJ UserInfo { get; set; }
    }
}
