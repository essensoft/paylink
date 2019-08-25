using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrCarvinQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrCarvinQueryModel : AlipayObject
    {
        /// <summary>
        /// 汽车VIN 图片base64 encode内容
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
