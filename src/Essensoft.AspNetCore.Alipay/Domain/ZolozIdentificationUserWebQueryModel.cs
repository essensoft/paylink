using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationUserWebQueryModel Data Structure.
    /// </summary>
    public class ZolozIdentificationUserWebQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户请求的唯一标识，须与初始化传入的bizId保持一致
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("extern_param")]
        public string ExternParam { get; set; }

        /// <summary>
        /// 刷脸认证的唯一标识，用于查询认证结果
        /// </summary>
        [JsonProperty("zim_id")]
        public string ZimId { get; set; }
    }
}
