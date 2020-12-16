using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantTradecomplainBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantTradecomplainBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        [JsonPropertyName("total_page_num")]
        public long TotalPageNum { get; set; }

        /// <summary>
        /// 交易纠纷工单列表信息
        /// </summary>
        [JsonPropertyName("trade_complain_infos")]
        public List<TradeComplainQueryResponse> TradeComplainInfos { get; set; }
    }
}
