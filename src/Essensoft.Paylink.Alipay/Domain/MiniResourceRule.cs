using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MiniResourceRule Data Structure.
    /// </summary>
    public class MiniResourceRule : AlipayObject
    {
        /// <summary>
        /// 选品类目ID，在type为CHOOSE_RULE的时候必填
        /// </summary>
        [JsonPropertyName("floor_id")]
        public string FloorId { get; set; }

        /// <summary>
        /// 推广位ID, 在type为RESOURCE_ORIGIN的时候必填，在淘联盟中identity_id是一个用三个 "_" 分隔的字符串.
        /// </summary>
        [JsonPropertyName("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 推广位名称，在type为RESOURCE_ORIGIN时必填
        /// </summary>
        [JsonPropertyName("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 过滤的商品ID列表,用英文逗号分隔。仅仅在type值为FILTER_RULE的时候需要传；
        /// </summary>
        [JsonPropertyName("item_id_list")]
        public string ItemIdList { get; set; }

        /// <summary>
        /// 推广位来源，在type为RESOURCE_ORIGIN的时候必填
        /// </summary>
        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 规则id，在修改流量位规则时必填；在新增流量位时不填，如果传入则忽略；
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonPropertyName("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则类型，规则保存成功后，规则类型不可更改，在更新请求中传入type将被忽略。以下是目前受支持的type值： RESOURCE_ORIGIN：来源规则，例如陶联盟； FILTER_RULE：滤品规则，用于过滤指定商品； CHOOSE_RULE：选品规则，用于选取符合条件的商品；
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
