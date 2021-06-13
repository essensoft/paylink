using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConsultModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConsultModel : AlipayObject
    {
        /// <summary>
        /// 请求参数，其中paramContent的值为base64编码串
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
