using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConfirmModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConfirmModel : AlipayObject
    {
        /// <summary>
        /// 请求参数，其中paramContent为base64编码串
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
