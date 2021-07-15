using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HealthDrugCatalogueItem Data Structure.
    /// </summary>
    public class HealthDrugCatalogueItem : AlipayObject
    {
        /// <summary>
        /// 是否是目录内药品
        /// </summary>
        [JsonPropertyName("catalogue_listed")]
        public bool CatalogueListed { get; set; }

        /// <summary>
        /// 剂型
        /// </summary>
        [JsonPropertyName("dosage_forms")]
        public string DosageForms { get; set; }

        /// <summary>
        /// 药品分类
        /// </summary>
        [JsonPropertyName("drug_classification")]
        public string DrugClassification { get; set; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [JsonPropertyName("general_name")]
        public string GeneralName { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 药品商品名
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 生产厂家名称
        /// </summary>
        [JsonPropertyName("manufacturer_name")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 最大可购买数量，如果为空则不限制
        /// </summary>
        [JsonPropertyName("max_purchase_quantity")]
        public long MaxPurchaseQuantity { get; set; }

        /// <summary>
        /// 最小可购买数量，如果为空则不限制
        /// </summary>
        [JsonPropertyName("min_purchase_quantity")]
        public long MinPurchaseQuantity { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonPropertyName("specifications")]
        public string Specifications { get; set; }

        /// <summary>
        /// 支持急诊配送
        /// </summary>
        [JsonPropertyName("support_emergency_delivery")]
        public bool SupportEmergencyDelivery { get; set; }

        /// <summary>
        /// 用法用量
        /// </summary>
        [JsonPropertyName("usage_dosage")]
        public string UsageDosage { get; set; }
    }
}
