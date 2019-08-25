using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMemberDataTagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataTagQueryModel : AlipayObject
    {
        /// <summary>
        /// isv的pid
        /// </summary>
        [JsonProperty("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
