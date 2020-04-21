using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayFundAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 开户产品码。如果查询托管子户余额，必传且必须传入与开户时传入的值一致。
        /// </summary>
        [JsonPropertyName("account_product_code")]
        public string AccountProductCode { get; set; }

        /// <summary>
        /// 开户场景码，与开户产品码不可同时传递。
        /// </summary>
        [JsonPropertyName("account_scene_code")]
        public string AccountSceneCode { get; set; }

        /// <summary>
        /// 查询的账号类型，如查询托管账户值为TRUSTEESHIP_ACCOUNT，查询余额账户值为ACCTRANS_ACCOUNT。查询余额账户时必填。
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员的唯一标识。如果传入的user_id为虚拟账户userId，此字段必传并比对一致性。
        /// </summary>
        [JsonPropertyName("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
