using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    public class JDPayAccountQueryResponse : JDPayResponse
    {
        /// <summary>
        /// 提交者会员号
        /// </summary>
        [JsonProperty("customer_no")]
        public string CustomerNo { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [JsonProperty("response_datetime")]
        public string ResponseDatetime { get; set; }

        /// <summary>
        /// 响应编码
        /// </summary>
        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 响应描述
        /// </summary>
        [JsonProperty("response_message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名数据
        /// </summary>
        [JsonProperty("sign_data")]
        public string SignData { get; set; }

        /// <summary>
        /// 会员信息
        /// </summary>
        [JsonProperty("buyer_info")]
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 账户总金额
        /// </summary>
        [JsonProperty("account_amount")]
        public string AccountAmount { get; set; }

        /// <summary>
        /// 冻结总余额
        /// </summary>
        [JsonProperty("frozen_amount")]
        public string FrozenAmount { get; set; }

        /// <summary>
        /// 账户余额币种
        /// </summary>
        [JsonProperty("account_currency")]
        public string AccountCurrency { get; set; }

        /// <summary>
        /// 商户请求流水号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
