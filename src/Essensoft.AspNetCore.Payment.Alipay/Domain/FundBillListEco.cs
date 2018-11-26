using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FundBillListEco Data Structure.
    /// </summary>
    [Serializable]
    public class FundBillListEco : AlipayObject
    {
        /// <summary>
        /// 该支付工具类型所使用的金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易使用的资金渠道，详见 <a href="https://doc.open.alipay.com/doc2/detail?treeId=26&articleId=103259&docType=1">支付渠道列表</a>
        /// </summary>
        [JsonProperty("fund_channel")]
        [XmlElement("fund_channel")]
        public string FundChannel { get; set; }
    }
}
