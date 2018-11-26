using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeRoominfoUploadModel : AlipayObject
    {
        /// <summary>
        /// 请求批次号，由商户自定义，在商户系统内唯一标示一次业务请求。
        /// </summary>
        [JsonProperty("batch_id")]
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 业主所在物业小区ID(支付宝平台唯一小区ID标示)
        /// </summary>
        [JsonProperty("community_id")]
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 待上传的房屋信息列表，单次上传不超过200条.
        /// </summary>
        [JsonProperty("room_info_set")]
        [XmlArray("room_info_set")]
        [XmlArrayItem("cplife_room_info")]
        public List<CplifeRoomInfo> RoomInfoSet { get; set; }
    }
}
