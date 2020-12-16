using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditUserInfoShareQueryResponse.
    /// </summary>
    public class MybankCreditUserInfoShareQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户头像地址
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 【注意】只有is_certified为T的时候才有意义，否则不保证准确性. 性别（F：女性；M：男性）。
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
