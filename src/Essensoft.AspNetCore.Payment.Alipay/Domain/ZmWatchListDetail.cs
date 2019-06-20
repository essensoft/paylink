using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZmWatchListDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZmWatchListDetail : AlipayObject
    {
        /// <summary>
        /// 风险信息行业编码
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 风险编码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extend_info")]
        public List<ZmWatchListExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// 数据刷新时间
        /// </summary>
        [JsonProperty("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 结清状态
        /// </summary>
        [JsonProperty("settlement")]
        public bool Settlement { get; set; }

        /// <summary>
        /// 当用户进行异议处理，并核查完毕之后，仍有异议时，给出的声明
        /// </summary>
        [JsonProperty("statement")]
        public string Statement { get; set; }

        /// <summary>
        /// 用户本人对该条负面记录有异议时，表示该异议处理流程的状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 行业名单风险类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
