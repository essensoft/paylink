using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppMembersQueryResponse.
    /// </summary>
    public class AlipayOpenAppMembersQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序成员模型
        /// </summary>
        [JsonProperty("app_member_info_list")]
        [XmlArray("app_member_info_list")]
        [XmlArrayItem("app_member_info")]
        public List<AppMemberInfo> AppMemberInfoList { get; set; }
    }
}
