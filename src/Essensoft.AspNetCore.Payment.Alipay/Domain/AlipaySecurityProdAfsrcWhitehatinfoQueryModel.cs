using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcWhitehatinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcWhitehatinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// HavanaId(淘宝uid)
        /// </summary>
        [JsonProperty("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
