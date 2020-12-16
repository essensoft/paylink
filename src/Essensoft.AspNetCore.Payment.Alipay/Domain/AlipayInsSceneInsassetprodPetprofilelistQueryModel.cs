using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofilelistQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofilelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }
    }
}
