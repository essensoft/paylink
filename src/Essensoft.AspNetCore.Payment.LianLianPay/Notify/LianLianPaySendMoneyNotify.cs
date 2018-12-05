using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    /// <summary>
    /// 付款类异步通知
    /// </summary>
    public class LianLianPaySendMoneyNotify : LianLianPayNotify
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
        /// 原收款类支付请求传入的dt_order。格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        [JsonProperty("dt_order")]
        public string DtOrder { get; set; }

        /// <summary>
        /// 原交易请求中传入的商户订单号
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }

        /// <summary>
        /// 该笔连连支付单的交易总金额。
        /// </summary>
        [JsonProperty("money_order")]
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 连连收款单号。
        /// 全局唯一。
        /// 如： 2011030900001098。
        /// </summary>
        [JsonProperty("oid_paybill")]
        public string OidPaybill { get; set; }

        /// <summary>
        /// 订单扩展字段。
        /// 原收款类或者付款类请求中的InfoOrder。
        /// </summary>
        [JsonProperty("info_order")]
        public string InfoOrder { get; set; }

        /// <summary>
        /// 付款结果，结果以此字段为准。
        /// SUCCESS，成功。
        /// CANCEL，付款退款，付款成功后，有可能发生退款。
        /// FAILURE，失败。
        /// </summary>
        [JsonProperty("result_pay")]
        public string ResultPay { get; set; }

        /// <summary>
        /// 清算日期，格式YYYYMMDD。
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }
    }
}
