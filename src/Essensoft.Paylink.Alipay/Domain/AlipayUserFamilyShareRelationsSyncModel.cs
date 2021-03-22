using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareRelationsSyncModel Data Structure.
    /// </summary>
    public class AlipayUserFamilyShareRelationsSyncModel : AlipayObject
    {
        /// <summary>
        /// 共享关系过期时间
        /// </summary>
        [JsonPropertyName("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 共享资源的内容，例如卡号、协议号
        /// </summary>
        [JsonPropertyName("resource_content")]
        public string ResourceContent { get; set; }

        /// <summary>
        /// 共享关系接入资源
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 共享关系接入场景
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 共享账号的列表
        /// </summary>
        [JsonPropertyName("sharing_user_ids")]
        public List<string> SharingUserIds { get; set; }

        /// <summary>
        /// 共享账号类型 ALIPAY 、HAVANA、ARCHIVE
        /// </summary>
        [JsonPropertyName("sharing_user_type")]
        public string SharingUserType { get; set; }

        /// <summary>
        /// 目标状态
        /// </summary>
        [JsonPropertyName("target_status")]
        public long TargetStatus { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("update_date")]
        public string UpdateDate { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 关系变更版本号
        /// </summary>
        [JsonPropertyName("version_no")]
        public string VersionNo { get; set; }
    }
}
