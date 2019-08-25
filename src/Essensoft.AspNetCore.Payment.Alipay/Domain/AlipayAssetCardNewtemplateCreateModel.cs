using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetCardNewtemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCardNewtemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 账户模式：借记/贷记/借贷合一账户模式
        /// </summary>
        [JsonProperty("account_model")]
        public string AccountModel { get; set; }

        /// <summary>
        /// 按照资金产品维度定义的资产类型
        /// </summary>
        [JsonProperty("assets_code")]
        public string AssetsCode { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonProperty("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 资金信息列表[{"fundType":"HUA_BEI"}]
        /// </summary>
        [JsonProperty("card_fund_infos")]
        public List<CardFundInfo> CardFundInfos { get; set; }

        /// <summary>
        /// 卡模式：单卡/多卡模式
        /// </summary>
        [JsonProperty("card_model")]
        public string CardModel { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 创建人userId
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 贷记信息{"allowOverPay":false,"creditQuota":"0"}
        /// </summary>
        [JsonProperty("credit_info")]
        public CardCreditInfo CreditInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 卡账户生命周期类型：长期卡/月卡
        /// </summary>
        [JsonProperty("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 按照业务资产维度定义的产品编码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 模板结算商户id，后续商户资金流入的指定账户
        /// </summary>
        [JsonProperty("settle_user_id")]
        public string SettleUserId { get; set; }
    }
}
