using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceUnbindModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodDeviceUnbindModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id;identity_type='ID'时必填
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设备SN，与supplier_id配合作为设备识别的唯一标识;identity_type='SN'时必填
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 可选项[SN,ID]  SN-使用device_sn、supplier_id联合作为设备唯一识别标识  ID-使用biz_tid作为设备唯一识别标识
        /// </summary>
        [JsonPropertyName("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 原绑定关系，必须与已存在的绑定关系一致才允许解绑
        /// </summary>
        [JsonPropertyName("principal")]
        public List<IotDevicePrincipal> Principal { get; set; }

        /// <summary>
        /// 设备供应商id，与device_sn配合作为设备识别唯一标识;identity_type='SN'时必填
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
