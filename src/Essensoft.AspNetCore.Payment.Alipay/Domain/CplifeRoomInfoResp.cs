using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CplifeRoomInfoResp Data Structure.
    /// </summary>
    public class CplifeRoomInfoResp : AlipayObject
    {
        /// <summary>
        /// 商户系统小区房屋唯一ID标示.
        /// </summary>
        [JsonPropertyName("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 支付宝系统房间唯一标示.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string RoomId { get; set; }
    }
}
