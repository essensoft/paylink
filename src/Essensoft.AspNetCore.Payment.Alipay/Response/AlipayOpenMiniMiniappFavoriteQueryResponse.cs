using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户是否已收藏调用方的小程序
        /// </summary>
        [JsonPropertyName("favorite")]
        public bool Favorite { get; set; }
    }
}
