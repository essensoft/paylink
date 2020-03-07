using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintPrinterAddModel Data Structure.
    /// </summary>
    public class AlipayEcoEprintPrinterAddModel : AlipayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [JsonPropertyName("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 终端秘钥
        /// </summary>
        [JsonPropertyName("msign")]
        public string Msign { get; set; }

        /// <summary>
        /// 绑定手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonPropertyName("print_name")]
        public string PrintName { get; set; }
    }
}
