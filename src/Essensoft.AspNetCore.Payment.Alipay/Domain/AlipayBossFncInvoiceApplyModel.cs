using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceApplyModel : AlipayObject
    {
        /// <summary>
        /// 调用方身份识别标记(应用名称) 与业务单据号联合唯一
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务单据号，业务流水号
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 开票总金额，开票金额不能为空，开票金额不能小于等于0
        /// </summary>
        [JsonProperty("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 申请开票类型，01：专票；02：普票
        /// </summary>
        [JsonProperty("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 需开票的应收月账单号
        /// </summary>
        [JsonProperty("mthtly_bill_nos")]
        public List<string> MthtlyBillNos { get; set; }

        /// <summary>
        /// 申请人的uid号
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 01主站，02芝麻，03金融云
        /// </summary>
        [JsonProperty("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
