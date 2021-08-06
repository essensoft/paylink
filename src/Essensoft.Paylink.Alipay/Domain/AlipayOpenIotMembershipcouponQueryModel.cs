using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotMembershipcouponQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenIotMembershipcouponQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序ID，来自于BPaaS注册的应用ID，取值通常和小程序的appId相同
        /// </summary>
        [JsonPropertyName("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// ISV序列号，来自于ISV成员体系数据
        /// </summary>
        [JsonPropertyName("membership_id")]
        public string MembershipId { get; set; }

        /// <summary>
        /// 服务码，来源于ISV自行配置，用于区分具体的服务类型
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备SN，与设备ID共同描述IoT设备信息
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }
    }
}
