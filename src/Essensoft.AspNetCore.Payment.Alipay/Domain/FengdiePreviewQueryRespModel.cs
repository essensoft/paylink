using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdiePreviewQueryRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdiePreviewQueryRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶页面预览数据列表
        /// </summary>
        [JsonProperty("list")]
        public List<FengdiePreviewPagesModel> List { get; set; }
    }
}
