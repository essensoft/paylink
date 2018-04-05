using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    public class LianLianPayOrderQueryResponse : LianLianPayResponse
    {
        /// <summary>
        /// 交易结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 交易结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// RSA加密签名，见安全签名机制 
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 支付结果
        /// SUCCESS 成功
        /// WAITING 等待支付
        /// PROCESSING 银行支付处理中
        /// REFUND 退款
        /// FAILURE 失败
        /// 支付结果以此为准，商户按此进行后续是否 发货操作
        /// </summary>
        [JsonProperty("result_pay")]
        public string ResultPay { get; set; }

        /// <summary>
        /// 商户编号
        /// 商户编号是商户在连连支付支付平台上开 设的商户号码，为18位数字，如： 201304121000001004
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 商户订单时间
        /// 格式：YYYYMMDDH24MISS  14 位数 字，精确到秒 
        /// </summary>
        [JsonProperty("dt_order")]
        public string DtOrder { get; set; }

        /// <summary>
        /// 商户唯一订单号
        /// 商户系统唯一订单号 
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }

        /// <summary>
        /// 连连支付支付单号
        /// 2011030900001098
        /// </summary>
        [JsonProperty("oid_paybill")]
        public string OidPaybill { get; set; }

        /// <summary>
        /// 交易金额
        /// 该笔订单的资金总额，单位为RMB-元。 大于0的数字，精确到小数点后两位。 如：49.65 
        /// </summary>
        [JsonProperty("money_order")]
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 清算日期
        /// YYYYMMDD 支付成功后会有 
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonProperty("info_order")]
        public string InfoOrder { get; set; }

        /// <summary>
        /// 支付方式
        /// 0：余额支付
        /// 1：网银支付（借记卡）
        /// 2：快捷支付（借记卡）
        /// 3：快捷支付（信用卡）
        /// 8：网银支付（信用卡）
        /// 9：B2B企业网银支付
        /// D：认证支付（借记卡）
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 银行编号
        /// 余额支付没有此项
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称
        /// query_version大于1.0 版本时返回 不参与签名
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 支付备注
        /// query_version大于1.0版本时返回 支付失败的原因，如果多次支付的话返回最 后一次的失败原因
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 银行卡号
        /// 不参与签名
        /// 显示前 6 后 4 隐藏其它
        /// 例: 622208*********0000
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
    }
}
