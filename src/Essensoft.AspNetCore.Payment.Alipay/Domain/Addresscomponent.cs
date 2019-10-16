using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Addresscomponent Data Structure.
    /// </summary>
    [Serializable]
    public class Addresscomponent : AlipayObject
    {
        /// <summary>
        /// 行政区编码
        /// </summary>
        [JsonProperty("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 建筑信息
        /// </summary>
        [JsonProperty("building")]
        public Building Building { get; set; }

        /// <summary>
        /// 商圈信息列表
        /// </summary>
        [JsonProperty("business_areas")]
        public List<Businessarea> BusinessAreas { get; set; }

        /// <summary>
        /// 当所在城市为北京、上海、天津、重庆四个直辖市时，该字段返回为空。当所在城市属于县级市的时候，此字段为空。
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("citycode")]
        public string Citycode { get; set; }

        /// <summary>
        /// 国内默认返回中国
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 坐标点所在区
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// 社区信息
        /// </summary>
        [JsonProperty("neighborhood")]
        public Neighborhood Neighborhood { get; set; }

        /// <summary>
        /// 坐标点所在省名称
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 门牌信息
        /// </summary>
        [JsonProperty("street_number")]
        public Streetnumber StreetNumber { get; set; }

        /// <summary>
        /// 乡镇街道编码
        /// </summary>
        [JsonProperty("towncode")]
        public string Towncode { get; set; }

        /// <summary>
        /// 坐标点所在乡镇/街道（此街道为社区街道，不是道路信息）
        /// </summary>
        [JsonProperty("township")]
        public string Township { get; set; }
    }
}
