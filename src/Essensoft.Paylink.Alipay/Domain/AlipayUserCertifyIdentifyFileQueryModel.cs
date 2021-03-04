using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyFileQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyIdentifyFileQueryModel : AlipayObject
    {
        /// <summary>
        /// 文件的地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
