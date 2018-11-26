using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorDepositCancelModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，传递撤销的终端信息，原因等
        /// </summary>
        [JsonProperty("biz_info_ext")]
        [XmlElement("biz_info_ext")]
        public string BizInfoExt { get; set; }

        /// <summary>
        /// 充值卡号
        /// </summary>
        [JsonProperty("card_no")]
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 交通卡卡类型，一个城市只有一个固定的值
        /// </summary>
        [JsonProperty("card_type")]
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 撤销时间
        /// </summary>
        [JsonProperty("operate_time")]
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 商户的交易号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
