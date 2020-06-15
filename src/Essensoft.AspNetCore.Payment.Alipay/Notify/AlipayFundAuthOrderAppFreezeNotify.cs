using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 线上资金授权冻结
    /// 更新时间：2019-12-05
    /// https://docs.open.alipay.com/20180417160701241302/vo4kv7/
    /// 参考其他通知额外补充了 公共参数
    /// </summary>
    public class AlipayFundAuthOrderAppFreezeNotify : AlipayNotify
    {
        // 公共参数

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonPropertyName("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonPropertyName("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 授权方的app_id
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        // 业务参数

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        [JsonPropertyName("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 商户的资金授权订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝的资金操作流水号
        /// </summary>
        [JsonPropertyName("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户资金操作流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 资金操作类型，支持【FREEZE，UNFREEZE，PAY】
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 本次操作冻结的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金预授权明细的状态目前支持：  INIT：初始SUCCESS: 成功CLOSED：关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 操作处理完成时间
        /// </summary>
        [JsonPropertyName("gmt_trans")]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 付款方支付宝账号登录号
        /// </summary>
        [JsonPropertyName("payer_logon_id")]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 付款方支付宝账号UID
        /// </summary>
        [JsonPropertyName("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 收款方支付宝账号登陆号
        /// </summary>
        [JsonPropertyName("payee_logon_id")]
        public string PayeeLogonId { get; set; }

        /// <summary>
        /// 收款方支付宝账号UID
        /// </summary>
        [JsonPropertyName("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 累计冻结金额
        /// </summary>
        [JsonPropertyName("total_freeze_amount")]
        public string TotalFreezeAmount { get; set; }

        /// <summary>
        /// 累计解冻金额
        /// </summary>
        [JsonPropertyName("total_unfreeze_amount")]
        public string TotalUnfreezeAmount { get; set; }

        /// <summary>
        /// 剩余冻结金额
        /// </summary>
        [JsonPropertyName("rest_amount")]
        public string RestAmount { get; set; }

        /// <summary>
        /// 本次操作中信用金额，单位为：元（人民币），精确到小数点后两位（信用授权场景返回）
        /// </summary>
        [JsonPropertyName("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 本次操作中自有资金金额，单位为：元（人民币），精确到小数点后两位（信用授权场景返回）
        /// </summary>
        [JsonPropertyName("fund_amount")]
        public string FundAmount { get; set; }

        /// <summary>
        /// 累计冻结信用金额，单位为：元（人民币），精确到小数点后两位（信用授权场景返回）
        /// </summary>
        [JsonPropertyName("total_freeze_credit_amount")]
        public string TotalFreezeCreditAmount { get; set; }

        /// <summary>
        /// 累计冻结自有资金金额，单位为：元（人民币），精确到小数点后两位 （信用授权场景返回）
        /// </summary>
        [JsonPropertyName("total_freeze_fund_amount")]
        public string TotalFreezeFundAmount { get; set; }

        /// <summary>
        /// 累计解冻信用金额，单位为：元（人民币），精确到小数点后两位（信用授权场景返回）
        /// </summary>
        [JsonPropertyName("total_unfreeze_credit_amount")]
        public string TotalUnfreezeCreditAmount { get; set; }

        /// <summary>
        /// 累计解冻自有资金金额，单位为：元（人民币），精确到小数点后两位 （信用授权场景返回）
        /// </summary>
        [JsonPropertyName("total_unfreeze_fund_amount")]
        public string TotalUnfreezeFundAmount { get; set; }

        /// <summary>
        /// 累计支付信用金额，单位为：元（人民币），精确到小数点后两位 （信用授权场景返回）
        /// </summary>
        [JsonPropertyName("total_pay_credit_amount")]
        public string TotalPayCreditAmount { get; set; }

        /// <summary>
        /// 累计支付自有资金金额，单位为：元（人民币），精确到小数点后两位 （信用授权场景返回）
        /// </summary>
        [JsonPropertyName("total_pay_fund_amount")]
        public string TotalPayFundAmount { get; set; }

        /// <summary>
        /// 剩余冻结信用金额，单位为：元（人民币），精确到小数点后两位 （信用授权场景返回）
        /// </summary>
        [JsonPropertyName("rest_credit_amount")]
        public string RestCreditAmount { get; set; }

        /// <summary>
        /// 剩余冻结自有资金金额，单位为：元（人民币），精确到小数点后两位（信用授权场景返回）
        /// </summary>
        [JsonPropertyName("rest_fund_amount")]
        public string RestFundAmount { get; set; }

        /// <summary>
        /// 预授权类型，目前支持 CREDIT_AUTH(信用预授权);商户可根据该标识来判断该笔预授权的类型，当返回值为"CREDIT_AUTH"表明该笔预授权为信用预授权，没有真实冻结资金；如果未返回，则表示普通资金预授权，会冻结用户资金。
        /// </summary>
        [JsonPropertyName("pre_auth_type")]
        public string PreAuthType { get; set; }
    }
}
