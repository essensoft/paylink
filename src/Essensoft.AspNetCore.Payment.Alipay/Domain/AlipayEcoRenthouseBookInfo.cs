using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBookInfo Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseBookInfo : AlipayObject
    {
        /// <summary>
        /// 定金金额
        /// </summary>
        [JsonPropertyName("book_amount")]
        public string BookAmount { get; set; }

        /// <summary>
        /// 约定月租金额
        /// </summary>
        [JsonPropertyName("book_sale_amount")]
        public string BookSaleAmount { get; set; }

        /// <summary>
        /// 约定最晚签约日格式 YYYY-MM-dd
        /// </summary>
        [JsonPropertyName("latest_signing_date")]
        public string LatestSigningDate { get; set; }

        /// <summary>
        /// 约定租约开始时间格式 YYYY-MM-dd
        /// </summary>
        [JsonPropertyName("lease_begin_date")]
        public string LeaseBeginDate { get; set; }

        /// <summary>
        /// 约定租约开始结束格式 YYYY-MM-dd
        /// </summary>
        [JsonPropertyName("lease_end_date")]
        public string LeaseEndDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
