using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringCrowdgroupConditionSetResponse.
    /// </summary>
    public class KoubeiCateringCrowdgroupConditionSetResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功返回isv创建的分组规则列表
        /// </summary>
        [JsonProperty("condition_model_list")]
        [XmlArray("condition_model_list")]
        [XmlArrayItem("condition_item_pattern")]
        public List<ConditionItemPattern> ConditionModelList { get; set; }

        /// <summary>
        /// isv创建的用户分组id
        /// </summary>
        [JsonProperty("crowd_group_id")]
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 创建状态: success fail
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
