using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityExternalbillsyncUploadModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityExternalbillsyncUploadModel : AlipayObject
    {
        /// <summary>
        /// 小区短名，本接口只支持按小区纬度动账
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 同步对象，最大长度100
        /// </summary>
        [JsonPropertyName("external_sync_list")]
        public List<ExternalSyncRequest> ExternalSyncList { get; set; }
    }
}
