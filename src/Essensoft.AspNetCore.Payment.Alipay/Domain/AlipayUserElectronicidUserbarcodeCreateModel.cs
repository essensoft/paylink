using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserElectronicidUserbarcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayUserElectronicidUserbarcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 机构方根据cert_id查到机构内部用户信息的唯一字符串。比如：身份证号+姓名 AES加密后的值；
        /// </summary>
        [JsonPropertyName("cert_id")]
        public string CertId { get; set; }

        /// <summary>
        /// 二维码超时时间，单位秒
        /// </summary>
        [JsonPropertyName("expire_time")]
        public long ExpireTime { get; set; }
    }
}
