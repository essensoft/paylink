using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertInfo Data Structure.
    /// </summary>
    public class CertInfo : AlipayObject
    {
        /// <summary>
        /// 代发时商家上传的收款方证件号码    biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 代发时商家上传的收款方证件类型。    biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }
    }
}
