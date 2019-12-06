using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessLicenseCertFileds Data Structure.
    /// </summary>
    public class BusinessLicenseCertFileds : AlipayObject
    {
        /// <summary>
        /// 社会信用代码
        /// </summary>
        [JsonPropertyName("creditcode")]
        public string Creditcode { get; set; }

        /// <summary>
        /// 公司名字
        /// </summary>
        [JsonPropertyName("entname")]
        public string Entname { get; set; }
    }
}
