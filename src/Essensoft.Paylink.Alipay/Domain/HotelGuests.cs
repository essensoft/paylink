using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HotelGuests Data Structure.
    /// </summary>
    public class HotelGuests : AlipayObject
    {
        /// <summary>
        /// 入住人姓名
        /// </summary>
        [JsonPropertyName("guest_name")]
        public string GuestName { get; set; }

        /// <summary>
        /// 入住人会员等级
        /// </summary>
        [JsonPropertyName("member_level")]
        public string MemberLevel { get; set; }

        /// <summary>
        /// 入住人联系方式
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }
    }
}
