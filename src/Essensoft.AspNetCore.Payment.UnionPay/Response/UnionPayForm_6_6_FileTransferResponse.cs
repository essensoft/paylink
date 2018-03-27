using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.UnionPay.Response
{
    public class UnionPayForm_6_6_FileTransferResponse : UnionPayResponse
    {
        /// <summary>
        /// 批量文件内容
        /// 文件流方式
        /// </summary>
        [XmlElement("fileContent")]
        public string FileContent { get; set; }

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
        /// 文件名
        /// </summary>
        [XmlElement("fileName")]
        public string FileName { get; set; }

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
        /// 证书ID
        /// </summary>
        [XmlElement("certId")]
        public string CertId { get; set; }

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
        /// 交易类型
        /// </summary>
        [XmlElement("txnType")]
        public string TxnType { get; set; }

        /// <summary>
        /// 交易子类
        /// 01：对账文件下载
        /// </summary>
        [XmlElement("txnSubType")]
        public string TxnSubType { get; set; }

        /// <summary>
        /// 接入类型
        /// </summary>
        [XmlElement("accessType")]
        public string AccessType { get; set; }

        /// <summary>
        /// 清算日期
        /// </summary>
        [XmlElement("settleDate")]
        public string SettleDate { get; set; }

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
        /// 文件类型
        /// </summary>
        [XmlElement("fileType")]
        public string FileType { get; set; }
    }
}
