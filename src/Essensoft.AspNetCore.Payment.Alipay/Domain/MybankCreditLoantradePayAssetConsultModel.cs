using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayAssetConsultModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradePayAssetConsultModel : AlipayObject
    {
        /// <summary>
        /// 支付宝合作伙伴id
        /// </summary>
        [JsonPropertyName("alipay_partner_id")]
        public string AlipayPartnerId { get; set; }

        /// <summary>
        /// 申请金额，最小1元钱
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public CreditPayMoneyVO ApplyAmt { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 咨询资产类型，LOAN_INSTALLMENT或者BILL
        /// </summary>
        [JsonPropertyName("credit_asset_types")]
        public List<string> CreditAssetTypes { get; set; }

        /// <summary>
        /// 交易订单信息，JSON数组格式的***字符串***，用于描述交易订单详情。再次强调，该字段是字符串形式，用于当做订单扩展使用。序列化整个请求的时候，这个字段一定要是字符串类型，只不过该字段产生，需要将订单List额外进行一次json序列化
        /// </summary>
        [JsonPropertyName("order_infos")]
        public string OrderInfos { get; set; }

        /// <summary>
        /// 收单产品码
        /// </summary>
        [JsonPropertyName("payment_sale_pd_code")]
        public string PaymentSalePdCode { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [JsonPropertyName("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [JsonPropertyName("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 子平台类型
        /// </summary>
        [JsonPropertyName("sub_platform_type")]
        public string SubPlatformType { get; set; }

        /// <summary>
        /// 咨询用户信息
        /// </summary>
        [JsonPropertyName("user")]
        public CreditPayUserVO User { get; set; }
    }
}
