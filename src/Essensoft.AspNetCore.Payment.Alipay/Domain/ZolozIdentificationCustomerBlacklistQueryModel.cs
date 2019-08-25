using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerBlacklistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerBlacklistQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备指纹
        /// </summary>
        [JsonProperty("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 设备指纹token
        /// </summary>
        [JsonProperty("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 淘宝无线安全设备标识
        /// </summary>
        [JsonProperty("umid")]
        public string Umid { get; set; }
    }
}
