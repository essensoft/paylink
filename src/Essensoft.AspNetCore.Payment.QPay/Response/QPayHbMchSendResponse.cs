using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Response
{
    [XmlRoot("xml")]
    public class QPayHbMchSendResponse : QPayResponse
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
        /// 红包单号
        /// </summary>
        [XmlElement("listid")]
        public string ListId { get; set; }
    }
}
