using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartContentSubmitModel Data Structure.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartContentSubmitModel : AlipayObject
    {
        /// <summary>
        /// app_name为调用方系统名称(英文名称),与分配的app_token一起做调用系统合法性校验。
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token为系统分配的密钥，与app_name一起做调用系统合法性校验
        /// </summary>
        [JsonPropertyName("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 业务编码，一个业务biz_code代表当前业务，可以包含多个scene_code，与scene_code之间为一对多的关系。
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 文件信息列表,其中业务素材类型默认不传,特殊场景需约定传参。
        /// </summary>
        [JsonPropertyName("file_info_list")]
        public List<FileInfo> FileInfoList { get; set; }

        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证业务请求幂等性，同时在请求完毕后，获取业务风险详情信息结果使用
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景编码。内容审核业务对应的场景代码。
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
