using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintPrinterAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintPrinterAddModel : AlipayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [JsonProperty("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 终端秘钥
        /// </summary>
        [JsonProperty("msign")]
        public string Msign { get; set; }

        /// <summary>
        /// 绑定手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonProperty("print_name")]
        public string PrintName { get; set; }
    }
}
