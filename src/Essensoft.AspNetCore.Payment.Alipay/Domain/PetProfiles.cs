using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PetProfiles Data Structure.
    /// </summary>
    public class PetProfiles : AlipayObject
    {
        /// <summary>
        /// 宠物档案列表
        /// </summary>
        [JsonPropertyName("pet_profile_list")]
        public List<PetProfile> PetProfileList { get; set; }

        /// <summary>
        /// 宠物类型，如猫、狗
        /// </summary>
        [JsonPropertyName("pet_type")]
        public string PetType { get; set; }
    }
}
