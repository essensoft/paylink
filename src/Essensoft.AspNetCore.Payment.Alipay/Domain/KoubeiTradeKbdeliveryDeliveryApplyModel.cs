using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeKbdeliveryDeliveryApplyModel Data Structure.
    /// </summary>
    public class KoubeiTradeKbdeliveryDeliveryApplyModel : AlipayObject
    {
        /// <summary>
        /// 附加数据，在查询API和物流变更通知回执中原样返回，该字段主要用于第三方系统携带订单的自定义数据
        /// </summary>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 物流请求扩展信息，详细见模型字段说明；  在CUPBOARD：取餐柜模式 必填  在CUPBOARD（取餐柜模式 场景）；支持2种模式单元格分配规则（2选1）；  分配规则1：指定设备编号+指定单元格编号  分配规则2：指定申请单元格数量，自动分配  两者都传入，优先按分配规则1处理
        /// </summary>
        [JsonPropertyName("logistics_external_info")]
        public LogisticsExternalInfo LogisticsExternalInfo { get; set; }

        /// <summary>
        /// 物流类型，仅可填入可支持的物流类型，可支持的类型如下：  CUPBOARD：取餐柜模式  COMMON：骑手配送模式
        /// </summary>
        [JsonPropertyName("logistics_type")]
        public string LogisticsType { get; set; }

        /// <summary>
        /// 口碑交易订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求；
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
