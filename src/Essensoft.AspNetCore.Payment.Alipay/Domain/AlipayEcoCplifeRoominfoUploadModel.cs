using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoUploadModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeRoominfoUploadModel : AlipayObject
    {
        /// <summary>
        /// 请求批次号，由商户自定义，在商户系统内唯一标示一次业务请求。
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 业主所在物业小区ID(支付宝平台唯一小区ID标示)
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 待上传的房屋信息列表，单次上传不超过200条.
        /// </summary>
        [JsonPropertyName("room_info_set")]
        public List<CplifeRoomInfo> RoomInfoSet { get; set; }
    }
}
