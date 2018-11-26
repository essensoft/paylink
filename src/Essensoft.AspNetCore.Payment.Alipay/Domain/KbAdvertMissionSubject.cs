using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertMissionSubject Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertMissionSubject : AlipayObject
    {
        /// <summary>
        /// 分佣条款信息
        /// </summary>
        [JsonProperty("commission_clause_list")]
        [XmlArray("commission_clause_list")]
        [XmlArrayItem("kb_advert_commission_clause")]
        public List<KbAdvertCommissionClause> CommissionClauseList { get; set; }

        /// <summary>
        /// 标的对象的业务ID，如果标的为商品，则subject_biz_id为商品ID
        /// </summary>
        [JsonProperty("subject_biz_id")]
        [XmlElement("subject_biz_id")]
        public string SubjectBizId { get; set; }

        /// <summary>
        /// 标的类型  voucher-券
        /// </summary>
        [JsonProperty("subject_type")]
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
