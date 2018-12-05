using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    /// <summary>
    /// 退款类异步通知
    /// </summary>
    public class LianLianPayRefundNotify : LianLianPayNotify
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
        /// 商户退款流水号。
        /// </summary>
        [JsonProperty("no_refund")]
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        [JsonProperty("dt_refund")]
        public string DtRefund { get; set; }

        /// <summary>
        /// 原退款请求中money_refund对应的订单总金额，单位为元，精确到小数点后两位，小数点计入字符长度。
        /// 取值范围为 0.01 ~ 99999999。
        /// </summary>
        [JsonProperty("money_refund")]
        public string MoneyRefund { get; set; }

        /// <summary>
        /// 连连退款流水号。
        /// 全局唯一。
        /// 如： 2017030400001010。
        /// </summary>
        [JsonProperty("oid_refundno")]
        public string OidRefundNo { get; set; }

        /// <summary>
        /// 退款单状态。
        /// 2 - 退款成功。
        /// 3 - 退款失败。
        /// </summary>
        [JsonProperty("sta_refund")]
        public string StaRefund { get; set; }

        /// <summary>
        /// 清算日期。
        /// 格式：YYYYMMDD。
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }
    }
}
