using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrdersQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrdersQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否查询打款计划列表。true-查看；false-不查看
        /// </summary>
        [JsonPropertyName("include_plans")]
        public bool IncludePlans { get; set; }

        /// <summary>
        /// 当前分页数
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
        /// 二级商户在直付通的smid值
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 若为空则查询全量，不支持多选。1打款调度中；2打款完成；3退款中；4退款完成。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
