using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationFaceSearchQueryResponse.
    /// </summary>
    public class ZolozAuthenticationFaceSearchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 搜索到的人脸候选集
        /// </summary>
        [JsonPropertyName("candidate_list")]
        public List<FaceSearchResult> CandidateList { get; set; }

        /// <summary>
        /// 人脸搜索找到的用户
        /// </summary>
        [JsonPropertyName("found_face")]
        public FaceSearchResult FoundFace { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [JsonPropertyName("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [JsonPropertyName("ret_message_sub")]
        public string RetMessageSub { get; set; }
    }
}
