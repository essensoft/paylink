using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierQrcodeApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpDossierQrcodeApplyModel : AlipayObject
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
