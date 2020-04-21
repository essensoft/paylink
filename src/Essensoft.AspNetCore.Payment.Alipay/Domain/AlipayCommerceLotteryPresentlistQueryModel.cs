using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLotteryPresentlistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceLotteryPresentlistQueryModel : AlipayObject
    {
        /// <summary>
        /// 结束日期，格式为yyyyMMdd
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 开始日期，格式为yyyyMMdd
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 页号，必须大于0，默认为1
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小，必须大于0，最大为500，默认为500
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
