using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieTemplateListRespModel Data Structure.
    /// </summary>
    public class FengdieTemplateListRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶模板包列表，包含了多个模板信息，模板信息中包含了模板名称、模板拥有者等信息
        /// </summary>
        [JsonPropertyName("list")]
        public List<FengdieTemplateDetailModel> List { get; set; }

        /// <summary>
        /// 返回的分页数据信息，包括项目总数、当前页数、总页数等信息
        /// </summary>
        [JsonPropertyName("paginator")]
        public FengdieListPaginator Paginator { get; set; }
    }
}
