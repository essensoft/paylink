using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductCreateResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeProductCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功生成的productId
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
