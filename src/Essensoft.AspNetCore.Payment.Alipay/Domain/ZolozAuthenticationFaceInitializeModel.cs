using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationFaceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationFaceInitializeModel : AlipayObject
    {
        /// <summary>
        /// apdidToken
        /// </summary>
        [JsonProperty("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// App名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// App版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// base version
        /// </summary>
        [JsonProperty("base_ver")]
        public string BaseVer { get; set; }

        /// <summary>
        /// bioMetaInfo
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
        /// extInfo
        /// </summary>
        [JsonProperty("ext_info")]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// FaceMachineInfo
        /// </summary>
        [JsonProperty("machine_info")]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// FaceMerchantInfo
        /// </summary>
        [JsonProperty("merchant_info")]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [JsonProperty("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("remote_log_id")]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// zim version
        /// </summary>
        [JsonProperty("zim_ver")]
        public string ZimVer { get; set; }
    }
}
