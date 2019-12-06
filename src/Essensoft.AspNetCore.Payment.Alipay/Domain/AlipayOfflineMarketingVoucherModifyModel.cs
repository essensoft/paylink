using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherModifyModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketingVoucherModifyModel : AlipayObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [JsonPropertyName("budget_info")]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发放次数限制
        /// </summary>
        [JsonPropertyName("get_count_limit")]
        public PeriodInfo GetCountLimit { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [JsonPropertyName("voucher_info")]
        public VoucherModifyInfo VoucherInfo { get; set; }
    }
}
