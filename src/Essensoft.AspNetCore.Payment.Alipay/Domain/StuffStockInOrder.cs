using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockInOrder Data Structure.
    /// </summary>
    public class StuffStockInOrder : AlipayObject
    {
        /// <summary>
        /// 口碑物料平台商品入库ERP号
        /// </summary>
        [JsonPropertyName("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// ERP订单类型
        /// </summary>
        [JsonPropertyName("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库单明细
        /// </summary>
        [JsonPropertyName("order_items")]
        public List<StuffStockInOrderItem> OrderItems { get; set; }

        /// <summary>
        /// 预计收货时间(YYYY-MM-DD HH:mm:ss)
        /// </summary>
        [JsonPropertyName("scheduled_receipt_date")]
        public string ScheduledReceiptDate { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
