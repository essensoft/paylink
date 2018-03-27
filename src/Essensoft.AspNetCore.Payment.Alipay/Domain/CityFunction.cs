using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CityFunction Data Structure.
    /// </summary>
    public class CityFunction : AlipayObject
    {
        /// <summary>
        /// 城市标准编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 描述功能，支持开卡(issue)，圈存(load)，充值转账(recharge)
        /// </summary>
        [JsonProperty("function_type")]
        public List<string> FunctionType { get; set; }
    }
}
