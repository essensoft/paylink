using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerAnonymousfacesearchMatchResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerAnonymousfacesearchMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 搜索到的人脸候选集
        /// </summary>
        [JsonPropertyName("candidatelist")]
        public List<FaceSearchUserInfo> Candidatelist { get; set; }

        /// <summary>
        /// 人脸搜索找到的用户
        /// </summary>
        [JsonPropertyName("foundface")]
        public FaceSearchUserInfo Foundface { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [JsonPropertyName("retcodesub")]
        public string Retcodesub { get; set; }

        /// <summary>
        /// 操作成功
        /// </summary>
        [JsonPropertyName("retmessagesub")]
        public string Retmessagesub { get; set; }

        /// <summary>
        /// 返回账户信息:merchantid/merchantuid
        /// </summary>
        [JsonPropertyName("userinfolist")]
        public List<FaceSearchAnonymousUserInfo> Userinfolist { get; set; }
    }
}
