using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsClearnodeCreateModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsClearnodeCreateModel : AlipayObject
    {
        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [JsonPropertyName("guid")]
        public string Guid { get; set; }
    }
}
