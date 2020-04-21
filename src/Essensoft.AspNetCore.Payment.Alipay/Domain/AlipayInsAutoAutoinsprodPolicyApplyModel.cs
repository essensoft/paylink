using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyApplyModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyApplyModel : AlipayObject
    {
        /// <summary>
        /// 商业险收款账号，商交保费收入账号不一致时，商业险收入账号传此字段。一般为保险公司收款账号登录ID，最终以技术isv给出示例为准，蚂蚁会校验该id对应的保险公司是不是和蚂蚁胜信签约以及签约关系是否有效，示例：xxxx.@alipay.com
        /// </summary>
        [JsonPropertyName("bus_income_account_no")]
        public string BusIncomeAccountNo { get; set; }

        /// <summary>
        /// 邮寄信息
        /// </summary>
        [JsonPropertyName("deliver_info")]
        public DeliverInfo DeliverInfo { get; set; }

        /// <summary>
        /// 询价申请ID
        /// </summary>
        [JsonPropertyName("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 交强险收款账号，商交保费收入账号不一致时，交强险收入账号传此字段。一般为保险公司收款账号登录ID，最终以技术isv给出示例为准，蚂蚁会校验该id对应的保险公司是不是和蚂蚁胜信签约以及签约关系是否有效，示例：xxxx.@alipay.com
        /// </summary>
        [JsonPropertyName("force_income_account_no")]
        public string ForceIncomeAccountNo { get; set; }

        /// <summary>
        /// 指定保险公司支付宝收款账户,一般为保险公司收款账号登录ID
        /// </summary>
        [JsonPropertyName("income_account_no")]
        public string IncomeAccountNo { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonPropertyName("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 付费方式,1-代理人付款，2-投保人付款
        /// </summary>
        [JsonPropertyName("who_payed")]
        public string WhoPayed { get; set; }
    }
}
