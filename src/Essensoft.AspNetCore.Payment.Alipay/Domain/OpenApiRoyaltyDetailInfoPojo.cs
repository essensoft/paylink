using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiRoyaltyDetailInfoPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiRoyaltyDetailInfoPojo : AlipayObject
    {
        /// <summary>
        /// 分账的金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 分账信息中分账百分比。取值范围为大于0，少于或等于100的整数。
        /// </summary>
        [JsonProperty("amount_percentage")]
        [XmlElement("amount_percentage")]
        public long AmountPercentage { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 分账类型.  普通分账为：transfer;  补差为：replenish;  为空默认为分账transfer;
        /// </summary>
        [JsonProperty("royalty_type")]
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 收入方账户。如果收入方账户类型为userId，本参数为收入方的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；如果收入方类型为cardSerialNo，本参数为收入方在支付宝绑定的卡编号；如果收入方类型为loginName，本参数为收入方的支付宝登录号；
        /// </summary>
        [JsonProperty("trans_in")]
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 收入方账户类型。userId表示是支付宝账号对应的支付宝唯一用户号;cardSerialNo表示是卡编号;loginName表示是支付宝登录号；
        /// </summary>
        [JsonProperty("trans_in_type")]
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 支出方账户。如果支出方账户类型为userId，本参数为支出方的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；如果支出方类型为loginName，本参数为支出方的支付宝登录号；
        /// </summary>
        [JsonProperty("trans_out")]
        [XmlElement("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 支出方账户类型。userId表示是支付宝账号对应的支付宝唯一用户号;loginName表示是支付宝登录号；
        /// </summary>
        [JsonProperty("trans_out_type")]
        [XmlElement("trans_out_type")]
        public string TransOutType { get; set; }
    }
}
