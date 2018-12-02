using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.UnionPay.Response
{
    /// <summary>
    /// 无跳转支付(V2.2) 银联加密公钥更新查询接口
    /// </summary>
    public class UnionPayNoRedirectPayEncryptCertUpdateQueryResponse : UnionPayResponse
    {
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
        /// 加密公钥证书
        /// </summary>
        [JsonProperty("encryptPubKeyCert")]
        public string EncryptPubKeyCert { get; set; }

        /// <summary>
        /// 收单机构代码
        /// </summary>
        [JsonProperty("acqInsCode")]
        public string AcqInsCode { get; set; }

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
        /// 订单发送时间
        /// </summary>
        [JsonProperty("txnTime")]
        public string TxnTime { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("txnType")]
        public string TxnType { get; set; }

        /// <summary>
        /// 交易子类
        /// </summary>
        [JsonProperty("txnSubType")]
        public string TxnSubType { get; set; }

        /// <summary>
        /// 接入类型
        /// </summary>
        [JsonProperty("accessType")]
        public string AccessType { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        [JsonProperty("reqReserved")]
        public string ReqReserved { get; set; }

        /// <summary>
        /// 商户代码
        /// </summary>
        [JsonProperty("merId")]
        public string MerId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [JsonProperty("certType")]
        public string CertType { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        [JsonProperty("reserved")]
        public string Reserved { get; set; }

        /// <summary>
        /// 签名公钥证书
        /// </summary>
        [JsonProperty("signPubKeyCert")]
        public string SignPubKeyCert { get; set; }
    }
}
