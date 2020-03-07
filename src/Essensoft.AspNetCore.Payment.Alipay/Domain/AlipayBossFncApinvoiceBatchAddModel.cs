using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncApinvoiceBatchAddModel Data Structure.
    /// </summary>
    public class AlipayBossFncApinvoiceBatchAddModel : AlipayObject
    {
        /// <summary>
        /// 应付对账单发票关联明细
        /// </summary>
        [JsonPropertyName("ap_invoice_bill_link_orders")]
        public List<ApInvoiceBillLinkOrderRequest> ApInvoiceBillLinkOrders { get; set; }

        /// <summary>
        /// 应付发票
        /// </summary>
        [JsonPropertyName("ap_invoice_order_list")]
        public List<ApInvoiceOrderRequest> ApInvoiceOrderList { get; set; }

        /// <summary>
        /// 发票备注信息memo
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 当前操作人类型，01:ISV 02:管理员(小二)
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 个人无票税损比例，有效范围[0,1]
        /// </summary>
        [JsonPropertyName("personal_tax_loss_rate")]
        public long PersonalTaxLossRate { get; set; }
    }
}
