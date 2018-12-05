using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    [XmlRoot("xml")]
    internal class WeChatPaySendWorkWxRedPackResponse : WeChatPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// 此字段是通信标识，非交易标识，
        /// 交易是否成功需要查看result_code来判断
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息，如非空，为错误原因
        /// 签名失败
        /// 参数格式校验错误
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

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
        /// 错误代码描述
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("mch_billno")]
        public string MchBillNo { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [XmlElement("wxappid")]
        public string WxAppId { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("re_openid")]
        public string ReOpenId { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 微信单号
        /// </summary>
        [XmlElement("send_listid")]
        public string SendListId { get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 发送者头像
        /// </summary>
        [XmlElement("sender_header_media_id")]
        public string SenderHeaderMediaId { get; set; }
    }
}
