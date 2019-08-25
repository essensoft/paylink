using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingMaterialImageUploadResponse.
    /// </summary>
    public class AlipayMarketingMaterialImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片唯一资源ID
        /// </summary>
        [JsonProperty("resource_id")]
        public string ResourceId { get; set; }
    }
}
