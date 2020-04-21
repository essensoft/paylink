using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateSentimentDataSendModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateSentimentDataSendModel : AlipayObject
    {
        /// <summary>
        /// 国家制裁提交数据内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
