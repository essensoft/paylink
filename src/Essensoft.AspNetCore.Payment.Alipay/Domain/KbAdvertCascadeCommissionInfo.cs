using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertCascadeCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCascadeCommissionInfo : AlipayObject
    {
        /// <summary>
        /// 二级分佣条款信息
        /// </summary>
        [JsonProperty("commission_clause_infos")]
        [XmlArray("commission_clause_infos")]
        [XmlArrayItem("kb_advert_commission_clause")]
        public List<KbAdvertCommissionClause> CommissionClauseInfos { get; set; }

        /// <summary>
        /// 二级分佣任务认领人类型  PROMOTER：其他推广者  KOUBEI_PLATFORM：口碑平台
        /// </summary>
        [JsonProperty("commission_user_type")]
        [XmlElement("commission_user_type")]
        public string CommissionUserType { get; set; }
    }
}
