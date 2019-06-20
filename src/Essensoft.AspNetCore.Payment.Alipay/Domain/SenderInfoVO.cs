using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SenderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SenderInfoVO : AlipayObject
    {
        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 发货人电话
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 发货人
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
