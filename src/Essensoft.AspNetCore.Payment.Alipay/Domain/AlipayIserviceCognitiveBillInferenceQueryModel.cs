using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveBillInferenceQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片大小
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }
    }
}
