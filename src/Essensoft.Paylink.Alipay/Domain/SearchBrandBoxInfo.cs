using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchBrandBoxInfo Data Structure.
    /// </summary>
    public class SearchBrandBoxInfo : AlipayObject
    {
        /// <summary>
        /// box基础信息
        /// </summary>
        [JsonPropertyName("base_info")]
        public BoxExclusiveBase BaseInfo { get; set; }

        /// <summary>
        /// box状态
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// box类型
        /// </summary>
        [JsonPropertyName("box_type")]
        public string BoxType { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 提报来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// box服务工单信息
        /// </summary>
        [JsonPropertyName("functions_order_info")]
        public BoxOrderStatusInfo FunctionsOrderInfo { get; set; }

        /// <summary>
        /// 品牌触发词信息
        /// </summary>
        [JsonPropertyName("keywords")]
        public BoxExclusiveKeyword Keywords { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 官方账号
        /// </summary>
        [JsonPropertyName("related_accounts")]
        public List<BoxExclusiveService> RelatedAccounts { get; set; }

        /// <summary>
        /// 功能服务
        /// </summary>
        [JsonPropertyName("related_functions")]
        public List<BoxExclusiveService> RelatedFunctions { get; set; }
    }
}
