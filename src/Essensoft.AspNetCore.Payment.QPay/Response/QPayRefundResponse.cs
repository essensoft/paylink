using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Response
{
    [XmlRoot("xml")]
    public class QPayRefundResponse : QPayResponse
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
        /// 手Q CGI原始错误码
        /// </summary>
        [XmlElement("retcode")]
        public string RetCode { get; set; }

        /// <summary>
        /// 手Q CGI原始错误信息
        /// </summary>
        [XmlElement("retmsg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用ID
        /// </summary>
        [XmlElement("sub_appid")]
        public string SubAppId { get; set; }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        [XmlElement("sub_mch_id")]
        public string SubMchId { get; set; }

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
        /// 错误描述	
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// QQ钱包订单号	
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单金额	
        /// </summary>
        [XmlElement("total_fee")]
        public int TotalFee { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public int OutRefundNo { get; set; }

        /// <summary>
        /// QQ钱包退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款方式
        /// </summary>
        [XmlElement("refund_channel")]
        public string RefundChannel { get; set; }

        /// <summary>
        /// 退款申请金额
        /// </summary>
        [XmlElement("refund_fee")]
        public int RefundFee { get; set; }
    }
}
