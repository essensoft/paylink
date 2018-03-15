using System.Xml.Serialization;

namespace Essensoft.AspNetCore.UnionPay.Response
{
    public class UnionPayForm_6_4_RefundResponse : UnionPayResponse
    {
        /// <summary>
        /// 二维码数据
        /// </summary>
        [XmlElement("qrCode")]
        public string QrCode { get; set; }

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
        /// 签名公钥证书
        /// 使用RSA签名方式时必选，此域填写银联签名公钥证书。
        /// </summary>
        [XmlElement("signPubKeyCert")]
        public string SignPubKeyCert { get; set; }

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
        /// 保留域
        /// </summary>
        [XmlElement("reserved")]
        public string Reserved { get; set; }
    }
}
