using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataSecCheckResult Data Structure.
    /// </summary>
    [Serializable]
    public class DataSecCheckResult : AlipayObject
    {
        /// <summary>
        /// 口碑校验时间
        /// </summary>
        [JsonProperty("check_date")]
        public string CheckDate { get; set; }

        /// <summary>
        /// 保证传入唯一，用于标识唯一文本或图片
        /// </summary>
        [JsonProperty("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据返回状态 PASSED--数据识别通过，DELETE--删除，SYNCNOTICE--异步通知，RETRY--需要重试
        /// </summary>
        [JsonProperty("data_status")]
        public string DataStatus { get; set; }
    }
}
