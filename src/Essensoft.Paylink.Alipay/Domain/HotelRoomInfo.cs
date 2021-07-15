using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HotelRoomInfo Data Structure.
    /// </summary>
    public class HotelRoomInfo : AlipayObject
    {
        /// <summary>
        /// 酒店入住人信息
        /// </summary>
        [JsonPropertyName("guests")]
        public List<HotelGuests> Guests { get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [JsonPropertyName("room_number")]
        public string RoomNumber { get; set; }

        /// <summary>
        /// 房型
        /// </summary>
        [JsonPropertyName("room_type")]
        public string RoomType { get; set; }
    }
}
