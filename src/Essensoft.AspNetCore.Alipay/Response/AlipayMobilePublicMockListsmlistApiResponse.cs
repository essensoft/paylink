using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMockListsmlistApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockListsmlistApiResponse : AlipayResponse
    {
        /// <summary>
        /// 简单模型嵌套list
        /// </summary>
        [JsonProperty("list_sm_model_list")]
        public List<ListListSmMockModel> ListSmModelList { get; set; }
    }
}
