using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofileQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofileQueryModel : AlipayObject
    {
        /// <summary>
        /// 渠道类型
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
