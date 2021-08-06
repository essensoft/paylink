using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardmsgSyncModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityOwnercardmsgSyncModel : AlipayObject
    {
        /// <summary>
        /// 产品类型： OWNER_CARD 电子业主卡
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 社区code
        /// </summary>
        [JsonPropertyName("community")]
        public string Community { get; set; }

        /// <summary>
        /// 社区底座小区短名
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 区县code
        /// </summary>
        [JsonPropertyName("county")]
        public string County { get; set; }

        /// <summary>
        /// 过期时间，默认2099-12-31
        /// </summary>
        [JsonPropertyName("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 消息id，若不为空则表示更新
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否置顶1-是，0-否
        /// </summary>
        [JsonPropertyName("is_top")]
        public string IsTop { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 外部消息id
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 省code
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonPropertyName("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 发布单位：如机构、街道、社区、业委会、物业
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 服务类型： NOTICE 通知公告， VOTE 投票表决， FUNDING 经营性收支， QUESTIONNAIRE 问卷调查
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 状态 ONLINE：在线 INVALID：失效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 街道code
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// 产品子类型： HANGZHOU_OWNER_CARD 杭州房管局电子业主卡
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 个性化模板json格式： NORMAL 通用类型 空 VOTE 投票表决 投票率 voteRate  （必填，数据类型：数字） 投票率数据日期 voteDate（ 必填，数据类型：日期，日期格式：yyyy-MM-dd HH:mm:ss）； 投票截止日期 voteEndDate（ 必填，数据类型：日期，日期格式：yyyy-MM-dd HH:mm:ss）  FUNDING 经营性收支 月份 month  (必填，数据类型：数字) 结余 balance (必填，数据类型：数字) 收入 income (必填，数据类型：数字) 支出 expenditure (必填，数据类型：数字)
        /// </summary>
        [JsonPropertyName("template_content")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 模板类型： NORMAL通用类型 VOTE 投票类型 FUNDING 经营性收支类型
        /// </summary>
        [JsonPropertyName("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
