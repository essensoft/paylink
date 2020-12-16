using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryItem Data Structure.
    /// </summary>
    public class AssetDeliveryItem : AlipayObject
    {
        /// <summary>
        /// SEND - 发货指令(执行向目的地进行发货动作) , RECEIVE - 收货指令(执行从来源地进行收货动作)
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 配送数量
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 订单申请日期, 格式:  yyyy-MM-dd HH：mm:ss
        /// </summary>
        [JsonPropertyName("apply_order_date")]
        public string ApplyOrderDate { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 配送订单唯一Id
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 支付宝内部的配送流水号, 可供物料商和物流商用于对账.
        /// </summary>
        [JsonPropertyName("assign_out_order_id")]
        public string AssignOutOrderId { get; set; }

        /// <summary>
        /// 物料渠道标识
        /// </summary>
        [JsonPropertyName("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 用于线下供应商区分业务流程，目前采用双方约定方
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 提供给物流商清关所用信息
        /// </summary>
        [JsonPropertyName("custom_clearance")]
        public CCInfo CustomClearance { get; set; }

        /// <summary>
        /// 配送指令单据明细ID
        /// </summary>
        [JsonPropertyName("delivery_assign_order_item_id")]
        public string DeliveryAssignOrderItemId { get; set; }

        /// <summary>
        /// 送货单号
        /// </summary>
        [JsonPropertyName("delivery_process_no")]
        public string DeliveryProcessNo { get; set; }

        /// <summary>
        /// 调拨指令承运方pid
        /// </summary>
        [JsonPropertyName("delivery_process_supplier_id")]
        public string DeliveryProcessSupplierId { get; set; }

        /// <summary>
        /// 调拨承运方供应商名称
        /// </summary>
        [JsonPropertyName("delivery_process_supplier_name")]
        public string DeliveryProcessSupplierName { get; set; }

        /// <summary>
        /// 发送地址
        /// </summary>
        [JsonPropertyName("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 配送指令生成日期, 格式:yyyy-MM-dd HH：mm:ss
        /// </summary>
        [JsonPropertyName("gmt_assign")]
        public string GmtAssign { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [JsonPropertyName("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否走产包一体, IS_PRODUCE_ASSEBLE, 如果是Y，则是
        /// </summary>
        [JsonPropertyName("operate_info")]
        public string OperateInfo { get; set; }

        /// <summary>
        /// 公司主体代码
        /// </summary>
        [JsonPropertyName("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 公司主体名
        /// </summary>
        [JsonPropertyName("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 外部业务单号，例如淘宝订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 1. 如果该物料是套组的子物料, 那么该值为套组物料id;  2, 其他情况和物料id(即, item_id)一致或者为空.
        /// </summary>
        [JsonPropertyName("parent_item_id")]
        public string ParentItemId { get; set; }

        /// <summary>
        /// 面单信息
        /// </summary>
        [JsonPropertyName("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 生产调拨对应的生产指令.
        /// </summary>
        [JsonPropertyName("produce_order_item_id")]
        public string ProduceOrderItemId { get; set; }

        /// <summary>
        /// TO_CUSTOMER : 到客户的配送指令; INTERIM : 中转配送指令. 可选值详见openApi文档.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// 对应供应商pid
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 对应供应商名称
        /// </summary>
        [JsonPropertyName("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 接收地址(目的地址)
        /// </summary>
        [JsonPropertyName("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }
    }
}
