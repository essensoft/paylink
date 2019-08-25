using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodDeviceBindModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id;identity_type='ID'时必填
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设备SN，与supplier_id配合作为设备识别的唯一标识;identity_type='SN'时必填
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 绑定扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 可选项[SN,ID]  SN-使用device_sn、supplier_id联合作为设备唯一识别标识  ID-使用biz_tid作为设备唯一识别标识
        /// </summary>
        [JsonProperty("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 绑定关系
        /// </summary>
        [JsonProperty("principal")]
        public List<IotDevicePrincipal> Principal { get; set; }

        /// <summary>
        /// 设备供应商id，与device_sn配合作为设备识别唯一标识;identity_type='SN'时必填
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }
    }
}
