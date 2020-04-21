using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StructureServiceInfo Data Structure.
    /// </summary>
    public class StructureServiceInfo : AlipayObject
    {
        /// <summary>
        /// 是否提供酒精饮料
        /// </summary>
        [JsonPropertyName("alcohol")]
        public bool Alcohol { get; set; }

        /// <summary>
        /// 是否接受预约
        /// </summary>
        [JsonPropertyName("booking")]
        public bool Booking { get; set; }

        /// <summary>
        /// 是否有包厢
        /// </summary>
        [JsonPropertyName("box")]
        public bool Box { get; set; }

        /// <summary>
        /// 是否允许自带杯
        /// </summary>
        [JsonPropertyName("byo")]
        public bool Byo { get; set; }

        /// <summary>
        /// 是否提供中文服务
        /// </summary>
        [JsonPropertyName("chinese_svc")]
        public bool ChineseSvc { get; set; }

        /// <summary>
        /// 是否有停车位
        /// </summary>
        [JsonPropertyName("parking")]
        public bool Parking { get; set; }

        /// <summary>
        /// 是否支持外带
        /// </summary>
        [JsonPropertyName("takeout")]
        public bool Takeout { get; set; }

        /// <summary>
        /// 是否支持电话预定
        /// </summary>
        [JsonPropertyName("tel_rsvt")]
        public bool TelRsvt { get; set; }

        /// <summary>
        /// 是否需要小费
        /// </summary>
        [JsonPropertyName("tips")]
        public bool Tips { get; set; }

        /// <summary>
        /// 是否有wifi
        /// </summary>
        [JsonPropertyName("wifi")]
        public bool Wifi { get; set; }
    }
}
