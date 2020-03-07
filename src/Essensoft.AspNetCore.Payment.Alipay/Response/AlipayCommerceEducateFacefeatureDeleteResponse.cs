using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureDeleteResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 出库失败的faceId集合
        /// </summary>
        [JsonPropertyName("face_ids")]
        public List<string> FaceIds { get; set; }
    }
}
