using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaOpenAppHylabeltwoQueryModel Data Structure.
    /// </summary>
    public class ZhimaOpenAppHylabeltwoQueryModel : AlipayObject
    {
        /// <summary>
        /// 公司名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonPropertyName("opr_scope")]
        public string OprScope { get; set; }
    }
}
