using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    public class LianLianPayAuthPayReturnResponse : LianLianPayNotifyResponse
    {
        /// <summary>
        /// 商户编号
        /// 商户编号是商户在连连支付支付平台上开 设的商户号码，为18位数字，如： 201304121000001004 
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// RSA加密签名，见安全签名机制 订单信息 
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

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
        /// 支付结果
        /// 支付结果以此为准，商户按此进行后续是否 发货操作 
        /// </summary>
        [JsonProperty("result_pay")]
        public string ResultPay { get; set; }

        /// <summary>
        /// 清算日期
        /// 支付成功后会有
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
        /// 1：网银支付（借记卡） 8：网银支付（信用卡） 9：B2B企业网银支付
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 银行编号
        /// 列表见附录，余额支付没有此项
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }
    }
}
