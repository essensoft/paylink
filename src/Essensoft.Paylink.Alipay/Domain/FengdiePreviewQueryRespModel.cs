using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FengdiePreviewQueryRespModel Data Structure.
    /// </summary>
    public class FengdiePreviewQueryRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶页面预览数据列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<FengdiePreviewPagesModel> List { get; set; }
    }
}
