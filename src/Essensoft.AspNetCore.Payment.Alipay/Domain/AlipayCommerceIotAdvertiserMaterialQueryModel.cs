using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialQueryModel : AlipayObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
