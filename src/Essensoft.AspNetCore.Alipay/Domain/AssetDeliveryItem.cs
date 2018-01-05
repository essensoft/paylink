using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryItem Data Structure.
    /// </summary>
    public class AssetDeliveryItem : AlipayObject
    {
        /// <summary>
        /// 配送数量
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonProperty("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 配送订单唯一Id
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 支付宝内部的配送流水号, 可供物料商和物流商用于对账.
        /// </summary>
        [JsonProperty("assign_out_order_id")]
        public string AssignOutOrderId { get; set; }

        /// <summary>
        /// 物料渠道标识
        /// </summary>
        [JsonProperty("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 发送地址
        /// </summary>
        [JsonProperty("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 配送指令生成日期, 格式:yyyy-MM-dd HH：mm:ss
        /// </summary>
        [JsonProperty("gmt_assign")]
        public string GmtAssign { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [JsonProperty("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 面单信息
        /// </summary>
        [JsonProperty("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 对应供应商pid
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 对应供应商名称
        /// </summary>
        [JsonProperty("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 接收地址(目的地址)
        /// </summary>
        [JsonProperty("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }
    }
}
