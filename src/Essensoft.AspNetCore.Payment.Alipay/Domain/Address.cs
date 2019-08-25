using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Address Data Structure.
    /// </summary>
    [Serializable]
    public class Address : AlipayObject
    {
        /// <summary>
        /// city，市名
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// county，用于区、县的描述
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// detail，地址详情
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// province，省份
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
