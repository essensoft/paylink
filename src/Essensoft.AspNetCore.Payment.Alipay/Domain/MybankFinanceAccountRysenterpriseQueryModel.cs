using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankFinanceAccountRysenterpriseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinanceAccountRysenterpriseQueryModel : AlipayObject
    {
        /// <summary>
        /// 融易收资金账户
        /// </summary>
        [JsonProperty("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [JsonProperty("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 客户角色号
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 阿里云用户Id
        /// </summary>
        [JsonProperty("out_channel_id")]
        public string OutChannelId { get; set; }

        /// <summary>
        /// 外部渠道类型
        /// </summary>
        [JsonProperty("out_channel_type")]
        public string OutChannelType { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
