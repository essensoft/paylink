using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoPrinterStatusNotifyModel Data Structure.
    /// </summary>
    public class AlipayEcoPrinterStatusNotifyModel : AlipayObject
    {
        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("eprint_sign")]
        public string EprintSign { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 授权类型：0=自有应用授权；1=开放应用授权
        /// </summary>
        [JsonPropertyName("oauth_type")]
        public long OauthType { get; set; }

        /// <summary>
        /// 打印机终端状态 1=在线 2=缺纸 0=离线
        /// </summary>
        [JsonPropertyName("online")]
        public long Online { get; set; }

        /// <summary>
        /// 回调时间
        /// </summary>
        [JsonPropertyName("push_time")]
        public string PushTime { get; set; }
    }
}
