using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiContentContentinfoModifyModel Data Structure.
    /// </summary>
    public class KoubeiContentContentinfoModifyModel : AlipayObject
    {
        /// <summary>
        /// 内容跳转地址
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 内容的作者
        /// </summary>
        [JsonPropertyName("author")]
        public PrincipalForOpenapi Author { get; set; }

        /// <summary>
        /// 业务类型,图文+视频填入:ZG_ARTICLE   讲师填入:ZG_TEACHER
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        [JsonPropertyName("content_desc")]
        public string ContentDesc { get; set; }

        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容关联对象列表, 如店铺、商品等
        /// </summary>
        [JsonPropertyName("content_object_relation_list")]
        public List<ContentObjectRelationForOpenapi> ContentObjectRelationList { get; set; }

        /// <summary>
        /// 内容类型  如果是文咨询、讲师，设置为：COMPOSITE  如果是视频，设置为：VIDEO
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 封面图片地址
        /// </summary>
        [JsonPropertyName("cover_pics")]
        public List<string> CoverPics { get; set; }

        /// <summary>
        /// 拓展字段枚举  PRICE,价格,  DISCOUNT_PRICE,优惠价格,  CREATE_TIME,创建时间, val=时间戳，到毫秒  ENABLE_TIME,发布时间,val=时间戳，到毫秒  MODIFY_TIME,最后修改时间,val=时间戳，到毫秒  VIDEO,视频,  SOURCE,来源,
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 内容拓展列表
        /// </summary>
        [JsonPropertyName("extensions")]
        public List<ContentExtensionForOpenapi> Extensions { get; set; }

        /// <summary>
        /// 外部文章id,外部讲师id
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 内容标记列表,如内容投放城市、推荐等
        /// </summary>
        [JsonPropertyName("label_list")]
        public List<LabelForOpenapi> LabelList { get; set; }

        /// <summary>
        /// 请求唯一id,UUID生成,外部系统幂等用
        /// </summary>
        [JsonPropertyName("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 状态枚举:  INIT,初始态,  AUDITING,审核中,  INFOSEC_AUDITING,风控审核中,  ENABLE,有效,  DISABLE,无效,  AUDIT_DENY,审核拒绝
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子标题
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
