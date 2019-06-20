using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlisisReportColumn Data Structure.
    /// </summary>
    [Serializable]
    public class AlisisReportColumn : AlipayObject
    {
        /// <summary>
        /// 列别名
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 列值
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
