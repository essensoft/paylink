using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessPurchaseOrderSend Data Structure.
    /// </summary>
    public class AccessPurchaseOrderSend : AlipayObject
    {
        /// <summary>
        /// 申请单明细号
        /// </summary>
        [JsonPropertyName("asset_item_id")]
        public string AssetItemId { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [JsonPropertyName("asset_order_id")]
        public string AssetOrderId { get; set; }

        /// <summary>
        /// 采购单ID
        /// </summary>
        [JsonPropertyName("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 物流公司code
        /// </summary>
        [JsonPropertyName("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonPropertyName("express_name")]
        public string ExpressName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部单号（供应商主键标识）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// PO单号
        /// </summary>
        [JsonPropertyName("po_no")]
        public string PoNo { get; set; }

        /// <summary>
        /// 回传码值数量1000(不是码物料时为0)
        /// </summary>
        [JsonPropertyName("return_qrcode_count")]
        public string ReturnQrcodeCount { get; set; }

        /// <summary>
        /// 本次发货数量
        /// </summary>
        [JsonPropertyName("ship_count")]
        public string ShipCount { get; set; }
    }
}
