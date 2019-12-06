using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcWhitehatinfoQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdAfsrcWhitehatinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// HavanaId(淘宝uid)
        /// </summary>
        [JsonPropertyName("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
