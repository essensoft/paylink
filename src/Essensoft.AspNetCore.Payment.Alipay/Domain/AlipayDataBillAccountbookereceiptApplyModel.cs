using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillAccountbookereceiptApplyModel Data Structure.
    /// </summary>
    public class AlipayDataBillAccountbookereceiptApplyModel : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 明细凭证，传入流水号（转账接口查询结果）。汇总凭证，传入起止时间，格式yyyy-MM-dd_yyyy-MM-dd。
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 子账本号，或者子账本名称。模糊查询
        /// </summary>
        [JsonPropertyName("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 申请的类型。可传入：FUND_PLATFORM_DETAIL - 资金明细证明，FUND_PLATFORM_SUM - 资金汇总证明
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
