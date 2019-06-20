using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDevicelistCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDevicelistCreateModel : AlipayObject
    {
        /// <summary>
        /// 设备对象列表+不唯一+用于批量创建设备记录+协议服务商指定+0个或多个设备对象列表，单次调用传入设备对象个数不能超过200
        /// </summary>
        [JsonProperty("device_list")]
        public List<IotDevice> DeviceList { get; set; }

        /// <summary>
        /// 设备个性化信息列表+不唯一+用于设置设备的用户定制化信息+协议服务商指定
        /// </summary>
        [JsonProperty("device_personal_info_list")]
        public List<IotDevicePersonalInfo> DevicePersonalInfoList { get; set; }

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
