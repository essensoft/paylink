using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SnApplyInfo Data Structure.
    /// </summary>
    public class SnApplyInfo : AlipayObject
    {
        /// <summary>
        /// 唯一id
        /// </summary>
        [JsonPropertyName("apply_id")]
        public long ApplyId { get; set; }

        /// <summary>
        /// 申请单描述
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 生成sn的数据
        /// </summary>
        [JsonPropertyName("sn_count")]
        public long SnCount { get; set; }

        /// <summary>
        /// 申请单状态  -1表示无效 1 表示生成失败 2.申请单生成成功
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
