using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// InsInvoiceApplyItem Data Structure.
    /// </summary>
    public class InsInvoiceApplyItem : AlipayObject
    {
        /// <summary>
        /// 申请发票开票维度;BUSINESS_ORDER:业务单;
        /// </summary>
        [JsonProperty("apply_scope")]
        public string ApplyScope { get; set; }

        /// <summary>
        /// 费用类型;PREMIUM:保费;
        /// </summary>
        [JsonProperty("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 业务单号;apply_scope为BUSINESS_ORDER时必填;
        /// </summary>
        [JsonProperty("ins_biz_no")]
        public string InsBizNo { get; set; }

        /// <summary>
        /// 业务单类型;APPLICATION:投保订单;POLICY:保单;ENDORSEMENT:批单;RECOVERY;追偿单.  apply_scope为BUSINESS_ORDER时必填;
        /// </summary>
        [JsonProperty("ins_biz_type")]
        public string InsBizType { get; set; }
    }
}
