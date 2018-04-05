using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayGetTransferInfoResponse : WeChatPayResponse
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
        /// 商户单号
        /// </summary>
        [JsonProperty("partner_trade_no")]
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 付款单号
        /// </summary>
        [JsonProperty("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 转账状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 收款用户姓名
        /// </summary>
        [JsonProperty("transfer_name")]
        public string TransferName { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [JsonProperty("payment_amount")]
        public int PaymentAmount { get; set; }

        /// <summary>
        /// 转账时间
        /// </summary>
        [JsonProperty("transfer_time")]
        public string TransferTime { get; set; }

        /// <summary>
        /// 付款描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }
    }
}
