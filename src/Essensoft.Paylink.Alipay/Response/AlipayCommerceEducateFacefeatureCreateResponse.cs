using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 通用一脸通行用户入库结果
        /// </summary>
        [JsonPropertyName("face_put_list")]
        public List<StandardFacePutInfo> FacePutList { get; set; }
    }
}
