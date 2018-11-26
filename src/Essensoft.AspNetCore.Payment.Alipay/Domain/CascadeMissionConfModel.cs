using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CascadeMissionConfModel Data Structure.
    /// </summary>
    [Serializable]
    public class CascadeMissionConfModel : AlipayObject
    {
        /// <summary>
        /// 分佣条款列表  1、二级分佣，如果认领人类型为Promote，则不能设置独家（clause_type=MISSION_CLAIM_CLAUSE）  2、二级分用，最大金额无需设置，而是系统自动计算
        /// </summary>
        [JsonProperty("commission_clause")]
        [XmlArray("commission_clause")]
        [XmlArrayItem("kb_advert_commission_clause")]
        public List<KbAdvertCommissionClause> CommissionClause { get; set; }

        /// <summary>
        /// 二级分佣认领人类型  PROMOTER:第三方推广者  KOUBEI_PLATFORM：口碑平台推广
        /// </summary>
        [JsonProperty("commission_user_type")]
        [XmlElement("commission_user_type")]
        public string CommissionUserType { get; set; }
    }
}
