using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanpayAssetConsultModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeLoanpayAssetConsultModel : AlipayObject
    {
        /// <summary>
        /// 支付宝签约商户ID，如PARTNER_ALIBABA_CN, PARTNER_TAOBAO_ORDER
        /// </summary>
        [JsonPropertyName("alipay_partner_id")]
        public string AlipayPartnerId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public MultiCurrencyMoneyVO ApplyAmt { get; set; }

        /// <summary>
        /// 具体咨询扩展，一笔订单对应数组中一个元素
        /// </summary>
        [JsonPropertyName("order_info")]
        public List<LoanPayConsultOrder> OrderInfo { get; set; }

        /// <summary>
        /// 收单销售产品码
        /// </summary>
        [JsonPropertyName("payment_sale_pd_code")]
        public string PaymentSalePdCode { get; set; }

        /// <summary>
        /// 交易平台类型，如b2b, nongzi
        /// </summary>
        [JsonPropertyName("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 交易平台子类型，收单参数，如1688_hp
        /// </summary>
        [JsonPropertyName("sub_platform_type")]
        public string SubPlatformType { get; set; }

        /// <summary>
        /// 用户信息 是
        /// </summary>
        [JsonPropertyName("user")]
        public LoanPayUser User { get; set; }
    }
}
