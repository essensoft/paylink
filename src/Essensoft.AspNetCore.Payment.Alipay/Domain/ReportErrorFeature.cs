using Newtonsoft.Json;

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
        [JsonProperty("table_num")]
        public string TableNum { get; set; }
    }
}
