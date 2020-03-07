using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntarchiveFaceQueryResponse.
    /// </summary>
    public class AlipayUserAntarchiveFaceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回人脸图片类型列表.若不存在则返回空列表
        /// </summary>
        [JsonPropertyName("archive_face_list")]
        public List<ArchiveFaceInfo> ArchiveFaceList { get; set; }

        /// <summary>
        /// 是否存在本地可用比对源图片
        /// </summary>
        [JsonPropertyName("local_usable")]
        public bool LocalUsable { get; set; }

        /// <summary>
        /// 是否存在远程可用比对源图片
        /// </summary>
        [JsonPropertyName("remote_usable")]
        public bool RemoteUsable { get; set; }
    }
}
