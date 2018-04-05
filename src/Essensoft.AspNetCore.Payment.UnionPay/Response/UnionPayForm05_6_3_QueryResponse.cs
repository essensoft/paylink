using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.UnionPay.Response
{
    public class UnionPayForm05_6_3_QueryResponse : UnionPayResponse
    {
        /// <summary>
        /// 交易传输时间
        /// 统一返回
        /// </summary>
        [JsonProperty("traceTime")]
        public string TraceTime { get; set; }

        /// <summary>
        /// 交易类型
        /// 同被查询交易
        /// </summary>
        [JsonProperty("txnType")]
        public string TxnType { get; set; }

        /// <summary>
        /// 交易子类
        /// 同被查询交易
        /// </summary>
        [JsonProperty("txnSubType")]
        public string TxnSubType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// 签名方法
        /// </summary>
        [JsonProperty("signMethod")]
        public string SignMethod { get; set; }

        /// <summary>
        /// 清算币种
        /// 资金类交易统一返回
        /// </summary>
        [JsonProperty("settleCurrencyCode")]
        public string SettleCurrencyCode { get; set; }

        /// <summary>
        /// 清算金额
        /// 资金类交易统一返回
        /// </summary>
        [JsonProperty("settleAmt")]
        public string SettleAmt { get; set; }

        /// <summary>
        /// 清算日期
        /// 资金类交易统一返回
        /// </summary>
        [JsonProperty("settleDate")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 系统跟踪号
        /// 统一返回
        /// </summary>
        [JsonProperty("traceNo")]
        public string TraceNo { get; set; }

        /// <summary>
        /// 应答码
        /// </summary>
        [JsonProperty("respCode")]
        public string RespCode { get; set; }

        /// <summary>
        /// 应答信息
        /// </summary>
        [JsonProperty("respMsg")]
        public string RespMsg { get; set; }

        /// <summary>
        /// 查询流水号
        /// 被查询交易查询流水号
        /// </summary>
        [JsonProperty("queryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// 订单发送时间
        /// 被查询交易的交易时间
        /// </summary>
        [JsonProperty("txnTime")]
        public string TxnTime { get; set; }

        /// <summary>
        /// 兑换日期
        /// 交易成功，交易币种和清算币种不一致的时候返回
        /// </summary>
        [JsonProperty("exchangeDate")]
        public string ExchangeDate { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// 根据配置返回
        /// </summary>
        [JsonProperty("issInsNo")]
        public string IssInsNo { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("txnAmt")]
        public string TxnAmt { get; set; }

        /// <summary>
        /// 接入机构代码
        /// 接入机构接入时返回
        /// </summary>
        [JsonProperty("accInsCode")]
        public string AccInsCode { get; set; }

        /// <summary>
        /// 签名公钥证书
        /// 使用RSA签名方式时必选，此域填写银联签名公钥证书。
        /// </summary>
        [JsonProperty("signPubKeyCert")]
        public string SignPubKeyCert { get; set; }

        /// <summary>
        /// 清算汇率
        /// 交易成功，交易币种和清算币种不一致的时候返回
        /// </summary>
        [JsonProperty("exchangeRate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 商户订单号
        /// 被查询交易的订单号
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 原交易商户订单号
        /// 查询交易为退货或者消费撤销时返回，表示原消费交易的商户订单号
        /// </summary>
        [JsonProperty("origOrderId")]
        public string OrigOrderId { get; set; }

        /// <summary>
        /// 原交易商户发送交易时间
        /// 查询交易为退货或者消费撤销时返回，表示原消费交易的商户发送交易时间
        /// </summary>
        [JsonProperty("origTxnTime")]
        public string OrigTxnTime { get; set; }

        /// <summary>
        /// 原交易应答码
        /// 查询交易成功时返回
        /// </summary>
        [JsonProperty("origRespCode")]
        public string OrigRespCode { get; set; }

        /// <summary>
        /// 原交易应答信息
        /// </summary>
        [JsonProperty("origRespMsg")]
        public string OrigRespMsg { get; set; }

        /// <summary>
        /// 账号
        /// 根据商户配置返回
        /// </summary>
        [JsonProperty("accNo")]
        public string AccNo { get; set; }

        /// <summary>
        /// 支付方式
        /// 根据商户配置返回
        /// </summary>
        [JsonProperty("payType")]
        public string PayType { get; set; }

        /// <summary>
        /// 支付卡类型
        /// 根据商户配置返回
        /// </summary>
        [JsonProperty("payCardType")]
        public string PayCardType { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 编码方式
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [JsonProperty("bizType")]
        public string BizType { get; set; }

        /// <summary>
        /// 接入类型
        /// </summary>
        [JsonProperty("accessType")]
        public string AccessType { get; set; }

        /// <summary>
        /// 商户代码
        /// </summary>
        [JsonProperty("merId")]
        public string MerId { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        [JsonProperty("reserved")]
        public string Reserved { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        [JsonProperty("reqReserved")]
        public string ReqReserved { get; set; }
    }
}
