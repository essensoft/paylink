using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataNearmallQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataNearmallQueryModel : AlipayObject
    {
        /// <summary>
        /// 说明来源
        /// </summary>
        [JsonProperty("app_channel")]
        public string AppChannel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 开始标记
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 数量标记
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 设备版本号
        /// </summary>
        [JsonProperty("product_version")]
        public string ProductVersion { get; set; }

        /// <summary>
        /// 半径，单位【米】
        /// </summary>
        [JsonProperty("radius")]
        public string Radius { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 地理位置经度
        /// </summary>
        [JsonProperty("x")]
        public long X { get; set; }

        /// <summary>
        /// 地理位置纬度
        /// </summary>
        [JsonProperty("y")]
        public long Y { get; set; }
    }
}
