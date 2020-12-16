using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofilelistQueryResponse.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofilelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 列表
        /// </summary>
        [JsonPropertyName("pet_profiles")]
        public List<PetProfiles> PetProfiles { get; set; }
    }
}
