using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZmWatchListDetail Data Structure.
    /// </summary>
    public class ZmWatchListDetail : AlipayObject
    {
        /// <summary>
        /// 风险信息行业编码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 风险编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public List<ZmWatchListExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 数据刷新时间
        /// </summary>
        [JsonPropertyName("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 结清状态
        /// </summary>
        [JsonPropertyName("settlement")]
        public bool Settlement { get; set; }

        /// <summary>
        /// 当用户进行异议处理，并核查完毕之后，仍有异议时，给出的声明
        /// </summary>
        [JsonPropertyName("statement")]
        public string Statement { get; set; }

        /// <summary>
        /// 用户本人对该条负面记录有异议时，表示该异议处理流程的状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 行业名单风险类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
