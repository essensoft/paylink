using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialForestSimplecertificateQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialForestSimplecertificateQueryModel : AlipayObject
    {
        /// <summary>
        /// 年份
        /// </summary>
        [JsonPropertyName("year")]
        public string Year { get; set; }
    }
}
