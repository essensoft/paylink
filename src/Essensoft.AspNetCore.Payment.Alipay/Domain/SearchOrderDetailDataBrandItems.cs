using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOrderDetailDataBrandItems Data Structure.
    /// </summary>
    public class SearchOrderDetailDataBrandItems : AlipayObject
    {
        /// <summary>
        /// 工单详情bizid
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 上下架状态
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 关键词信息
        /// </summary>
        [JsonPropertyName("brand_box_keywords")]
        public string BrandBoxKeywords { get; set; }

        /// <summary>
        /// 品牌展示模板类型
        /// </summary>
        [JsonPropertyName("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 工单详情数据channel
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 工单详情数据信息
        /// </summary>
        [JsonPropertyName("data")]
        public List<SearchOrderBrandDetail> Data { get; set; }

        /// <summary>
        /// 工单详情数据merchant_type
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
