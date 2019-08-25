using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceDeleteModel : AlipayObject
    {
        /// <summary>
        /// 设备id+唯一+协议服务商用于唯一标识一个设备的设备id+唯一+协议服务商创建设备记录时指定
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [JsonProperty("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
