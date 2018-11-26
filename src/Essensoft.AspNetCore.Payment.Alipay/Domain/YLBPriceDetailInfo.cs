using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// YLBPriceDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YLBPriceDetailInfo : AlipayObject
    {
        /// <summary>
        /// 余利宝行情日期，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("price_date")]
        [XmlElement("price_date")]
        public string PriceDate { get; set; }

        /// <summary>
        /// 七日年化收益率（%），精确到小数点后4位
        /// </summary>
        [JsonProperty("sevendays_yeild_rate")]
        [XmlElement("sevendays_yeild_rate")]
        public string SevendaysYeildRate { get; set; }

        /// <summary>
        /// 万份收益金额，单位为元
        /// </summary>
        [JsonProperty("tenthousand_income")]
        [XmlElement("tenthousand_income")]
        public string TenthousandIncome { get; set; }
    }
}
