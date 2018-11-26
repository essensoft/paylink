using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingExitinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingExitinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("car_number")]
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车辆离场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonProperty("out_time")]
        [XmlElement("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 支付宝停车场ID，系统唯一
        /// </summary>
        [JsonProperty("parking_id")]
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
