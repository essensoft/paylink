using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialQueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料地址
        /// </summary>
        [JsonPropertyName("material_url")]
        public string MaterialUrl { get; set; }
    }
}
