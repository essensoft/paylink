using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Room Data Structure.
    /// </summary>
    public class Room : AlipayObject
    {
        /// <summary>
        /// 出行人信息
        /// </summary>
        [JsonPropertyName("guests")]
        public List<Passenger> Guests { get; set; }

        /// <summary>
        /// 房型
        /// </summary>
        [JsonPropertyName("room_type")]
        public string RoomType { get; set; }
    }
}
