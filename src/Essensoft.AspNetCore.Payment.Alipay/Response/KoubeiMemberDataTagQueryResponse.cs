using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberDataTagQueryResponse.
    /// </summary>
    public class KoubeiMemberDataTagQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是会员
        /// </summary>
        [JsonPropertyName("card_member")]
        public bool CardMember { get; set; }

        /// <summary>
        /// 类目标签
        /// </summary>
        [JsonPropertyName("cate_prefer_label")]
        public string CatePreferLabel { get; set; }

        /// <summary>
        /// 潮标签
        /// </summary>
        [JsonPropertyName("fashion_label")]
        public string FashionLabel { get; set; }

        /// <summary>
        /// 口味标签
        /// </summary>
        [JsonPropertyName("taste_prefer_label")]
        public string TastePreferLabel { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
