using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainRecommendQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainRecommendQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据年龄推荐的学段
        /// </summary>
        [JsonPropertyName("default_first_cate")]
        public CateInfoVO DefaultFirstCate { get; set; }

        /// <summary>
        /// 是否有更多
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 推荐元素列表
        /// </summary>
        [JsonPropertyName("item_infos")]
        public List<ItemInfoVO> ItemInfos { get; set; }

        /// <summary>
        /// 外部场景传入的学段
        /// </summary>
        [JsonPropertyName("selected_first_cate")]
        public CateInfoVO SelectedFirstCate { get; set; }
    }
}
