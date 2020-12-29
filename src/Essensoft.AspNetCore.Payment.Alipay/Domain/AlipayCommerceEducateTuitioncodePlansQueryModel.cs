using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlansQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodePlansQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否包含订单信息
        /// </summary>
        [JsonPropertyName("include_order")]
        public bool IncludeOrder { get; set; }

        /// <summary>
        /// 分页号
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 场景，固定"XFM"
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 直付通smid,间联商户必传
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 若为空则查询全量  1打款调度中  2打款完成  3退款中  4退款完成
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
