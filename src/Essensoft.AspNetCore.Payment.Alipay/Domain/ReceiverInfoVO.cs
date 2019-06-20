using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReceiverInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiverInfoVO : AlipayObject
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
        /// 移动电话
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人
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
