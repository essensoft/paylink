using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockInOrder Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockInOrder : AlipayObject
    {
        /// <summary>
        /// 口碑物料平台商品入库ERP号
        /// </summary>
        [JsonProperty("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// ERP订单类型
        /// </summary>
        [JsonProperty("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库单明细
        /// </summary>
        [JsonProperty("order_items")]
        public List<StuffStockInOrderItem> OrderItems { get; set; }

        /// <summary>
        /// 预计收货时间(YYYY-MM-DD HH:mm:ss)
        /// </summary>
        [JsonProperty("scheduled_receipt_date")]
        public string ScheduledReceiptDate { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
