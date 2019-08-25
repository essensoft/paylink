using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateSentimentDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateSentimentDataSendModel : AlipayObject
    {
        /// <summary>
        /// 国家制裁提交数据内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
