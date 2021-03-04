using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceModifyResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回用户添加小目标实例
        /// </summary>
        [JsonPropertyName("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
