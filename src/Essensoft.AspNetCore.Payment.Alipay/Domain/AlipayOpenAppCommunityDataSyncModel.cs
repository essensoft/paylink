using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityDataSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppCommunityDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 操作类型.PUT:新增或覆盖,REMOVE:删除
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 上传数据批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 用于标识数据所属数据类目
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上传数据列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<BizData> DataList { get; set; }

        /// <summary>
        /// 社区素材内容数据类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
