using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaytoolRefundResultDetail Data Structure.
    /// </summary>
    public class PaytoolRefundResultDetail : AlipayObject
    {
        /// <summary>
        /// 支付工具退款完成时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 支付宝支付工具单据号
        /// </summary>
        [JsonPropertyName("paytool_bill_no")]
        public string PaytoolBillNo { get; set; }

        /// <summary>
        /// 商户支付工具单据号
        /// </summary>
        [JsonPropertyName("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }

        /// <summary>
        /// 退款支付工具金额。单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 该支付工具的退款资金组成明细。仅当该支付工具驱动支付宝发生资金流时返回该字段。
        /// </summary>
        [JsonPropertyName("refund_fund_bill_list")]
        public List<TradeFundBill> RefundFundBillList { get; set; }

        /// <summary>
        /// 支付工具退款状态;  退款：REFUND_SUCCESS，退款处理中：REFUND_INPROCESS，退款失败：REFUND_FAIL
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝统一分配的支付工具编码;  现金:CASH;支付宝:ALIPAY,营销:TMARKETING;POS支付:POS,商户预付卡:MERCHANT_MCARD,OTHER:其他
        /// </summary>
        [JsonPropertyName("tool_code")]
        public string ToolCode { get; set; }
    }
}
