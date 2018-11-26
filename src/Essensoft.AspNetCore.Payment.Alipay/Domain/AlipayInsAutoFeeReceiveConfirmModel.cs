using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoFeeReceiveConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoFeeReceiveConfirmModel : AlipayObject
    {
        /// <summary>
        /// 外部业务单号，幂等字段，必填。和保险公司交互时同收单系统的outTradeNo
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易总金额 ;单位分
        /// </summary>
        [JsonProperty("trade_amount")]
        [XmlElement("trade_amount")]
        public long TradeAmount { get; set; }
    }
}
