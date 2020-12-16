using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotDeviceQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenIotDeviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备ID：biztid
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选项[SN,ID] SN-使用supplier_id、device_sn联合作为设备唯一识别标识 ID-使用biztid作为设备唯一识别标识
        /// </summary>
        [JsonPropertyName("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 设备序列号：SN
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 设备供应商ID：supplierId
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 查询类型[MERCHANT,SHOP]，MERCHANT-设备商户绑定关系
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
