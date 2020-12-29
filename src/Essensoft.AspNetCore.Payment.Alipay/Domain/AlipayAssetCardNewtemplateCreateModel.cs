using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetCardNewtemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayAssetCardNewtemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 账户模式：借记/贷记/借贷合一账户模式
        /// </summary>
        [JsonPropertyName("account_model")]
        public string AccountModel { get; set; }

        /// <summary>
        /// 按照资金产品维度定义的资产类型
        /// </summary>
        [JsonPropertyName("assets_code")]
        public string AssetsCode { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 资金信息列表[{"fundType":"HUA_BEI"}]
        /// </summary>
        [JsonPropertyName("card_fund_infos")]
        public List<CardFundInfo> CardFundInfos { get; set; }

        /// <summary>
        /// 卡模式：单卡/多卡模式
        /// </summary>
        [JsonPropertyName("card_model")]
        public string CardModel { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [JsonPropertyName("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 创建人userId
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 贷记信息{"allowOverPay":false,"creditQuota":"0"}
        /// </summary>
        [JsonPropertyName("credit_info")]
        public CardCreditInfo CreditInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 卡账户生命周期类型：长期卡/月卡
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 按照业务资产维度定义的产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 模板结算商户id，后续商户资金流入的指定账户
        /// </summary>
        [JsonPropertyName("settle_user_id")]
        public string SettleUserId { get; set; }

        /// <summary>
        /// 商户资金签约主体
        /// </summary>
        [JsonPropertyName("sign_principal")]
        public string SignPrincipal { get; set; }
    }
}
