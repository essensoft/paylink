using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StageCateInfoVO Data Structure.
    /// </summary>
    public class StageCateInfoVO : AlipayObject
    {
        /// <summary>
        /// 类目信息列表
        /// </summary>
        [JsonPropertyName("cate_infos")]
        public List<CateInfoVO> CateInfos { get; set; }

        /// <summary>
        /// 学段编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 学段名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
