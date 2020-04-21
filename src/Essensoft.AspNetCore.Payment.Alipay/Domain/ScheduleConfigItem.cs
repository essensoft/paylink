using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleConfigItem Data Structure.
    /// </summary>
    public class ScheduleConfigItem : AlipayObject
    {
        /// <summary>
        /// 配制名称
        /// </summary>
        [JsonPropertyName("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 日期列表
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
