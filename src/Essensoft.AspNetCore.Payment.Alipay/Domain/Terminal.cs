using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Terminal Data Structure.
    /// </summary>
    [Serializable]
    public class Terminal : AlipayObject
    {
        /// <summary>
        /// 终端运行环境MAC地址列表，多个用“,”分割
        /// </summary>
        [JsonProperty("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 操作系统类型
        /// </summary>
        [JsonProperty("os")]
        public string Os { get; set; }

        /// <summary>
        /// 操作系统架构
        /// </summary>
        [JsonProperty("os_arch")]
        public string OsArch { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [JsonProperty("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 终端类型
        /// </summary>
        [JsonProperty("terminal_type")]
        public string TerminalType { get; set; }

        /// <summary>
        /// 终端版本号
        /// </summary>
        [JsonProperty("terminal_version")]
        public string TerminalVersion { get; set; }
    }
}
