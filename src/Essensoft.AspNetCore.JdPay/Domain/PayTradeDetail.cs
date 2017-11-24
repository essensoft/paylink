using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Domain
{
    [XmlRoot("detail")]
    public class PayTradeDetail
    {
        /// <summary>
        /// 持卡人人姓名  掩码显示（隐去第一位）
        /// </summary>
        [XmlElement("cardHolderName")]
        public string CardHolderName { set; get; }

        /// <summary>
        /// 持卡人手机号  掩码显示（手机号的前三位与后四位）
        /// </summary>
        [XmlElement("cardHolderMobile")]
        public string CardHolderMobile { set; get; }

        /// <summary>
        /// 证件类型   ID("0", "身份证"), PASSPORT("1", "护照"), OFFICER("2", "军官证"), SOLDIER("3", "士兵证"), TWHK_PASSPORT("4", "港奥台通行证"), TEMP_ID("5", "临时身份证"), HOUSEHOLDREGISTER("6", "户口本"), OTHER("7", "其它类型证件")
        /// </summary>
        [XmlElement("cardHolderType")]
        public string CardHolderType { set; get; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cardHolderId")]
        public string CardHolderId { set; get; }

        /// <summary>
        /// 卡号  掩码显示（前六位及后四位）
        /// </summary>
        [XmlElement("cardNo")]
        public string CardNo { set; get; }

        /// <summary>
        /// 银行编码
        /// </summary>
        [XmlElement("bankCode")]
        public string BankCode { set; get; }

        /// <summary>
        /// 银行卡类型   DEBIT_CARD：借记卡CREDIT_CARD：信用卡SEMI_CREDIT_CARD：准贷记卡
        /// </summary>
        [XmlElement("cardType")]
        public string CardType { set; get; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("payMoney")]
        public long PayMoney { set; get; }
    }
}