using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AOIinfo Data Structure.
    /// </summary>
    [Serializable]
    public class AOIinfo : AlipayObject
    {
        /// <summary>
        /// 所属AOI所在区域编码
        /// </summary>
        [JsonProperty("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 所属AOI点面积，单位是平方米
        /// </summary>
        [JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 输入经纬度是否在aoi面之中，取值为0时表示在AOI内，其他值表示距离AOI的距离
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 所属AOI的id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 所属AOI的中心点坐标
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 所属AOI名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
