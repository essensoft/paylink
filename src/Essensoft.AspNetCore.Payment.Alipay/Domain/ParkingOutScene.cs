using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ParkingOutScene Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingOutScene : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 停车费用
        /// </summary>
        [JsonProperty("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 出场时间
        /// </summary>
        [JsonProperty("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 停车场id
        /// </summary>
        [JsonProperty("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [JsonProperty("parking_name")]
        public string ParkingName { get; set; }
    }
}
