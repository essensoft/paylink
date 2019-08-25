using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryItem : AlipayObject
    {
        /// <summary>
        /// SEND - 发货指令(执行向目的地进行发货动作) , RECEIVE - 收货指令(执行从来源地进行收货动作)
        /// </summary>
        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 配送数量
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 订单申请日期, 格式:  yyyy-MM-dd HH：mm:ss
        /// </summary>
        [JsonProperty("apply_order_date")]
        public string ApplyOrderDate { get; set; }

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
        /// 用于线下供应商区分业务流程，目前采用双方约定方
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 配送指令单据明细ID
        /// </summary>
        [JsonProperty("delivery_assign_order_item_id")]
        public string DeliveryAssignOrderItemId { get; set; }

        /// <summary>
        /// 送货单号
        /// </summary>
        [JsonProperty("delivery_process_no")]
        public string DeliveryProcessNo { get; set; }

        /// <summary>
        /// 调拨指令承运方pid
        /// </summary>
        [JsonProperty("delivery_process_supplier_id")]
        public string DeliveryProcessSupplierId { get; set; }

        /// <summary>
        /// 调拨承运方供应商名称
        /// </summary>
        [JsonProperty("delivery_process_supplier_name")]
        public string DeliveryProcessSupplierName { get; set; }

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
        /// 公司主体代码
        /// </summary>
        [JsonProperty("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 公司主体名
        /// </summary>
        [JsonProperty("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 外部业务单号，例如淘宝订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 1. 如果该物料是套组的子物料, 那么该值为套组物料id;  2, 其他情况和物料id(即, item_id)一致或者为空.
        /// </summary>
        [JsonProperty("parent_item_id")]
        public string ParentItemId { get; set; }

        /// <summary>
        /// 面单信息
        /// </summary>
        [JsonProperty("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 生产调拨对应的生产指令.
        /// </summary>
        [JsonProperty("produce_order_item_id")]
        public string ProduceOrderItemId { get; set; }

        /// <summary>
        /// TO_CUSTOMER : 到客户的配送指令; INTERIM : 中转配送指令. 可选值详见openApi文档.
        /// </summary>
        [JsonProperty("record_type")]
        public string RecordType { get; set; }

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
