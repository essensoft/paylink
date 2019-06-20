using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UboVO Data Structure.
    /// </summary>
    [Serializable]
    public class UboVO : AlipayObject
    {
        /// <summary>
        /// 职务
        /// </summary>
        [JsonProperty("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 控股比例
        /// </summary>
        [JsonProperty("invest_rate")]
        public string InvestRate { get; set; }

        /// <summary>
        /// ubo名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
