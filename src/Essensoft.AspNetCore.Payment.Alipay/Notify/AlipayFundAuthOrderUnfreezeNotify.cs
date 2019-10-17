using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 资金授权解冻
    /// 更新时间：2019-08-28
    /// https://docs.open.alipay.com/20180417160701241302/vy70oy/
    /// 参考其他通知额外补充了 公共参数
    /// </summary>
    public class AlipayFundAuthOrderUnfreezeNotify : AlipayNotify
    {
        // 公共参数

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonProperty("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonProperty("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        [JsonProperty("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 授权方的app_id
        /// </summary>
        [JsonProperty("auth_app_id")]
        public string AuthAppId { get; set; }

        // 业务参数

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        [JsonProperty("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 商户的资金授权订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝的资金操作流水号
        /// </summary>
        [JsonProperty("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户资金操作流水号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 资金操作类型，支持【FREEZE，UNFREEZE，PAY】
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 本次操作冻结的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金预授权明细的状态目前支持：  INIT：初始SUCCESS: 成功CLOSED：关闭
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 操作处理完成时间
        /// </summary>
        [JsonProperty("gmt_trans")]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 付款方支付宝账号登录号
        /// </summary>
        [JsonProperty("payer_logon_id")]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 收款方支付宝账号登陆号
        /// </summary>
        [JsonProperty("payee_logon_id")]
        public string PayeeLogonId { get; set; }

        /// <summary>
        /// 累计冻结金额
        /// </summary>
        [JsonProperty("total_freeze_amount")]
        public string TotalFreezeAmount { get; set; }

        /// <summary>
        /// 累计解冻金额
        /// </summary>
        [JsonProperty("total_unfreeze_amount")]
        public string TotalUnfreezeAmount { get; set; }

        /// <summary>
        /// 累计支付金额
        /// </summary>
        [JsonProperty("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 剩余冻结金额
        /// </summary>
        [JsonProperty("rest_amount")]
        public string RestAmount { get; set; }
    }
}
