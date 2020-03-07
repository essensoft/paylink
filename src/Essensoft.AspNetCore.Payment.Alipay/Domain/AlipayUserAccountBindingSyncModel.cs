using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountBindingSyncModel Data Structure.
    /// </summary>
    public class AlipayUserAccountBindingSyncModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本号，大于等于0
        /// </summary>
        [JsonPropertyName("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 淘系用户ID
        /// </summary>
        [JsonPropertyName("havana_user_id")]
        public long HavanaUserId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 淘宝绑定关系领域枚举：     TAOBAO("0", "淘宝"),     CBU("1", "1688(CBU)"),     ALIYUN_LOGIN("2", "阿里云(免登)"),     ALIYUN_CERTIFY("3", "阿里云(认证)")
        /// </summary>
        [JsonPropertyName("realm")]
        public string Realm { get; set; }

        /// <summary>
        /// 淘宝绑定关系状态枚举：   UNBINDING("0", "未绑定"),   BINDING("1", "已绑定")
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
