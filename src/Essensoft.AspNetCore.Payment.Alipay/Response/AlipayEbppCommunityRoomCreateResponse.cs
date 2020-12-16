using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityRoomCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityRoomCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 在支付宝app中，该房间的跳转地址
        /// </summary>
        [JsonPropertyName("community_room_url")]
        public string CommunityRoomUrl { get; set; }

        /// <summary>
        /// 内部房间ID, 对应外部房间ID, 全局唯一, 当房屋信息为叶子节点时不为空, 也是缴费OBJECT_ID yyyyMMddHHmmssSSS+hash(ISV_ID,2)+(COMMUNITY_PROPERTY_ID%100)+hash(COMMUNITY,2)+hash(OUT_ROOM_ID,4)+00000(预留) 32位
        /// </summary>
        [JsonPropertyName("room_id")]
        public string RoomId { get; set; }
    }
}
