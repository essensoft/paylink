using System.Text.Json.Serialization;

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
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 文件在商品中心的素材标示，创建/更新商品时使用
        /// </summary>
        [JsonPropertyName("material_key")]
        public string MaterialKey { get; set; }
    }
}
