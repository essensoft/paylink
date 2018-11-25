using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    /// <summary>
    /// 收款结果查询
    /// </summary>
    public class LianLianPayOrderQueryResponse : LianLianPayResponse
    {
        /// <summary>
        /// 请求结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 请求结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 原请求中商户订单号。
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }

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
        /// 商户编号是商户在连连支付支付平台上开设的商户号码，为18位数字，如：201304121000001004。
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 连连支付单号。
        /// 全局唯一。
        /// 如： 2011030900001098。
        /// </summary>
        [JsonProperty("oid_paybill")]
        public string OidPaybill { get; set; }

        /// <summary>
        /// 商户订单时间。
        /// 格式为 YYMMDDHHMMSS，HH以24小时为准，如 20180130161010。
        /// </summary>
        [JsonProperty("dt_order")]
        public string DtOrder { get; set; }

        /// <summary>
        /// 原请求中交易金额。
        /// </summary>
        [JsonProperty("money_order")]
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 支付结果以此为准，商户依此字段进行后续是否发货的操作，详情可参考收款类订单状态说明。
        /// SUCCESS，成功。
        /// PROCESSING，支付处理中，当ret_code的值为2008时，会返回此处理状态。
        /// 需要您调用收款结果查询API进行查询。
        /// </summary>
        [JsonProperty("result_pay")]
        public string ResultPay { get; set; }

        /// <summary>
        /// 清算日期。
        /// 格式：YYYYMMDD。
        /// </summary>
        [JsonProperty("settle_date")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 订单描述。
        /// 如原始请求中没有info_order，则返回空值。
        /// </summary>
        [JsonProperty("info_order")]
        public string InfoOrder { get; set; }

        /// <summary>
        /// 支付方式。该订单对应的支付方式。
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
        /// 银行编号。
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称。
        /// query_version为1.1时返回
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 用户银行卡卡号。
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 支付备注，支付失败的原因。
        /// 如果多次支付失败，返回最后一次失败原因。
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }
    }
}
