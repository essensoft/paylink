using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    public class LianLianPayWebQuickPayNotifyResponse : LianLianPayNotifyResponse
    {
        /// <summary>
        /// 商户编号
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
        /// 商户订单时间
        /// </summary>
        [JsonProperty("dt_order")]
        public string DtOrder { get; set; }

        /// <summary>
        /// 商户唯一订单号
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }

        /// <summary>
        /// 连连支付支付单号
        /// </summary>
        [JsonProperty("oid_paybill")]
        public string OidPaybill { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("money_order")]
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 支付结果
        /// </summary>
        [JsonProperty("result_pay")]
        public string ResultPay { get; set; }

        /// <summary>
        /// 清算日期
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
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 银行编号
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        [JsonProperty("no_agree")]
        public string NoAgree { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonProperty("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 银行账号姓名
        /// </summary>
        [JsonProperty("acct_name")]
        public string AcctName { get; set; }
    }
}
