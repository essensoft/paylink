using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMerchant Data Structure.
    /// </summary>
    public class InsMerchant : AlipayObject
    {
        /// <summary>
        /// 机构全称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 机构简称
        /// </summary>
        [JsonPropertyName("short_name")]
        public string ShortName { get; set; }
    }
}
