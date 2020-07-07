using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPayQueryBankResponse : WeChatPayResponse
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
        /// 商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        [XmlElement("partner_trade_no")]
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 微信企业付款单号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("bank_no_md5")]
        public string BankNoMd5 { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [XmlElement("true_name_md5")]
        public string TrueNameMd5 { get; set; }

        /// <summary>
        /// 代付金额
        /// </summary>
        [XmlElement("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 代付单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 手续费金额
        /// </summary>
        [XmlElement("cmms_amt")]
        public string CmmsAmt { get; set; }

        /// <summary>
        /// 商户下单时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 成功付款时间
        /// </summary>
        [XmlElement("pay_succ_time")]
        public string PaySuccTime { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
