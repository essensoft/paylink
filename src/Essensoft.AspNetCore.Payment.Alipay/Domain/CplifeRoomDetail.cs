using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CplifeRoomDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CplifeRoomDetail : AlipayObject
    {
        /// <summary>
        /// 房间完整门牌地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 房屋所在楼栋名称。例如“1栋”，“1幢”等
        /// </summary>
        [JsonProperty("building")]
        [XmlElement("building")]
        public string Building { get; set; }

        /// <summary>
        /// 房屋所在的组团名称。例如“一期”，“东区”，“香桂苑”等
        /// </summary>
        [JsonProperty("group")]
        [XmlElement("group")]
        public string Group { get; set; }

        /// <summary>
        /// 商户系统小区房屋唯一ID标示.
        /// </summary>
        [JsonProperty("out_room_id")]
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 房屋所在房号。例如“1101室”，“11B室”等
        /// </summary>
        [JsonProperty("room")]
        [XmlElement("room")]
        public string Room { get; set; }

        /// <summary>
        /// 支付宝系统房间唯一标示.
        /// </summary>
        [JsonProperty("room_id")]
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 房屋所在单元名称。例如“一单元”，“二单元”等
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
