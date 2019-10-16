using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataTextdifferenceBaiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataTextdifferenceBaiQueryModel : AlipayObject
    {
        /// <summary>
        /// 文档的文本内容。
        /// </summary>
        [JsonProperty("text_s")]
        public string TextS { get; set; }

        /// <summary>
        /// 文档文本
        /// </summary>
        [JsonProperty("text_t")]
        public string TextT { get; set; }
    }
}
