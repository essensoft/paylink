using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaytoolResultDetail Data Structure.
    /// </summary>
    public class PaytoolResultDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝交易号，当tool_code是ALIPAY和TMARKETING时有效。
        /// </summary>
        [JsonPropertyName("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 支付工具金额。单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 该支付工具的资金组成明细。仅当该支付工具驱动支付宝发生资金流时返回该字段。
        /// </summary>
        [JsonPropertyName("fund_bill_list")]
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        /// 支付完成时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 付款方用户详细信息
        /// </summary>
        [JsonPropertyName("payer_info")]
        public UserDetailInfo PayerInfo { get; set; }

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
        /// 支付工具状态;  支付成功：PAYMENT_SUCCESS，支付中：PAYMENT_INPROCESS，支付失败：PAYMENT_FAIL，支付撤销：PAYMENT_CANCELED
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
