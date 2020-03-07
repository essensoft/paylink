using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankFinanceAccountRysenterpriseQueryModel Data Structure.
    /// </summary>
    public class MybankFinanceAccountRysenterpriseQueryModel : AlipayObject
    {
        /// <summary>
        /// 融易收资金账户
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 客户角色号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 阿里云用户Id
        /// </summary>
        [JsonPropertyName("out_channel_id")]
        public string OutChannelId { get; set; }

        /// <summary>
        /// 外部渠道类型
        /// </summary>
        [JsonPropertyName("out_channel_type")]
        public string OutChannelType { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
