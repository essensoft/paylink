using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Response
{
    [XmlRoot("xml")]
    public class QPayEPayStatementDownResponse : QPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 原始错误码
        /// </summary>
        [XmlElement("retcode")]
        public string RetCode { get; set; }

        /// <summary>
        /// 原始错误信息
        /// </summary>
        [XmlElement("retmsg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述	
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }
    }
}
