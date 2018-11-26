using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CplifeRoomInfoResp Data Structure.
    /// </summary>
    [Serializable]
    public class CplifeRoomInfoResp : AlipayObject
    {
        /// <summary>
        /// 商户系统小区房屋唯一ID标示.
        /// </summary>
        [JsonProperty("out_room_id")]
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 支付宝系统房间唯一标示.
        /// </summary>
        [JsonProperty("room_id")]
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
