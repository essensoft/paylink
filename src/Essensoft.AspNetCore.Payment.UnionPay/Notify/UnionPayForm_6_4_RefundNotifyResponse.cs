using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.UnionPay.Notify
{
    public class UnionPayForm_6_4_RefundNotifyResponse : UnionPayNotifyResponse
    {
        /// <summary>
        /// 查询流水号
        /// 消费交易的流水号，供后续查询用
        /// </summary>
        [XmlElement("queryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// 交易传输时间
        /// </summary>
        [XmlElement("traceTime")]
        public string TraceTime { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// 签名方法
        /// </summary>
        [XmlElement("signMethod")]
        public string SignMethod { get; set; }

        /// <summary>
        /// 清算币种
        /// 成功时出现
        /// </summary>
        [XmlElement("settleCurrencyCode")]
        public string SettleCurrencyCode { get; set; }

        /// <summary>
        /// 清算金额
        /// 成功时出现
        /// </summary>
        [XmlElement("settleAmt")]
        public string SettleAmt { get; set; }

        /// <summary>
        /// 清算日期
        /// 成功时出现
        /// </summary>
        [XmlElement("settleDate")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 系统跟踪号
        /// </summary>
        [XmlElement("traceNo")]
        public string TraceNo { get; set; }

        /// <summary>
        /// 应答码
        /// </summary>
        [XmlElement("respCode")]
        public string RespCode { get; set; }

        /// <summary>
        /// 应答信息
        /// </summary>
        [XmlElement("respMsg")]
        public string RespMsg { get; set; }

        /// <summary>
        /// 兑换日期
        /// 交易成功，交易币种和清算币种不一致的时候返回
        /// </summary>
        [XmlElement("exchangeDate")]
        public string ExchangeDate { get; set; }

        /// <summary>
        /// 签名公钥证书
        /// 使用RSA签名方式时必选，此域填写银联签名公钥证书。
        /// </summary>
        [XmlElement("signPubKeyCert")]
        public string SignPubKeyCert { get; set; }

        /// <summary>
        /// 清算汇率
        /// 交易成功，交易币种和清算币种不一致的时候返回
        /// </summary>
        [XmlElement("exchangeRate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 银行卡验证信息及身份信息
        /// </summary>
        [XmlElement("customerInfo")]
        public string CustomerInfo { get; set; }

        /// <summary>
        /// 账号
        /// 成功时出现
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }

        /// <summary>
        /// 支付方式
        /// 根据商户配置返回
        /// </summary>
        [XmlElement("payType")]
        public string PayType { get; set; }

        /// <summary>
        /// 支付卡类型
        /// 根据商户配置返回
        /// </summary>
        [XmlElement("payCardType")]
        public string PayCardType { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// 编码方式
        /// </summary>
        [XmlElement("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [XmlElement("bizType")]
        public string BizType { get; set; }

        /// <summary>
        /// 订单发送时间
        /// </summary>
        [XmlElement("txnTime")]
        public string TxnTime { get; set; }

        /// <summary>
        /// 交易币种
        /// 默认为156
        /// </summary>
        [XmlElement("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("txnAmt")]
        public string TxnAmt { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("txnType")]
        public string TxnType { get; set; }

        /// <summary>
        /// 交易子类
        /// </summary>
        [XmlElement("txnSubType")]
        public string TxnSubType { get; set; }

        /// <summary>
        /// 接入类型
        /// </summary>
        [XmlElement("accessType")]
        public string AccessType { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        [XmlElement("reqReserved")]
        public string ReqReserved { get; set; }

        /// <summary>
        /// 商户代码
        /// </summary>
        [XmlElement("merId")]
        public string MerId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 原交易查询流水号
        /// 原始消费交易的queryId
        /// </summary>
        [XmlElement("origQryId")]
        public string OrigQryId { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        [XmlElement("reserved")]
        public string Reserved { get; set; }
    }
}
