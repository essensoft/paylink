using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicStdMockListsmlistApiResponse.
    /// </summary>
    public class AlipayMobilePublicStdMockListsmlistApiResponse : AlipayResponse
    {
        /// <summary>
        /// 简单对象嵌套List
        /// </summary>
        [JsonProperty("list_sm_model_list")]
        public List<ListListSmMockModel> ListSmModelList { get; set; }
    }
}
