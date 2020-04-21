using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceserviceCancelModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceserviceCancelModel : AlipayObject
    {
        /// <summary>
        /// 协议服务商定义的设备服务id+不唯一+用于指定要撤销的服务+协议服务商在创建该服务时指定的该服务的id+该字段不是必填字段，如果不指定，则会撤销该协议服务商的默认设备服务实例
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
