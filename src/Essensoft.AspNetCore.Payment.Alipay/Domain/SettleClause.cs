using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettleClause Data Structure.
    /// </summary>
    public class SettleClause : AlipayObject
    {
        /// <summary>
        /// 结算金额，单位为元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 结算币种，支持人民币：CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 结算账号所属于的结算主体类型。 secondMerchant 二级商户的结算账号 store 门店的结算账号 如果不填，默认为settleEntityType对应的类型
        /// </summary>
        [JsonPropertyName("settle_account_entity")]
        public string SettleAccountEntity { get; set; }

        /// <summary>
        /// 结算账户id。  当结算账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当结算账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当结算账户id类型是loginName时，本参数为用户的支付宝登录号; 当 settle_account_type 为defaultSettle时，本参数必须为空
        /// </summary>
        [JsonPropertyName("settle_account_id")]
        public string SettleAccountId { get; set; }

        /// <summary>
        /// 结算账户id类型。  当settle_account_type 为bankCard时，本参数为cardSerialNo，表示结算账户id是银行卡编号; 当settle_account_type 为alipayBalance时，本参数为userId或者loginName，其中userId表示结算账户id是支付宝唯一用户号，loginName表示结算账户id是支付宝登录号; 当 settle_account_type 为 defaultSettle 时，本参数必须为空
        /// </summary>
        [JsonPropertyName("settle_account_id_type")]
        public string SettleAccountIdType { get; set; }

        /// <summary>
        /// 结算账户类型。  bankCard: 结算账户为银行卡； alipayBalance: 结算账户为支付宝余额户； defaultSettle: 按默认结算规则结算
        /// </summary>
        [JsonPropertyName("settle_account_type")]
        public string SettleAccountType { get; set; }

        /// <summary>
        /// 结算主体账号。  当结算主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID
        /// </summary>
        [JsonPropertyName("settle_entity_id")]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型。  SecondMerchant：结算主体为二级商户
        /// </summary>
        [JsonPropertyName("settle_entity_type")]
        public string SettleEntityType { get; set; }

        /// <summary>
        /// 二级商户信息
        /// </summary>
        [JsonPropertyName("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }
    }
}
