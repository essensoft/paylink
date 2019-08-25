using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanLoanInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanLoanInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
