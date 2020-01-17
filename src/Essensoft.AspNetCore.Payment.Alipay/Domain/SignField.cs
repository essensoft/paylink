using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignField Data Structure.
    /// </summary>
    public class SignField : AlipayObject
    {
        /// <summary>
        /// 平台自动签
        /// </summary>
        [JsonPropertyName("auto_execute")]
        public string AutoExecute { get; set; }

        /// <summary>
        /// 签署人信息
        /// </summary>
        [JsonPropertyName("signer")]
        public Signer Signer { get; set; }

        /// <summary>
        /// 模板组件id
        /// </summary>
        [JsonPropertyName("struct_key")]
        public string StructKey { get; set; }
    }
}
