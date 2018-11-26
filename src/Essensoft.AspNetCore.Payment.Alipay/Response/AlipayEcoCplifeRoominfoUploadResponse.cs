using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("community_id")]
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 已经成功上传的房屋信息列表.
        /// </summary>
        [JsonProperty("room_info_set")]
        [XmlArray("room_info_set")]
        [XmlArrayItem("cplife_room_info_resp")]
        public List<CplifeRoomInfoResp> RoomInfoSet { get; set; }
    }
}
