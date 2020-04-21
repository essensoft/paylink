using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffStockoutorderstatusSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffStockoutorderstatusSyncModel : AlipayObject
    {
        /// <summary>
        /// erp订单号
        /// </summary>
        [JsonPropertyName("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// ERP 订单类型
        /// </summary>
        [JsonPropertyName("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("steps")]
        public List<StockShippingStepInfo> Steps { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("way_bill_no")]
        public string WayBillNo { get; set; }
    }
}
