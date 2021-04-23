using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainTagsQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainTagsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 标签信息列表
        /// </summary>
        [JsonPropertyName("tag_infos")]
        public List<TagInfoVO> TagInfos { get; set; }
    }
}
