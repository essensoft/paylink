using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiTask Data Structure.
    /// </summary>
    public class BPOpenApiTask : AlipayObject
    {
        /// <summary>
        /// 处理地址
        /// </summary>
        [JsonPropertyName("deal_url")]
        public string DealUrl { get; set; }

        /// <summary>
        /// 详情展示地址
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 审批节点中文显示名称
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonPropertyName("gmt_operate")]
        public string GmtOperate { get; set; }

        /// <summary>
        /// 处理备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 审批节点code
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 点击的操作按钮
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 可点击的操作
        /// </summary>
        [JsonPropertyName("operate_transition")]
        public string OperateTransition { get; set; }

        /// <summary>
        /// 处理人域账号
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 处理人花名
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 加签类型
        /// </summary>
        [JsonPropertyName("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 状态:CREATED,TAKEN,TEMP_SAVE,COMPLETED,CANCELED
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 节点类型：UserTask，SystemTask
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
