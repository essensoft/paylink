using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorldOfflineDataInfo Data Structure.
    /// </summary>
    public class WorldOfflineDataInfo : AlipayObject
    {
        /// <summary>
        /// 生码模式
        /// </summary>
        [JsonPropertyName("auth_mode")]
        public string AuthMode { get; set; }

        /// <summary>
        /// 可用票种
        /// </summary>
        [JsonPropertyName("available_ticket_types")]
        public List<WorldTicketType> AvailableTicketTypes { get; set; }

        /// <summary>
        /// 凭证服务类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 配置信息
        /// </summary>
        [JsonPropertyName("config")]
        public string Config { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [JsonPropertyName("data_from")]
        public string DataFrom { get; set; }

        /// <summary>
        /// 签名失效时间（long类型数据）
        /// </summary>
        [JsonPropertyName("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 脱机数据
        /// </summary>
        [JsonPropertyName("offline_data")]
        public string OfflineData { get; set; }

        /// <summary>
        /// 用户秘钥
        /// </summary>
        [JsonPropertyName("private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 二维码数据
        /// </summary>
        [JsonPropertyName("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 脚本mac
        /// </summary>
        [JsonPropertyName("script_mac")]
        public string ScriptMac { get; set; }

        /// <summary>
        /// 脚本名称
        /// </summary>
        [JsonPropertyName("script_name")]
        public string ScriptName { get; set; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        [JsonPropertyName("script_type")]
        public string ScriptType { get; set; }

        /// <summary>
        /// 上传原始码开关
        /// </summary>
        [JsonPropertyName("upload_raw_code")]
        public bool UploadRawCode { get; set; }

        /// <summary>
        /// 启动脚本生码
        /// </summary>
        [JsonPropertyName("use_script")]
        public bool UseScript { get; set; }
    }
}
