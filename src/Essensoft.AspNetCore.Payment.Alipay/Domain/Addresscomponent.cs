using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Addresscomponent Data Structure.
    /// </summary>
    public class Addresscomponent : AlipayObject
    {
        /// <summary>
        /// 行政区编码
        /// </summary>
        [JsonPropertyName("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 建筑信息
        /// </summary>
        [JsonPropertyName("building")]
        public Building Building { get; set; }

        /// <summary>
        /// 商圈信息列表
        /// </summary>
        [JsonPropertyName("business_areas")]
        public List<Businessarea> BusinessAreas { get; set; }

        /// <summary>
        /// 当所在城市为北京、上海、天津、重庆四个直辖市时，该字段返回为空。当所在城市属于县级市的时候，此字段为空。
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("citycode")]
        public string Citycode { get; set; }

        /// <summary>
        /// 国内默认返回中国
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 坐标点所在区
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// 社区信息
        /// </summary>
        [JsonPropertyName("neighborhood")]
        public Neighborhood Neighborhood { get; set; }

        /// <summary>
        /// 坐标点所在省名称
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 门牌信息
        /// </summary>
        [JsonPropertyName("street_number")]
        public Streetnumber StreetNumber { get; set; }

        /// <summary>
        /// 乡镇街道编码
        /// </summary>
        [JsonPropertyName("towncode")]
        public string Towncode { get; set; }

        /// <summary>
        /// 坐标点所在乡镇/街道（此街道为社区街道，不是道路信息）
        /// </summary>
        [JsonPropertyName("township")]
        public string Township { get; set; }
    }
}
