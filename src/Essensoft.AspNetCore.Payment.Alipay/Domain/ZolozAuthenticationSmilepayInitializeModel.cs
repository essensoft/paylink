using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationSmilepayInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationSmilepayInitializeModel : AlipayObject
    {
        /// <summary>
        /// 设备指纹，用于唯一标识一台设备
        /// </summary>
        [JsonProperty("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 人脸识别应用名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 人脸识别应用版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 基础包版本号
        /// </summary>
        [JsonProperty("base_ver")]
        public string BaseVer { get; set; }

        /// <summary>
        /// 生物识别元信息
        /// </summary>
        [JsonProperty("bio_meta_info")]
        public string BioMetaInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// 机具信息，调用人脸识别SDK获取
        /// </summary>
        [JsonProperty("machine_info")]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonProperty("merchant_info")]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [JsonProperty("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("remote_log_id")]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// ZIM版本号
        /// </summary>
        [JsonProperty("zim_ver")]
        public string ZimVer { get; set; }
    }
}
