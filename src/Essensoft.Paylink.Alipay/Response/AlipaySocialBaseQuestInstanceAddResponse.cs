using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
