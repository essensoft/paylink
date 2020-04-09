using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyStoreModifyModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelFliggyStoreModifyModel : AlipayObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 主体数据
        /// </summary>
        [JsonPropertyName("data")]
        public StoreInfo Data { get; set; }

        /// <summary>
        /// 请求消息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
