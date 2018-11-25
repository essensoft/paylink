using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    /// <summary>
    /// 收款类同步通知
    /// </summary>
    public class LianLianPayReceiveMoneyReturnResponse : LianLianPayNotifyResponse
    {
        /// <summary>
        /// 交易结果代码。
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 交易结果描述。
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

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
        /// 商户订单时间。
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
        /// 清算日期。
        /// 格式：YYYYMMDD。
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
        /// 支付交易的成功付款方式。
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
    }
}
