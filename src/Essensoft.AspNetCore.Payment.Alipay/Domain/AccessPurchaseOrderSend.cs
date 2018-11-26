using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessPurchaseOrderSend Data Structure.
    /// </summary>
    [Serializable]
    public class AccessPurchaseOrderSend : AlipayObject
    {
        /// <summary>
        /// 申请单明细号
        /// </summary>
        [JsonProperty("asset_item_id")]
        [XmlElement("asset_item_id")]
        public string AssetItemId { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [JsonProperty("asset_order_id")]
        [XmlElement("asset_order_id")]
        public string AssetOrderId { get; set; }

        /// <summary>
        /// 采购单ID
        /// </summary>
        [JsonProperty("asset_purchase_id")]
        [XmlElement("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 物流公司code
        /// </summary>
        [JsonProperty("express_code")]
        [XmlElement("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("express_name")]
        [XmlElement("express_name")]
        public string ExpressName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("express_no")]
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部单号（供应商主键标识）
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// PO单号
        /// </summary>
        [JsonProperty("po_no")]
        [XmlElement("po_no")]
        public string PoNo { get; set; }

        /// <summary>
        /// 回传码值数量1000(不是码物料时为0)
        /// </summary>
        [JsonProperty("return_qrcode_count")]
        [XmlElement("return_qrcode_count")]
        public string ReturnQrcodeCount { get; set; }

        /// <summary>
        /// 本次发货数量
        /// </summary>
        [JsonProperty("ship_count")]
        [XmlElement("ship_count")]
        public string ShipCount { get; set; }
    }
}
