using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityRoomDeleteModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityRoomDeleteModel : AlipayObject
    {
        /// <summary>
        /// 小区短名, 创建小区时生成
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// ISV外部房间号,创建后以支付宝内部房间号为准
        /// </summary>
        [JsonPropertyName("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 支付宝房间id
        /// </summary>
        [JsonPropertyName("room_id")]
        public string RoomId { get; set; }
    }
}
