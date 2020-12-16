using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillEreceiptApplyModel Data Structure.
    /// </summary>
    public class AlipayDataBillEreceiptApplyModel : AlipayObject
    {
        /// <summary>
        /// 根据不同业务类型，传入不同参数。格式如下：    * ACCOUNT_LOG_SUM_DAILY - 日汇总收支证明。传入yyyy-MM-dd    * ACCOUNT_LOG_SUM_MONTHLY - 月汇总收支证明。传入yyyy-MM    * HISTORY_ASSETCERT - 历史余额证明。传入yyyy-MM-dd    * SERVICE_FEE - 服务费回单。传入yyyy-MM    * SERVICE_FEE_SETTLE - 结算单。传入yyyy-MM_yyyy-MM(起始月份到终止月份)    * INOUT_SUM - 收支证明。传入yyyy-MM    * FUND_DETAIL - 资金业务回单。传入资金单号(fundOrderId)    * ACCOUNT_LOG_DETAIL - 余额收支明细回单。传入账务流水号(iwAccountLogId)    * BAIL_ASSETCERT - 保证金资产证明。无需传入
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 申请的类型。可传入：    * ACCOUNT_LOG_SUM_DAILY - 日汇总收支证明。    * ACCOUNT_LOG_SUM_MONTHLY - 月汇总收支证明。    * ASSERT_CERT - 当前余额证明。    * HISTORY_ASSETCERT - 历史余额证明。    * SERVICE_FEE - 服务费回单。    * SERVICE_FEE_SETTLE - 结算单。    * INOUT_SUM - 收支证明。    * FUND_DETAIL - 资金业务回单。    * ACCOUNT_LOG_DETAIL - 余额收支明细回单。    * BAIL_ASSETCERT - 保证金资产证明。    * BAIL_DETAIL - 保证金明细回单。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
