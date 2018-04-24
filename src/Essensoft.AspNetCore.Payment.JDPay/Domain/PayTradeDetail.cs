using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Domain
{
    public class PayTradeDetail
    {
        /// <summary>
        /// 持卡人人姓名
        /// </summary>
        [XmlElement("cardHolderName")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// 持卡人手机号
        /// </summary>
        [XmlElement("cardHolderMobile")]
        public string CardHolderMobile { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cardHolderType")]
        public string CardHolderType { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cardHolderId")]
        public string CardHolderId { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("cardNo")]
        public string CardNo { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        [XmlElement("bankCode")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行卡类型
        /// </summary>
        [XmlElement("cardType")]
        public string CardType { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("payMoney")]
        public string PayMoney { get; set; }
    }
}