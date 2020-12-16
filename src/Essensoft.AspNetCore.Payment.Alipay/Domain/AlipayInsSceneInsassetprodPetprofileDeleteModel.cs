using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofileDeleteModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofileDeleteModel : AlipayObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 宠物ID
        /// </summary>
        [JsonPropertyName("pet_id")]
        public string PetId { get; set; }
    }
}
