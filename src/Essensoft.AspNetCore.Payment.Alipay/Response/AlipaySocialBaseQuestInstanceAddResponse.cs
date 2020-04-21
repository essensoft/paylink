using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceAddResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceAddResponse : AlipayResponse
    {
        /// <summary>
        /// 小目标实例模型
        /// </summary>
        [JsonPropertyName("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
