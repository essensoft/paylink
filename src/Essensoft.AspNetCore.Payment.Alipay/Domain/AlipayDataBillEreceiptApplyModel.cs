using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillEreceiptApplyModel Data Structure.
    /// </summary>
    public class AlipayDataBillEreceiptApplyModel : AlipayObject
    {
        /// <summary>
        /// 根据不同业务类型，传入不同参数。当前余额等无需参数的，不需要传入。日汇总传入格式：yyyy-MM-dd，月汇总传入格式：yyyy-MM。订单号直接传入。 支持批量查询：批量查询可将多个key半角逗号分割
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 申请的类型。可传入：ACCOUNT_LOG_SUM_DAILY - 日汇总收支证明，ACCOUNT_LOG_SUM_MONTHLY - 月汇总收支证明，BALANCE - 当前余额证明，BALANCE_HIS - 历史余额证明，BAIL - 保证金资产证明，SERVICE_FEE - 服务费回单，SETTLE - 结算单，ACCOUNT_LOG_DETAIL - 余额收支明细回单，TRADE_DETAIL - 卖出交易回单，FUND_DETAIL - 资金业务回单，BAIL_DETAIL - 保证金明细回单
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
