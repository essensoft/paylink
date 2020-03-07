using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationFaceInitializeModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationFaceInitializeModel : AlipayObject
    {
        /// <summary>
        /// apdidToken
        /// </summary>
        [JsonPropertyName("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// App名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// App版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// base version
        /// </summary>
        [JsonPropertyName("base_ver")]
        public string BaseVer { get; set; }

        /// <summary>
        /// bioMetaInfo
        /// </summary>
        [JsonPropertyName("bio_meta_info")]
        public string BioMetaInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// extInfo
        /// </summary>
        [JsonPropertyName("ext_info")]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// FaceMachineInfo
        /// </summary>
        [JsonPropertyName("machine_info")]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// FaceMerchantInfo
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [JsonPropertyName("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonPropertyName("remote_log_id")]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// zim version
        /// </summary>
        [JsonPropertyName("zim_ver")]
        public string ZimVer { get; set; }
    }
}
