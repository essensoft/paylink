using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneContentCommunityLabelQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityLabelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// groupKey：标签组key groupName 标签组名字
        /// </summary>
        [JsonPropertyName("label_group_list")]
        public string LabelGroupList { get; set; }

        /// <summary>
        /// 场景key
        /// </summary>
        [JsonPropertyName("scene_key")]
        public string SceneKey { get; set; }

        /// <summary>
        /// 场景名字
        /// </summary>
        [JsonPropertyName("scene_name")]
        public string SceneName { get; set; }
    }
}
