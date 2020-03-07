using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceBillDingstaffbizorderQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceBillDingstaffbizorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单明细列表。如果返回数量小于page_size，则表示查询结束
        /// </summary>
        [JsonPropertyName("bill_list")]
        public List<BillDingBizOrder> BillList { get; set; }

        /// <summary>
        /// 月汇总信息,包括当前的收支明细所涉及的所有月份汇总, 但是如果这些月份汇总上页查询已经返回, 当前页也则不再返回。根据传入参数last_id的前6位判断已经返回的月份信息
        /// </summary>
        [JsonPropertyName("bill_sum")]
        public List<BillDingBizOrderSum> BillSum { get; set; }
    }
}
