using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoPrinterStatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoPrinterStatusNotifyModel : AlipayObject
    {
        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("eprint_sign")]
        public string EprintSign { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 授权类型：0=自有应用授权；1=开放应用授权
        /// </summary>
        [JsonProperty("oauth_type")]
        public long OauthType { get; set; }

        /// <summary>
        /// 打印机终端状态 1=在线 2=缺纸 0=离线
        /// </summary>
        [JsonProperty("online")]
        public long Online { get; set; }

        /// <summary>
        /// 回调时间
        /// </summary>
        [JsonProperty("push_time")]
        public string PushTime { get; set; }
    }
}
