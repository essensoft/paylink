using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetInfoCorrectionItem Data Structure.
    /// </summary>
    public class AssetInfoCorrectionItem : AlipayObject
    {
        /// <summary>
        /// 配送, 生产指令id.
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 变更原因
        /// </summary>
        [JsonPropertyName("change_reason")]
        public string ChangeReason { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [JsonPropertyName("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 待更新物料信息
        /// </summary>
        [JsonPropertyName("new_asset_value")]
        public string NewAssetValue { get; set; }

        /// <summary>
        /// 修改物料信息，新物料id
        /// </summary>
        [JsonPropertyName("new_item_id")]
        public string NewItemId { get; set; }

        /// <summary>
        /// 原物料信息
        /// </summary>
        [JsonPropertyName("original_asset_value")]
        public string OriginalAssetValue { get; set; }

        /// <summary>
        /// 原物料生产或配送供应商 id
        /// </summary>
        [JsonPropertyName("original_supplier_id")]
        public string OriginalSupplierId { get; set; }

        /// <summary>
        /// 请求唯一id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
