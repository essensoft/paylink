using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilllistQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabilllistQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，最大不超过20
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询日期
        /// </summary>
        [JsonPropertyName("query_date")]
        public string QueryDate { get; set; }
    }
}
