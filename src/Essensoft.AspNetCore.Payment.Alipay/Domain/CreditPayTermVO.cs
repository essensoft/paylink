using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayTermVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayTermVO : AlipayObject
    {
        /// <summary>
        /// 期限结束日期
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [JsonProperty("term")]
        public long Term { get; set; }

        /// <summary>
        /// 期限单位
        /// </summary>
        [JsonProperty("term_unit")]
        public string TermUnit { get; set; }
    }
}
