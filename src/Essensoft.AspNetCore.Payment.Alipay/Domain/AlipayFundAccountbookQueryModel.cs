using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundAccountbookQueryModel Data Structure.
    /// </summary>
    public class AlipayFundAccountbookQueryModel : AlipayObject
    {
        /// <summary>
        /// 记账账簿id
        /// </summary>
        [JsonPropertyName("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员的唯一标识，如果传入account_book_id此字段必传并比对一致性。
        /// </summary>
        [JsonPropertyName("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 资金记账本的开通场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
