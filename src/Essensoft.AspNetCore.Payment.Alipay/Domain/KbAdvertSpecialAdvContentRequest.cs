using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertSpecialAdvContentRequest Data Structure.
    /// </summary>
    public class KbAdvertSpecialAdvContentRequest : AlipayObject
    {
        /// <summary>
        /// 红包口令模型，创建红包口令时传入该模型
        /// </summary>
        [JsonPropertyName("content_password_modify")]
        public KbAdvertContentPasswordModify ContentPasswordModify { get; set; }

        /// <summary>
        /// 广告内容类型；  当值是passwordRed时，表示修改口令红包，需要传入content_password_modify模型的参数；
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }
    }
}
