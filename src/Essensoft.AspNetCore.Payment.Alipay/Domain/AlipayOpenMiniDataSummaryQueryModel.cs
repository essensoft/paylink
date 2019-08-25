using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataSummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDataSummaryQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求数据的日期
        /// </summary>
        [JsonProperty("report_date")]
        public string ReportDate { get; set; }
    }
}
