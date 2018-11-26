using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRooominfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeRooominfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 业主所在物业小区ID(支付宝平台唯一小区ID标示)
        /// </summary>
        [JsonProperty("community_id")]
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 分页查询的页码数，分页从1开始计数。该参数不传入的时候，默认为1
        /// </summary>
        [JsonProperty("page_num")]
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页最大数据条数。默认为200
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
