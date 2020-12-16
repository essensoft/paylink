using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserFamilyArchiveQueryResponse.
    /// </summary>
    public class AlipayUserFamilyArchiveQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 家庭档案列表，包含档案id、档案详情等
        /// </summary>
        [JsonPropertyName("archive_list")]
        public List<FamilyArchiveDetail> ArchiveList { get; set; }
    }
}
