using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetInfoItem Data Structure.
    /// </summary>
    public class AssetInfoItem : AlipayObject
    {
        /// <summary>
        /// 配送或者生产指令id.
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 由供应商自定义的分批反馈批次号，用于保持幂等，此值不传则需要按整批反馈.(由字母,数字,下划线组成)
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物流公司code
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 机具序列号
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 生产资料, 配送资料
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 格式按照type约定的类型传入, 约定参见物料平台openAPI文档.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
