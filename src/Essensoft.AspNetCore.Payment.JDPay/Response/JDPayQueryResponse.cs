using Essensoft.AspNetCore.Payment.JDPay.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    [XmlRoot("jdpay")]
    public class JDPayQueryResponse : JDPayResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        [XmlElement("device")]
        public string Device { get; set; }

        /// <summary>
        /// 交易流水
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("tradeType")]
        public string TradeType { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("result")]
        public Result Result { get; set; }

        /// <summary>
        /// 数据签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 支付总金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 明细列表
        /// </summary>
        [XmlArray("payList")]
        [XmlArrayItem("pay")]
        public List<PayTradeVo> PayList { get; set; }

        /// <summary>
        /// 支付方式金额
        /// </summary>
        [XmlElement("payMoney")]
        public string PayMoney { get; set; }

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

        // 退款交易查询 部分数据

        /// <summary>
        /// 原交易流水号
        /// </summary>
        [XmlElement("oTradeNum")]
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("tradeTime")]
        public string TradeTime { get; set; }
    }
}
