using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotVoicemodelSyncvoiceSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotVoicemodelSyncvoiceSendModel : AlipayObject
    {
        /// <summary>
        /// 服务调用上下文
        /// </summary>
        [JsonPropertyName("context")]
        public ServiceModelContext Context { get; set; }

        /// <summary>
        /// 到账播报内容模型
        /// </summary>
        [JsonPropertyName("sync_data")]
        public SyncVoiceVO SyncData { get; set; }
    }
}
