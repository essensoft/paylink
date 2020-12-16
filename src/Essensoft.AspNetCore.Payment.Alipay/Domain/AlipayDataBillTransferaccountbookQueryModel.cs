using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillTransferaccountbookQueryModel Data Structure.
    /// </summary>
    public class AlipayDataBillTransferaccountbookQueryModel : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000，默认2000
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 充值、转账、提现流水业务时间的起始范围
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子账本号，或者子账本名称。模糊查询
        /// </summary>
        [JsonPropertyName("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
