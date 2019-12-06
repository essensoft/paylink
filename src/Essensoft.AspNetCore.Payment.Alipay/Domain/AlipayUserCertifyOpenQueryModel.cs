using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyOpenQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyOpenQueryModel : AlipayObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，由开放认证初始化接口调用后生成，后续的操作都需要用到
        /// </summary>
        [JsonPropertyName("certify_id")]
        public string CertifyId { get; set; }
    }
}
