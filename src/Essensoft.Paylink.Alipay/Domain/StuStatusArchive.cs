using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// StuStatusArchive Data Structure.
    /// </summary>
    public class StuStatusArchive : AlipayObject
    {
        /// <summary>
        /// 所在学校名称
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }
    }
}
