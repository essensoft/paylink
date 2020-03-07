using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeliveryPackageVO Data Structure.
    /// </summary>
    public class DeliveryPackageVO : AlipayObject
    {
        /// <summary>
        /// 通知单id
        /// </summary>
        [JsonPropertyName("delivery_order_code")]
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 菜鸟单号
        /// </summary>
        [JsonPropertyName("delivery_order_id")]
        public string DeliveryOrderId { get; set; }

        /// <summary>
        /// 包裹明细
        /// </summary>
        [JsonPropertyName("delivery_package_detail_list")]
        public List<DeliveryPackageDetail> DeliveryPackageDetailList { get; set; }

        /// <summary>
        /// 货运单号
        /// </summary>
        [JsonPropertyName("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 包裹编码
        /// </summary>
        [JsonPropertyName("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonPropertyName("work_order_id")]
        public string WorkOrderId { get; set; }
    }
}
