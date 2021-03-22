using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasMerchantorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 截止时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页size
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
