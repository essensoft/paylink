using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeVendorpayDevicedataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeVendorpayDevicedataUploadModel : AlipayObject
    {
        /// <summary>
        /// 客户端应用包标识
        /// </summary>
        [JsonProperty("app_package_name")]
        public string AppPackageName { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 国际移动设备标识
        /// </summary>
        [JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 国际移动用户识别码
        /// </summary>
        [JsonProperty("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// mac地址
        /// </summary>
        [JsonProperty("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 手机机型
        /// </summary>
        [JsonProperty("machine_type")]
        public string MachineType { get; set; }

        /// <summary>
        /// 手机系统版本
        /// </summary>
        [JsonProperty("phone_sys_version")]
        public string PhoneSysVersion { get; set; }

        /// <summary>
        /// 厂商公钥、base64编码
        /// </summary>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// 设备应用来源，厂商支付标记
        /// </summary>
        [JsonProperty("tidsource")]
        public string Tidsource { get; set; }

        /// <summary>
        /// 设备标识符
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// 厂商名字
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }
    }
}
