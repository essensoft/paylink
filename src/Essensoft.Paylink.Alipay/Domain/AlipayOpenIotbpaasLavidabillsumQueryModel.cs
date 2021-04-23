using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabillsumQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabillsumQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [JsonPropertyName("query_date")]
        public string QueryDate { get; set; }
    }
}
