using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataSecCheckResult Data Structure.
    /// </summary>
    public class DataSecCheckResult : AlipayObject
    {
        /// <summary>
        /// 口碑校验时间
        /// </summary>
        [JsonPropertyName("check_date")]
        public string CheckDate { get; set; }

        /// <summary>
        /// 保证传入唯一，用于标识唯一文本或图片
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据返回状态 PASSED--数据识别通过，DELETE--删除，SYNCNOTICE--异步通知，RETRY--需要重试
        /// </summary>
        [JsonPropertyName("data_status")]
        public string DataStatus { get; set; }
    }
}
