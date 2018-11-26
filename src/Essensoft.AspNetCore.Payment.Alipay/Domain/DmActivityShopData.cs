using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DmActivityShopData Data Structure.
    /// </summary>
    [Serializable]
    public class DmActivityShopData : AlipayObject
    {
        /// <summary>
        /// 数据创建时间戳
        /// </summary>
        [JsonProperty("gmt_create")]
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 数据修改时间戳
        /// </summary>
        [JsonProperty("gmt_modified")]
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 单日点击人数
        /// </summary>
        [JsonProperty("one_day_click_persons")]
        [XmlElement("one_day_click_persons")]
        public long OneDayClickPersons { get; set; }

        /// <summary>
        /// 单日点击次数
        /// </summary>
        [JsonProperty("one_day_click_times")]
        [XmlElement("one_day_click_times")]
        public long OneDayClickTimes { get; set; }

        /// <summary>
        /// 单日点击人数
        /// </summary>
        [JsonProperty("one_day_exposure_times")]
        [XmlElement("one_day_exposure_times")]
        public long OneDayExposureTimes { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 总点击人数
        /// </summary>
        [JsonProperty("total_click_persons")]
        [XmlElement("total_click_persons")]
        public long TotalClickPersons { get; set; }

        /// <summary>
        /// 总点击次数
        /// </summary>
        [JsonProperty("total_click_times")]
        [XmlElement("total_click_times")]
        public long TotalClickTimes { get; set; }

        /// <summary>
        /// 总曝光次数
        /// </summary>
        [JsonProperty("total_exposure_times")]
        [XmlElement("total_exposure_times")]
        public long TotalExposureTimes { get; set; }
    }
}
