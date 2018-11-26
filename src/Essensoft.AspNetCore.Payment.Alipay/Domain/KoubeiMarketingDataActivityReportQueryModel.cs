using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataActivityReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataActivityReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询报表数据的业务日期列表，精确到天，格式为yyyymmdd，支持列表格式，数据按天返回
        /// </summary>
        [JsonProperty("biz_date")]
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
