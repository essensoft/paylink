using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradeAssocBillDetails Data Structure.
    /// </summary>
    public class TradeAssocBillDetails : AlipayObject
    {
        /// <summary>
        /// 明细条目所归属的账期
        /// </summary>
        [JsonProperty("acct_period")]
        public string AcctPeriod { get; set; }

        /// <summary>
        /// 缴费明细项金额
        /// </summary>
        [JsonProperty("bill_entry_amount")]
        public string BillEntryAmount { get; set; }

        /// <summary>
        /// 用于标识该笔缴费对应的缴费明细项外部编号；如果是预存缴费，则为外部户号
        /// </summary>
        [JsonProperty("bill_entry_id")]
        public string BillEntryId { get; set; }

        /// <summary>
        /// 缴费明细项类型
        /// </summary>
        [JsonProperty("cost_type")]
        public string CostType { get; set; }
    }
}
