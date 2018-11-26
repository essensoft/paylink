using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionBuildQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionBuildQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 构建的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时
        /// </summary>
        [JsonProperty("build_status")]
        [XmlElement("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 创建版本的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时；6-版本创建成功
        /// </summary>
        [JsonProperty("create_status")]
        [XmlElement("create_status")]
        public string CreateStatus { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [JsonProperty("need_rotation")]
        [XmlElement("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 是否创建版本
        /// </summary>
        [JsonProperty("version_created")]
        [XmlElement("version_created")]
        public string VersionCreated { get; set; }
    }
}
