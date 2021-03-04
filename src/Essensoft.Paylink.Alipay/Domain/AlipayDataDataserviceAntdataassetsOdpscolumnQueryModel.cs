using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsOdpscolumnQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsOdpscolumnQueryModel : AlipayObject
    {
        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [JsonPropertyName("guid")]
        public string Guid { get; set; }
    }
}
