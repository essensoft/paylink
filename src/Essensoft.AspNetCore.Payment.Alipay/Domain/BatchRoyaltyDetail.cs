using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BatchRoyaltyDetail Data Structure.
    /// </summary>
    public class BatchRoyaltyDetail : AlipayObject
    {
        /// <summary>
        /// 分账金额，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 错误编码 BANK_CARD_ERROR：银行卡信息有误的场景，系统自动重试中 BANK_DISHONOR：银行退票
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// ACCEPT_SUCCESS：受理成功； SUCCESS：结算成功； FAIL：结算失败；FAIL_RETRY：失败重试。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分账转入账户id。当分账账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当分账账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当分账账户id类型是loginName时，本参数为用户的支付宝登录号
        /// </summary>
        [JsonPropertyName("trans_in_account_id")]
        public string TransInAccountId { get; set; }

        /// <summary>
        /// 分账转入账户id类型。 当settle_account_type 为bankCard时，本参数为cardSerialNo，表示分账账户id是银行卡编号; 当settle_account_type 为alipayBalance时，本参数为userId或者loginName，其中userId表示分账账户id是支付宝唯一用户号，loginName表示分账账户id是支付宝登录号
        /// </summary>
        [JsonPropertyName("trans_in_account_id_type")]
        public string TransInAccountIdType { get; set; }

        /// <summary>
        /// 分账账户类型。 bankCard: 分账账户为银行卡； alipayBalance: 分账账户为支付宝余额户
        /// </summary>
        [JsonPropertyName("trans_in_account_type")]
        public string TransInAccountType { get; set; }

        /// <summary>
        /// 分账转出主体账号。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID    当分账转出类型为Store，本参数为StoreID
        /// </summary>
        [JsonPropertyName("trans_in_entity_id")]
        public string TransInEntityId { get; set; }

        /// <summary>
        /// 分账转入主体类型。 SecondMerchant：分账转入主体为二级商户    Store: 结算门店
        /// </summary>
        [JsonPropertyName("trans_in_entity_type")]
        public string TransInEntityType { get; set; }

        /// <summary>
        /// 转入方二级商户信息
        /// </summary>
        [JsonPropertyName("trans_in_sub_merchant")]
        public SubMerchant TransInSubMerchant { get; set; }

        /// <summary>
        /// 分账转出主体账号。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID    当分账转出类型为Store，本参数为StoreID
        /// </summary>
        [JsonPropertyName("trans_out_entity_id")]
        public string TransOutEntityId { get; set; }

        /// <summary>
        /// 分账转出主体类型。 SecondMerchant：结算主体为二级商户，Store：结算主体为门店。
        /// </summary>
        [JsonPropertyName("trans_out_entity_type")]
        public string TransOutEntityType { get; set; }

        /// <summary>
        /// 转出方二级商户信息
        /// </summary>
        [JsonPropertyName("trans_out_sub_merchant")]
        public SubMerchant TransOutSubMerchant { get; set; }
    }
}
