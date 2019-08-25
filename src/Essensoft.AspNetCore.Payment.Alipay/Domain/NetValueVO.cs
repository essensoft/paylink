using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NetValueVO Data Structure.
    /// </summary>
    [Serializable]
    public class NetValueVO : AlipayObject
    {
        /// <summary>
        /// 基金单位净值，含4位小数
        /// </summary>
        [JsonProperty("net_value")]
        public string NetValue { get; set; }

        /// <summary>
        /// 基金净值日期
        /// </summary>
        [JsonProperty("net_value_date")]
        public string NetValueDate { get; set; }

        /// <summary>
        /// 七日年化收益率，含5位小数，可以为负
        /// </summary>
        [JsonProperty("profit_seven_days")]
        public string ProfitSevenDays { get; set; }

        /// <summary>
        /// 万份收益，含5位小数，可以为负
        /// </summary>
        [JsonProperty("profit_ten_thousand")]
        public string ProfitTenThousand { get; set; }
    }
}
