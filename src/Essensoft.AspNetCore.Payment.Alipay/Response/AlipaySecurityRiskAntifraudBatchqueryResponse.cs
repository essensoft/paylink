using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskAntifraudBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityRiskAntifraudBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 供应商关系列表+company_list是两个有关系的供应商，detail字段描述了具体的关系，detail为jsonArray表示两者之间可能的多种关系
        /// </summary>
        [JsonPropertyName("company_relation_list")]
        public List<string> CompanyRelationList { get; set; }

        /// <summary>
        /// 员工供应商关系列表+staff字段为员工姓名，company字段为供应商，detail描述了员工和供应商的关系详情,detail为jsonArray表示两者之间可能的多种关系
        /// </summary>
        [JsonPropertyName("staff_company_relation_list")]
        public List<string> StaffCompanyRelationList { get; set; }
    }
}
