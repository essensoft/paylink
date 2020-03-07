using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataDetail Data Structure.
    /// </summary>
    public class DataDetail : AlipayObject
    {
        /// <summary>
        /// 数据汇总时间，格式：yyyyMMdd
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        [JsonPropertyName("click")]
        public long Click { get; set; }

        /// <summary>
        /// 投放转化数据
        /// </summary>
        [JsonPropertyName("conversion_data_list")]
        public List<ConversionDataDetail> ConversionDataList { get; set; }

        /// <summary>
        /// 消费，单元：分
        /// </summary>
        [JsonPropertyName("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 展现量
        /// </summary>
        [JsonPropertyName("impression")]
        public long Impression { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放对应的外部资源ID
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }
    }
}
