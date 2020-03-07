using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillInferenceResult Data Structure.
    /// </summary>
    public class BillInferenceResult : AlipayObject
    {
        /// <summary>
        /// 角度
        /// </summary>
        [JsonPropertyName("angle")]
        public long Angle { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [JsonPropertyName("bill_score")]
        public long BillScore { get; set; }

        /// <summary>
        /// 算法版本
        /// </summary>
        [JsonPropertyName("bill_version")]
        public string BillVersion { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        [JsonPropertyName("capital_sum")]
        public List<string> CapitalSum { get; set; }

        /// <summary>
        /// 发票时间
        /// </summary>
        [JsonPropertyName("date")]
        public List<string> Date { get; set; }

        /// <summary>
        /// 发票报销人
        /// </summary>
        [JsonPropertyName("name")]
        public List<string> Name { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        [JsonPropertyName("no")]
        public List<string> No { get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [JsonPropertyName("rotate_shape")]
        public List<string> RotateShape { get; set; }

        /// <summary>
        /// 发票标题
        /// </summary>
        [JsonPropertyName("title")]
        public List<string> Title { get; set; }
    }
}
