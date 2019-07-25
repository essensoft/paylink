using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantItemFileUploadResponse.
    /// </summary>
    public class AlipayMerchantItemFileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 文件在商品中心的素材标识
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }
    }
}
