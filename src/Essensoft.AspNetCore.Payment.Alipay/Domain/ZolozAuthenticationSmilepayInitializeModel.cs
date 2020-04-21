using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationSmilepayInitializeModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationSmilepayInitializeModel : AlipayObject
    {
        /// <summary>
        /// 设备指纹，用于唯一标识一台设备
        /// </summary>
        [JsonPropertyName("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 人脸识别应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 人脸识别应用版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 基础包版本号
        /// </summary>
        [JsonPropertyName("base_ver")]
        public string BaseVer { get; set; }

        /// <summary>
        /// 生物识别元信息
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
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// 机具信息，调用人脸识别SDK获取
        /// </summary>
        [JsonPropertyName("machine_info")]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [JsonPropertyName("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonPropertyName("remote_log_id")]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// ZIM版本号
        /// </summary>
        [JsonPropertyName("zim_ver")]
        public string ZimVer { get; set; }
    }
}
