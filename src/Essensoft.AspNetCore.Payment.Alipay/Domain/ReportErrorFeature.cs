using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReportErrorFeature Data Structure.
    /// </summary>
    public class ReportErrorFeature : AlipayObject
    {
        /// <summary>
        /// 桌号
        /// </summary>
        [JsonPropertyName("table_num")]
        public string TableNum { get; set; }
    }
}
