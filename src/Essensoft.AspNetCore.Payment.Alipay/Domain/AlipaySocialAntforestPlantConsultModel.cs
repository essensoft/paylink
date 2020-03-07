using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntforestPlantConsultModel Data Structure.
    /// </summary>
    public class AlipaySocialAntforestPlantConsultModel : AlipayObject
    {
        /// <summary>
        /// 出账购买树种的账户id
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 兑换类型，默认是ACCOUNT，走account账户扣能量
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 项目id，需要配合其他查询接口，查询到相关的项目之后使用。不限于树种，还包括保护地等
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
