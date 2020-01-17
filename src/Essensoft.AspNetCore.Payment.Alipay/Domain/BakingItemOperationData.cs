using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BakingItemOperationData Data Structure.
    /// </summary>
    public class BakingItemOperationData : AlipayObject
    {
        /// <summary>
        /// 累计库存
        /// </summary>
        [JsonPropertyName("accumulate_inventory")]
        public string AccumulateInventory { get; set; }

        /// <summary>
        /// 操作后库存
        /// </summary>
        [JsonPropertyName("ending_inventory")]
        public string EndingInventory { get; set; }

        /// <summary>
        /// 操作后位置，传中文或id均可
        /// </summary>
        [JsonPropertyName("ending_position")]
        public string EndingPosition { get; set; }

        /// <summary>
        /// 商品毛利率，百分比毛利率*100
        /// </summary>
        [JsonPropertyName("gross_profit_margin")]
        public string GrossProfitMargin { get; set; }

        /// <summary>
        /// 操作前库存
        /// </summary>
        [JsonPropertyName("opening_inventory")]
        public string OpeningInventory { get; set; }

        /// <summary>
        /// 操作名称；如果是示例值中的操作请按示例值英文传递，其他操作自行传递有意义的英文
        /// </summary>
        [JsonPropertyName("operation_name")]
        public string OperationName { get; set; }

        /// <summary>
        /// 操作数量
        /// </summary>
        [JsonPropertyName("operation_num")]
        public string OperationNum { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 操作人，传中文或id均可
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 商品批次
        /// </summary>
        [JsonPropertyName("sku_batch")]
        public string SkuBatch { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// 商品制作时长，单位为秒
        /// </summary>
        [JsonPropertyName("sku_production_time")]
        public long SkuProductionTime { get; set; }

        /// <summary>
        /// 商品售卖价格
        /// </summary>
        [JsonPropertyName("sku_selling_price")]
        public string SkuSellingPrice { get; set; }

        /// <summary>
        /// 操作前位置，传中文或id均可
        /// </summary>
        [JsonPropertyName("starting_position")]
        public string StartingPosition { get; set; }
    }
}
