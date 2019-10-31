using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillTransferQueryResponse.
    /// </summary>
    public class AlipayDataBillTransferQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充值、提现、转账明细记录
        /// </summary>
        [JsonProperty("detail_list")]
        public TransferDetailResult DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 充值、提现、转账明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [JsonProperty("total_size")]
        public string TotalSize { get; set; }
    }
}
