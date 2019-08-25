using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBatchqueryResponse.
    /// </summary>
    public class AlipayTradeRoyaltyRelationBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonProperty("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 当前页面大小
        /// </summary>
        [JsonProperty("current_page_size")]
        public long CurrentPageSize { get; set; }

        /// <summary>
        /// 分账收款方列表
        /// </summary>
        [JsonProperty("receiver_list")]
        public List<RoyaltyEntity> ReceiverList { get; set; }

        /// <summary>
        /// 业务结果码。SUCCESS：分账关系查询成功；FAIL：分账关系查询失败。
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_page_num")]
        public long TotalPageNum { get; set; }

        /// <summary>
        /// 分账关系记录总数
        /// </summary>
        [JsonProperty("total_record_num")]
        public long TotalRecordNum { get; set; }
    }
}
