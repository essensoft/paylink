using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NearMallBo Data Structure.
    /// </summary>
    [Serializable]
    public class NearMallBo : AlipayObject
    {
        /// <summary>
        /// json字符串表示额外信息
        /// </summary>
        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈图片
        /// </summary>
        [JsonProperty("mall_logo")]
        public string MallLogo { get; set; }

        /// <summary>
        /// 商圈名字
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }
    }
}
