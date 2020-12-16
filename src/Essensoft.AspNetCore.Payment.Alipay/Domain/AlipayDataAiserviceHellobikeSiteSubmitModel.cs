using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceHellobikeSiteSubmitModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceHellobikeSiteSubmitModel : AlipayObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 待输出城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 期望输出日期：YYYY-MM-DD
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 禁停区域
        /// </summary>
        [JsonPropertyName("exc_fence")]
        public List<string> ExcFence { get; set; }

        /// <summary>
        /// 禁用poi
        /// </summary>
        [JsonPropertyName("exc_poi")]
        public List<string> ExcPoi { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 运营区围栏
        /// </summary>
        [JsonPropertyName("fence")]
        public List<string> Fence { get; set; }

        /// <summary>
        /// 站点缺口
        /// </summary>
        [JsonPropertyName("num")]
        public long Num { get; set; }

        /// <summary>
        /// 推荐poi
        /// </summary>
        [JsonPropertyName("rec_poi")]
        public List<string> RecPoi { get; set; }

        /// <summary>
        /// 站点大小：长cm*宽cm
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 枚举：0 助力车站点/ 1 单车站点/ 2 其他
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
