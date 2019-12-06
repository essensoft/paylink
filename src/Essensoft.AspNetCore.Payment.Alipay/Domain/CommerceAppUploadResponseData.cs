using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommerceAppUploadResponseData Data Structure.
    /// </summary>
    public class CommerceAppUploadResponseData : AlipayObject
    {
        /// <summary>
        /// 返回主体中具体内容
        /// </summary>
        [JsonPropertyName("response")]
        public string Response { get; set; }

        /// <summary>
        /// 系统时间
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }
}
