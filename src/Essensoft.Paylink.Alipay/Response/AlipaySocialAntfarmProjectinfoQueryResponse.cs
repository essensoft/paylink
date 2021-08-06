using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntfarmProjectinfoQueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmProjectinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 正在进行的项目，含当前正在进行的标的物
        /// </summary>
        [JsonPropertyName("project_list")]
        public List<AntfarmProjectInfo> ProjectList { get; set; }
    }
}
