using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StageGroupInfoVO Data Structure.
    /// </summary>
    public class StageGroupInfoVO : AlipayObject
    {
        /// <summary>
        /// 学段分组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 学段类目信息列表
        /// </summary>
        [JsonPropertyName("stage_cate_infos")]
        public List<StageCateInfoVO> StageCateInfos { get; set; }
    }
}
