using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishGroupInfo : AlipayObject
    {
        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("create_user")]
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 套餐组明细
        /// </summary>
        [JsonProperty("detail_list")]
        [XmlArray("detail_list")]
        [XmlArrayItem("kbdish_group_detail_info")]
        public List<KbdishGroupDetailInfo> DetailList { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [JsonProperty("group_name")]
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        [JsonProperty("group_rule")]
        [XmlElement("group_rule")]
        public string GroupRule { get; set; }

        /// <summary>
        /// 版本号 就是一个数据操作的时间戳
        /// </summary>
        [JsonProperty("group_version")]
        [XmlElement("group_version")]
        public string GroupVersion { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 份数限制
        /// </summary>
        [JsonProperty("unit_count_limit")]
        [XmlElement("unit_count_limit")]
        public string UnitCountLimit { get; set; }

        /// <summary>
        /// 修改操作小二
        /// </summary>
        [JsonProperty("update_user")]
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
