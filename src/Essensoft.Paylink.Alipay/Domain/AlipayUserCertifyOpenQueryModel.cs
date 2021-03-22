using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyOpenQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyOpenQueryModel : AlipayObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，通过alipay.user.certify.open.initialize(身份认证初始化服务)接口同步响应获取。
        /// </summary>
        [JsonPropertyName("certify_id")]
        public string CertifyId { get; set; }
    }
}
