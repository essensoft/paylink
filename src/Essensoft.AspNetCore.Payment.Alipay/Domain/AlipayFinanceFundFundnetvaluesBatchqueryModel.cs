using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundnetvaluesBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundnetvaluesBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 结束日期，YYYYMMDD
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonProperty("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 分页数，从 1 开始
        /// </summary>
        [JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 开始日期，YYYYMMDD
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
