using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertinfoMaskedQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCertinfoMaskedQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，不可为空，一次最多传10个
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
