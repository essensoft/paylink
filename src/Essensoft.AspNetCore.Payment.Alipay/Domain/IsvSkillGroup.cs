using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvSkillGroup Data Structure.
    /// </summary>
    public class IsvSkillGroup : AlipayObject
    {
        /// <summary>
        /// isv定义的热线技能组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// isv定义的热线技能组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }
    }
}
