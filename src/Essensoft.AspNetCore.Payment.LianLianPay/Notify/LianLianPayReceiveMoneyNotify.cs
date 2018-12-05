using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    /// <summary>
    /// 收款类异步通知
    /// </summary>
    public class LianLianPayReceiveMoneyNotify : LianLianPayNotify
    {
        /// <summary>
        /// 商户编号是商户在连连支付支付平台上开设的商户号码，为18位数字，如：201304121000001004。
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
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 原收款类支付请求传入的DtOrder。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        [JsonProperty("dt_order")]
        public string DtOrder { get; set; }

        /// <summary>
        /// 原交易请求中传入的商户订单号NoOrder。
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }

        /// <summary>
        /// 连连收款单号。
        /// 全局唯一。
        /// 如： 2011030900001098。
        /// </summary>
        [JsonProperty("oid_paybill")]
        public string OidPaybill { get; set; }

        /// <summary>
        /// 交易金额。
        /// 请求no_order对应的订单总金额，单位为元，精确到小数点后两位，小数点计入字符长度。
        /// 取值范围为 0.01 ~ 99999999。
        /// </summary>
        [JsonProperty("money_order")]
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 支付结果以此为准，商户依此字段进行后续是否发货的操作。
        /// SUCCESS，成功。
        /// </summary>
        [JsonProperty("result_pay")]
        public string ResultPay { get; set; }

        /// <summary>
        /// 清算日期，
        /// 格式YYYYMMDD。
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 订单扩展字段。
        /// 原收款类或者付款类请求中的InfoOrder。
        /// </summary>
        [JsonProperty("info_order")]
        public string InfoOrder { get; set; }

        /// <summary>
        /// 支付方式。
        /// 指定使用的支付方式。
        /// 0，余额支付。
        /// 1，网银支付 - 借记卡。
        /// 2，快捷支付 - 借记卡。
        /// 3，快捷支付 - 信用卡。
        /// 8，网银支付 - 信用卡。
        /// 9，网银支付 - B2B企业网银。
        /// D，认证支付。      
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 银行编码。
        /// 消费者所用银行的银行编码。
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 签约协议编号，消费者使用银行卡支付后会生成。
        /// 签约规则及详情见签约说明。
        /// </summary>
        [JsonProperty("no_agree")]
        public string NoAgree { get; set; }

        /// <summary>
        /// 消费者在支付请求中使用的身份证件类型。
        /// </summary>
        [JsonProperty("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 消费者在原支付请求中使用的证件号码。
        /// </summary>
        [JsonProperty("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 消费者在支付请求中使用的真实姓名。
        /// </summary>
        [JsonProperty("acct_name")]
        public string AcctName { get; set; }

        /// <summary>
        /// 消费者在原支付请求中使用的卡号，卡号除前6后4以外的其他位数均为掩码形式，如621463******1234。
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
    }
}
