using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialForestTreeQueryResponse.
    /// </summary>
    public class AlipaySocialForestTreeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 森林开通状态： NON_OPEN：未开通；【种树记录列表为空list】 OPEN：已开通； CLOSED：已关闭；
        /// </summary>
        [JsonPropertyName("forest_status")]
        public string ForestStatus { get; set; }

        /// <summary>
        /// 数据格式为List<TreeData>，按树种、是否合种分类统计后得到用户种植树信息数据列表
        /// </summary>
        [JsonPropertyName("tree_datas")]
        public List<TreeData> TreeDatas { get; set; }
    }
}
