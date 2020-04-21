using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialCreateResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料http地址
        /// </summary>
        [JsonPropertyName("material_url")]
        public string MaterialUrl { get; set; }
    }
}
