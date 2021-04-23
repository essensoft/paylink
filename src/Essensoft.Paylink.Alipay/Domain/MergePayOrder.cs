using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MergePayOrder Data Structure.
    /// </summary>
    public class MergePayOrder : AlipayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 资金单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [JsonPropertyName("payee_display_account")]
        public string PayeeDisplayAccount { get; set; }

        /// <summary>
        /// 收款方姓名
        /// </summary>
        [JsonPropertyName("payee_display_name")]
        public string PayeeDisplayName { get; set; }

        /// <summary>
        /// 收款方机构号
        /// </summary>
        [JsonPropertyName("payee_inst_id")]
        public string PayeeInstId { get; set; }

        /// <summary>
        /// 收款方机构名
        /// </summary>
        [JsonPropertyName("payee_inst_name")]
        public string PayeeInstName { get; set; }

        /// <summary>
        /// 收款方头像
        /// </summary>
        [JsonPropertyName("payee_portrait_id")]
        public string PayeePortraitId { get; set; }

        /// <summary>
        /// 收款方类型
        /// </summary>
        [JsonPropertyName("payee_type")]
        public string PayeeType { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 资金单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 到账时间
        /// </summary>
        [JsonPropertyName("withdraw_delay")]
        public string WithdrawDelay { get; set; }
    }
}
