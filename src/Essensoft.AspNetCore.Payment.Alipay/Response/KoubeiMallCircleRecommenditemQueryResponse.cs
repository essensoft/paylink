using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallCircleRecommenditemQueryResponse.
    /// </summary>
    public class KoubeiMallCircleRecommenditemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否有更多商品； true：下一页有商品 false：下一页无商品
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 下一页起始查询值
        /// </summary>
        [JsonPropertyName("next_start")]
        public long NextStart { get; set; }

        /// <summary>
        /// 每页查询量，分页长度
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 生活圈推荐商品信息模型
        /// </summary>
        [JsonPropertyName("recommend_item")]
        public List<CircleRecommendItemDTO> RecommendItem { get; set; }

        /// <summary>
        /// 业务请求成功与否; true：成功  false：失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
