using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundAuthOperationDetailQueryResponse.
    /// </summary>
    public class AlipayFundAuthOperationDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 该笔资金操作流水opertion_id对应的操作金额，单位为：元（人民币）
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        [JsonPropertyName("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 该笔资金操作流水opertion_id对应的操作信用金额
        /// </summary>
        [JsonPropertyName("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 商户请求创建预授权订单时传入的扩展参数，仅返回商户自定义的扩展信息（merchantExt）
        /// </summary>
        [JsonPropertyName("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 该笔资金操作流水opertion_id对应的操作自有资金金额
        /// </summary>
        [JsonPropertyName("fund_amount")]
        public string FundAmount { get; set; }

        /// <summary>
        /// 资金授权单据操作流水创建时间，  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 支付宝账务处理成功时间，  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonPropertyName("gmt_trans")]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 支付宝资金操作流水号
        /// </summary>
        [JsonPropertyName("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 支付宝资金操作类型，  目前支持：   FREEZE：冻结  UNFREEZE：解冻  PAY：支付
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 业务订单的简单描述，如商品名称等
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户的授权资金订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户资金操作的请求流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 付款方支付宝账号（Email或手机号），仅作展示使用，默认会加“*”号处理
        /// </summary>
        [JsonPropertyName("payer_logon_id")]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 付款方支付宝账号对应的支付宝唯一用户号，以2088开头的16位纯数字组成
        /// </summary>
        [JsonPropertyName("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 预授权类型，目前支持 CREDIT_AUTH(信用预授权);  商户可根据该标识来判断该笔预授权的类型，当返回值为"CREDIT_AUTH"表明该笔预授权为信用预授权，没有真实冻结资金；当返回值为空或者不为"CREDIT_AUTH"则表明该笔预授权为普通资金预授权，会冻结用户资金。
        /// </summary>
        [JsonPropertyName("pre_auth_type")]
        public string PreAuthType { get; set; }

        /// <summary>
        /// 商户对本次操作的附言描述，长度不超过100个字母或50个汉字
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单总共剩余的冻结金额，单位为：元（人民币）
        /// </summary>
        [JsonPropertyName("rest_amount")]
        public string RestAmount { get; set; }

        /// <summary>
        /// 剩余冻结信用金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("rest_credit_amount")]
        public string RestCreditAmount { get; set; }

        /// <summary>
        /// 剩余冻结自有资金金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("rest_fund_amount")]
        public string RestFundAmount { get; set; }

        /// <summary>
        /// 资金操作流水的状态，  目前支持：   INIT：初始  SUCCESS：成功  CLOSED：关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单累计的冻结金额，单位为：元（人民币）
        /// </summary>
        [JsonPropertyName("total_freeze_amount")]
        public string TotalFreezeAmount { get; set; }

        /// <summary>
        /// 累计冻结信用金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("total_freeze_credit_amount")]
        public string TotalFreezeCreditAmount { get; set; }

        /// <summary>
        /// 累计冻结自有资金金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("total_freeze_fund_amount")]
        public string TotalFreezeFundAmount { get; set; }

        /// <summary>
        /// 订单累计用于支付的金额，单位为：元（人民币）
        /// </summary>
        [JsonPropertyName("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 累计支付信用金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("total_pay_credit_amount")]
        public string TotalPayCreditAmount { get; set; }

        /// <summary>
        /// 累计支付自有资金金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("total_pay_fund_amount")]
        public string TotalPayFundAmount { get; set; }

        /// <summary>
        /// 标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        [JsonPropertyName("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
