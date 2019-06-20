using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetInfoCorrectionItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetInfoCorrectionItem : AlipayObject
    {
        /// <summary>
        /// 配送, 生产指令id.
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 变更原因
        /// </summary>
        [JsonProperty("change_reason")]
        public string ChangeReason { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [JsonProperty("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 待更新物料信息
        /// </summary>
        [JsonProperty("new_asset_value")]
        public string NewAssetValue { get; set; }

        /// <summary>
        /// 修改物料信息，新物料id
        /// </summary>
        [JsonProperty("new_item_id")]
        public string NewItemId { get; set; }

        /// <summary>
        /// 原物料信息
        /// </summary>
        [JsonProperty("original_asset_value")]
        public string OriginalAssetValue { get; set; }

        /// <summary>
        /// 原物料生产或配送供应商 id
        /// </summary>
        [JsonProperty("original_supplier_id")]
        public string OriginalSupplierId { get; set; }

        /// <summary>
        /// 请求唯一id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
