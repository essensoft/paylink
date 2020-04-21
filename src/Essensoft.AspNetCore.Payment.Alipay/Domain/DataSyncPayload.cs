using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataSyncPayload Data Structure.
    /// </summary>
    public class DataSyncPayload : AlipayObject
    {
        /// <summary>
        /// 数据同步通知模型
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
