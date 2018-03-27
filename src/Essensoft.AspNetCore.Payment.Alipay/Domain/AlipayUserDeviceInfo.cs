using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDeviceInfo Data Structure.
    /// </summary>
    public class AlipayUserDeviceInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息，json格式的字符串
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 移动设备国际身份码缩写：移动设备国际身份码缩写。仅移动端
        /// </summary>
        [JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// ipv4地址
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// mac地址，冒号分隔
        /// </summary>
        [JsonProperty("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("os_name")]
        public string OsName { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [JsonProperty("os_version")]
        public string OsVersion { get; set; }
    }
}
