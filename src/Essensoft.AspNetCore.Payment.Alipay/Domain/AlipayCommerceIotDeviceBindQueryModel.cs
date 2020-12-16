using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceBindQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceBindQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用类型，目前只支持小程序MINI_APP
        /// </summary>
        [JsonPropertyName("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 应用ID，目前暂不使用，可不填
        /// </summary>
        [JsonPropertyName("application_id")]
        public string ApplicationId { get; set; }

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
        /// 小程序ID，当app_type为MINI_APP时，设置该值； 如意LITE设备，请填写"RUYI_LITE"
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 设备供应商ID：supplierId
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
