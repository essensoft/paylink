using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    /// <summary>
    /// 账户余额查询
    /// </summary>
    public class LianLianPayTraderAcctQueryResponse : LianLianPayResponse
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
        /// 商户未结算金额。
        /// 该金额可用于退款，结转。
        /// 不建议开通商户站充值业务的商户使用账户余额查询接口查询未结算金额，并将其作为退款依据。
        /// </summary>
        [JsonProperty("amt_unsettle")]
        public string AmtUnsettle { get; set; }

        /// <summary>
        /// 商户可用余额。
        /// 该金额可用于商户提现或付款。
        /// </summary>
        [JsonProperty("amt_balance")]
        public string AmtBalance { get; set; }
    }
}
