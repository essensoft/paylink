using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoUploadResponse.
    /// </summary>
    public class AlipayEcoCplifeRoominfoUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 业主所在物业小区ID(支付宝平台唯一小区ID标示)
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 已经成功上传的房屋信息列表.
        /// </summary>
        [JsonPropertyName("room_info_set")]
        public List<CplifeRoomInfoResp> RoomInfoSet { get; set; }
    }
}
