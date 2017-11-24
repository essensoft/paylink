using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// InvoiceInfo Data Structure.
    /// </summary>
    public class InvoiceInfo : AlipayObject
    {
        /// <summary>
        /// 开票内容  注：json数组格式
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// 开票关键信息
        /// </summary>
        [JsonProperty("key_info")]
        public InvoiceKeyInfo KeyInfo { get; set; }
    }
}
