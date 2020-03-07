using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdElecsealOrderApplyModel Data Structure.
    /// </summary>
    public class AlipayBossProdElecsealOrderApplyModel : AlipayObject
    {
        /// <summary>
        /// 接入法务中台电子应用服务的主体，一般为app名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 请求版本号，由法务中台技术提供值
        /// </summary>
        [JsonPropertyName("app_version")]
        public long AppVersion { get; set; }

        /// <summary>
        /// 业务幂等字段，用于唯一标示一条业务记录
        /// </summary>
        [JsonPropertyName("business_unique_id")]
        public string BusinessUniqueId { get; set; }

        /// <summary>
        /// 业务方上传到法务中台oss，待进行电子签章的pdf文件地址
        /// </summary>
        [JsonPropertyName("file_oss_key")]
        public string FileOssKey { get; set; }

        /// <summary>
        /// 甲方签约主体信息
        /// </summary>
        [JsonPropertyName("first_party")]
        public AntlawSignOperator FirstParty { get; set; }

        /// <summary>
        /// 根据请求值生成的hash值，用于法务中台进行鉴权
        /// </summary>
        [JsonPropertyName("hash_value")]
        public string HashValue { get; set; }

        /// <summary>
        /// 按页定义模式下的用印申请信息，每一页单独定义
        /// </summary>
        [JsonPropertyName("seal_page_info_list")]
        public List<SealPageInfo> SealPageInfoList { get; set; }

        /// <summary>
        /// 电子用印申请类型，包括按页申请（PAGE_MODE）和统一模式申请(UNIFIED)
        /// </summary>
        [JsonPropertyName("seal_request_mode")]
        public string SealRequestMode { get; set; }

        /// <summary>
        /// 乙方签约企业列表
        /// </summary>
        [JsonPropertyName("second_parties")]
        public List<AntlawSignOperator> SecondParties { get; set; }

        /// <summary>
        /// 统一模式下需要用印的页码列表
        /// </summary>
        [JsonPropertyName("unified_page_index_list")]
        public List<long> UnifiedPageIndexList { get; set; }

        /// <summary>
        /// 统一模式下用印请求信息的定义，需要用印的所有页面都会使用此用印信息
        /// </summary>
        [JsonPropertyName("unified_seal_request_info")]
        public SealRequestInfo UnifiedSealRequestInfo { get; set; }
    }
}
