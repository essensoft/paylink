using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosPrintQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPrintQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 打印机Model对象集合
        /// </summary>
        [JsonPropertyName("print_model_list")]
        public List<PrintModel> PrintModelList { get; set; }
    }
}
