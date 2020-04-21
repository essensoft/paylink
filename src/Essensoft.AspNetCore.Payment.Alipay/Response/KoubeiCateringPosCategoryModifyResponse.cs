using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }
    }
}
