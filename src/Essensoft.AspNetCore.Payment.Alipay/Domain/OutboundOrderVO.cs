using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OutboundOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class OutboundOrderVO : AlipayObject
    {
        /// <summary>
        /// 取消原因  ORDER_CANCEL("订单取消"),  INVENTORY_OCCUPY_FAIL("库存占用失败")
        /// </summary>
        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 通知日期
        /// </summary>
        [JsonProperty("notice_date")]
        public string NoticeDate { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作者类型，PROVIDER:服务商,PROVIDER_STAFF:服务商员工,MER:商户,MER_STAFF:商户员工,SALES:阿里销售小二,SYSTEM:系统
        /// </summary>
        [JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 出库通知单id
        /// </summary>
        [JsonProperty("outbound_order_id")]
        public string OutboundOrderId { get; set; }

        /// <summary>
        /// CGCK("采购出库"),  DDCK("订单出库"),  PDCK("盘点出库"),;
        /// </summary>
        [JsonProperty("outbound_type")]
        public string OutboundType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态  INIT,  PROCESSING,  FINISHED,  CANCELLED;
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
