using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountSearchResponse.
    /// </summary>
    public class AlipayUserAccountSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户账务明细信息
        /// </summary>
        [JsonProperty("account_records")]
        public List<AccountRecord> AccountRecords { get; set; }

        /// <summary>
        /// 总页面数
        /// </summary>
        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
    }
}
