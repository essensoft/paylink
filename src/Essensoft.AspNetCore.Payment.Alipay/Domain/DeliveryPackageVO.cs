using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeliveryPackageVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPackageVO : AlipayObject
    {
        /// <summary>
        /// 通知单id
        /// </summary>
        [JsonProperty("delivery_order_code")]
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 菜鸟单号
        /// </summary>
        [JsonProperty("delivery_order_id")]
        public string DeliveryOrderId { get; set; }

        /// <summary>
        /// 包裹明细
        /// </summary>
        [JsonProperty("delivery_package_detail_list")]
        public List<DeliveryPackageDetail> DeliveryPackageDetailList { get; set; }

        /// <summary>
        /// 货运单号
        /// </summary>
        [JsonProperty("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [JsonProperty("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 包裹编码
        /// </summary>
        [JsonProperty("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonProperty("work_order_id")]
        public string WorkOrderId { get; set; }
    }
}
