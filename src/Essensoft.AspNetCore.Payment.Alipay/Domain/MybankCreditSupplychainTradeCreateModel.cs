using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeCreateModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainTradeCreateModel : AlipayObject
    {
        /// <summary>
        /// 买家会员信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道，枚举如下：TMGXBL：天猫供销保理，TYZBL：通用自保理，TMZBL：天猫自保理，DSCYFRZ：大搜车预付融资，CNBILL：菜鸟电票
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 账款到期支付日期
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 由具体业务决定填充内容，JSON格式
        /// </summary>
        [JsonPropertyName("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonPropertyName("out_order_title")]
        public string OutOrderTitle { get; set; }

        /// <summary>
        /// 买家付款账户信息
        /// </summary>
        [JsonPropertyName("pay_account")]
        public Account PayAccount { get; set; }

        /// <summary>
        /// 卖家收款账户信息
        /// </summary>
        [JsonPropertyName("rcv_account")]
        public Account RcvAccount { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 卖家会员信息
        /// </summary>
        [JsonPropertyName("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 交易金额（单位：元），只支持两位小数点的正数
        /// </summary>
        [JsonPropertyName("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付，PREPAYBILL：电票预付
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }
    }
}
