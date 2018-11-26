using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseBookInfo : AlipayObject
    {
        /// <summary>
        /// 定金金额
        /// </summary>
        [JsonProperty("book_amount")]
        [XmlElement("book_amount")]
        public string BookAmount { get; set; }

        /// <summary>
        /// 约定月租金额
        /// </summary>
        [JsonProperty("book_sale_amount")]
        [XmlElement("book_sale_amount")]
        public string BookSaleAmount { get; set; }

        /// <summary>
        /// 约定最晚签约日格式 YYYY-MM-dd
        /// </summary>
        [JsonProperty("latest_signing_date")]
        [XmlElement("latest_signing_date")]
        public string LatestSigningDate { get; set; }

        /// <summary>
        /// 约定租约开始时间格式 YYYY-MM-dd
        /// </summary>
        [JsonProperty("lease_begin_date")]
        [XmlElement("lease_begin_date")]
        public string LeaseBeginDate { get; set; }

        /// <summary>
        /// 约定租约开始结束格式 YYYY-MM-dd
        /// </summary>
        [JsonProperty("lease_end_date")]
        [XmlElement("lease_end_date")]
        public string LeaseEndDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
