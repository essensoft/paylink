using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceApplyModel Data Structure.
    /// </summary>
    public class AlipayBossFncInvoiceApplyModel : AlipayObject
    {
        /// <summary>
        /// 调用方身份识别标记(应用名称) 与业务单据号联合唯一
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务单据号，业务流水号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 开票总金额，开票金额不能为空，开票金额不能小于等于0
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 申请开票类型，01：专票；02：普票
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 需开票的应收月账单号
        /// </summary>
        [JsonPropertyName("mthtly_bill_nos")]
        public List<string> MthtlyBillNos { get; set; }

        /// <summary>
        /// 申请人的uid号
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 01主站，02芝麻，03金融云
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
