using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RatioDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RatioDetail : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// 占比的标签名称
        /// </summary>
        [JsonProperty("ratio_label")]
        public string RatioLabel { get; set; }

        /// <summary>
        /// 占比数值，为百分比的小数数值
        /// </summary>
        [JsonProperty("ratio_val")]
        public string RatioVal { get; set; }
    }
}
