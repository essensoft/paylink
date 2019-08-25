using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrImageclassifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrImageclassifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片base64加密后的内容，大小控制在1.5M
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
