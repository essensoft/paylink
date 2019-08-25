using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppDetectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppDetectCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务类型。巡检平台统一分配。
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 数据来源（一般为系统名称）
        /// </summary>
        [JsonProperty("data_from_type")]
        public string DataFromType { get; set; }

        /// <summary>
        /// 外部业务标识
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 检测项列表。支持对链接url、纯文本、图片进行检测。
        /// </summary>
        [JsonProperty("service_list")]
        public List<DetectServiceEntity> ServiceList { get; set; }
    }
}
