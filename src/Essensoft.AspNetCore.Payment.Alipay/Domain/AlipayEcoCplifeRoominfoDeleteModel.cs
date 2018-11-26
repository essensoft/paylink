using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeRoominfoDeleteModel : AlipayObject
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
        /// 待删除的商户房间列表，一次API调用至多传入200条待删除的房间ID(房间在商户系统的唯一ID标识)
        /// </summary>
        [JsonProperty("out_room_id_set")]
        [XmlArray("out_room_id_set")]
        [XmlArrayItem("string")]
        public List<string> OutRoomIdSet { get; set; }
    }
}
