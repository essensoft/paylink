using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDeviceCrashinfoUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDeviceCrashinfoUploadModel : AlipayObject
    {
        /// <summary>
        /// Crash事件发生时间
        /// </summary>
        [JsonProperty("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 扩展信息(JSON格式)
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("hardware_version")]
        public string HardwareVersion { get; set; }

        /// <summary>
        /// 日志上报时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("log_time")]
        public string LogTime { get; set; }

        /// <summary>
        /// 消息类型 CRASH_MSG/SSIDS_MSG
        /// </summary>
        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 第三方应用的app_id
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [JsonProperty("sn_id")]
        public string SnId { get; set; }
    }
}
