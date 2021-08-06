using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntfarmDonationinfoQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialAntfarmDonationinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
