using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteAddResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteAddResponse : AlipayResponse
    {
        /// <summary>
        /// 成功：true  失败：false
        /// </summary>
        [JsonPropertyName("add_result")]
        public bool AddResult { get; set; }
    }
}
