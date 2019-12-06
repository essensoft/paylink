using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffLogisticsoutstockSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffLogisticsoutstockSyncModel : AlipayObject
    {
        /// <summary>
        /// 实际发货时间
        /// </summary>
        [JsonPropertyName("actual_ship_date_time")]
        public string ActualShipDateTime { get; set; }

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
        /// 顺丰为SF
        /// </summary>
        [JsonPropertyName("express_company_code")]
        public string ExpressCompanyCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonPropertyName("express_company_name")]
        public string ExpressCompanyName { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 出库明细
        /// </summary>
        [JsonPropertyName("item_infos")]
        public List<OutStockStuffInfo> ItemInfos { get; set; }

        /// <summary>
        /// 由调用方提供的一个唯一的请求ID，每一个请求对应一个id，用于实现调用幂等
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 回单号
        /// </summary>
        [JsonPropertyName("return_tracking")]
        public string ReturnTracking { get; set; }

        /// <summary>
        /// 顺丰的出库号
        /// </summary>
        [JsonPropertyName("shipment_id")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("way_bill_no")]
        public string WayBillNo { get; set; }
    }
}
