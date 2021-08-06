using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniIsvCreateModel : AlipayObject
    {
        /// <summary>
        /// 小程序代创建请求
        /// </summary>
        [JsonPropertyName("create_mini_request")]
        public CreateMiniRequest CreateMiniRequest { get; set; }
    }
}
