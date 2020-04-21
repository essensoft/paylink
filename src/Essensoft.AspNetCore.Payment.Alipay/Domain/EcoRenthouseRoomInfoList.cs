using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoRenthouseRoomInfoList Data Structure.
    /// </summary>
    public class EcoRenthouseRoomInfoList : AlipayObject
    {
        /// <summary>
        /// 房间参与免押金的到期日期YYYY-MM-dd
        /// </summary>
        [JsonPropertyName("deposit_end_time")]
        public string DepositEndTime { get; set; }

        /// <summary>
        /// KA内部存储的房房间ID
        /// </summary>
        [JsonPropertyName("ka_room_id")]
        public string KaRoomId { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [JsonPropertyName("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// KA内部存储的房房间号
        /// </summary>
        [JsonPropertyName("room_num")]
        public string RoomNum { get; set; }
    }
}
