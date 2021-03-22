using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyTradedetaillistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDapplyTradedetaillistQueryModel : AlipayObject
    {
        /// <summary>
        /// 起始偏移位置
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 一页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询截止时间
        /// </summary>
        [JsonPropertyName("stat_end")]
        public string StatEnd { get; set; }

        /// <summary>
        /// 查询起止日期
        /// </summary>
        [JsonPropertyName("stat_start")]
        public string StatStart { get; set; }
    }
}
