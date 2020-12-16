using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillTransferaccountbookQueryResponse.
    /// </summary>
    public class AlipayDataBillTransferaccountbookQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充值、提现、转账明细记录
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<TransferAccountBookDetailResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 充值、提现、转账明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [JsonPropertyName("total_size")]
        public string TotalSize { get; set; }
    }
}
