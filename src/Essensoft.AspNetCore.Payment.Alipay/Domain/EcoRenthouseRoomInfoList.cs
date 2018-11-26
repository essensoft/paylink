using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoRenthouseRoomInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class EcoRenthouseRoomInfoList : AlipayObject
    {
        /// <summary>
        /// 房间参与免押金的到期日期YYYY-MM-dd
        /// </summary>
        [JsonProperty("deposit_end_time")]
        [XmlElement("deposit_end_time")]
        public string DepositEndTime { get; set; }

        /// <summary>
        /// KA内部存储的房房间ID
        /// </summary>
        [JsonProperty("ka_room_id")]
        [XmlElement("ka_room_id")]
        public string KaRoomId { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [JsonProperty("room_code")]
        [XmlElement("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// KA内部存储的房房间号
        /// </summary>
        [JsonProperty("room_num")]
        [XmlElement("room_num")]
        public string RoomNum { get; set; }
    }
}
