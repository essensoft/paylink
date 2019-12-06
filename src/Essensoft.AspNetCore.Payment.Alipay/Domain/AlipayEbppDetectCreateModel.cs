using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppDetectCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppDetectCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务类型。巡检平台统一分配。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 数据来源（一般为系统名称）
        /// </summary>
        [JsonPropertyName("data_from_type")]
        public string DataFromType { get; set; }

        /// <summary>
        /// 外部业务标识
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 检测项列表。支持对链接url、纯文本、图片进行检测。
        /// </summary>
        [JsonPropertyName("service_list")]
        public List<DetectServiceEntity> ServiceList { get; set; }
    }
}
