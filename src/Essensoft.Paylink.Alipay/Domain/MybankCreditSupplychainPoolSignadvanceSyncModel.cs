using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainPoolSignadvanceSyncModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainPoolSignadvanceSyncModel : AlipayObject
    {
        /// <summary>
        /// 客户支付宝登录号，饿了么发薪贷场景是外包服务供应商的支付宝登录号
        /// </summary>
        [JsonPropertyName("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 渠道标签
        /// </summary>
        [JsonPropertyName("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 合作机构ipRoleId，饿了么发薪贷场景是饿了么ipRoleId
        /// </summary>
        [JsonPropertyName("data_org_ip_role_id")]
        public string DataOrgIpRoleId { get; set; }

        /// <summary>
        /// 操作类别
        /// </summary>
        [JsonPropertyName("operate_category")]
        public string OperateCategory { get; set; }

        /// <summary>
        /// AGREE:同意, REJECT: 拒绝
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [JsonPropertyName("reject_msg")]
        public string RejectMsg { get; set; }
    }
}
