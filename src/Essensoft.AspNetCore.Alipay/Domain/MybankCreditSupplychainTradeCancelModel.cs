using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeCancelModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainTradeCancelModel : AlipayObject
    {
        /// <summary>
        /// 买家会员信息
        /// </summary>
        [JsonProperty("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道，枚举如下：TMGXBL：天猫供销保理，TYZBL：通用自保理，TMZBL：天猫自保理，DSCYFRZ：大搜车预付融资
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonProperty("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付
        /// </summary>
        [JsonProperty("trade_type")]
        public string TradeType { get; set; }
    }
}
