using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayQueryBankResponse : WeChatPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// 此字段是通信标识，非交易标识，
        /// 交易是否成功需要查看result_code来判断
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息，如非空，为错误原因
        /// 签名失败
        /// 参数格式校验错误
        /// </summary>
        [JsonProperty("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonProperty("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述	
        /// </summary>
        [JsonProperty("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        [JsonProperty("partner_trade_no")]
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 微信企业付款单号
        /// </summary>
        [JsonProperty("payment_no")]
        public string PaymentNo { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("bank_no_md5")]
        public string BankNoMd5 { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [JsonProperty("true_name_md5")]
        public string TrueNameMd5 { get; set; }

        /// <summary>
        /// 代付金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 代付单状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 手续费金额
        /// </summary>
        [JsonProperty("cmms_amt")]
        public string CmmsAmt { get; set; }

        /// <summary>
        /// 商户下单时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 成功付款时间
        /// </summary>
        [JsonProperty("pay_succ_time")]
        public string PaySuccTime { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
