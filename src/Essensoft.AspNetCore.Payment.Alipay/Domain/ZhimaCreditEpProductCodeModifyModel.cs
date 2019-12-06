using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpProductCodeModifyModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpProductCodeModifyModel : AlipayObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [JsonPropertyName("code_id")]
        public string CodeId { get; set; }
    }
}
