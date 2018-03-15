using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// FengdiePreviewQueryRespModel Data Structure.
    /// </summary>
    public class FengdiePreviewQueryRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶页面预览数据列表
        /// </summary>
        [JsonProperty("list")]
        public List<FengdiePreviewPagesModel> List { get; set; }
    }
}
