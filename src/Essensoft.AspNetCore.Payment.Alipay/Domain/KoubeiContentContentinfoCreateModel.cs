using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiContentContentinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentContentinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 内容跳转地址
        /// </summary>
        [JsonProperty("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 内容的作者
        /// </summary>
        [JsonProperty("author")]
        public PrincipalForOpenapi Author { get; set; }

        /// <summary>
        /// 业务类型,图文+视频填入:ZG_ARTICLE   讲师填入:ZG_TEACHER
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        [JsonProperty("content_desc")]
        public string ContentDesc { get; set; }

        /// <summary>
        /// 内容关联对象列表, 如店铺、商品等
        /// </summary>
        [JsonProperty("content_object_relation_list")]
        public List<ContentObjectRelationForOpenapi> ContentObjectRelationList { get; set; }

        /// <summary>
        /// 内容类型  如果是文咨询、讲师，设置为：COMPOSITE  如果是视频，设置为：VIDEO
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 封面图片地址
        /// </summary>
        [JsonProperty("cover_pics")]
        public List<string> CoverPics { get; set; }

        /// <summary>
        /// 拓展字段枚举  PRICE,价格,  DISCOUNT_PRICE,优惠价格,  CREATE_TIME,创建时间, val=时间戳，到毫秒  ENABLE_TIME,发布时间,val=时间戳，到毫秒  MODIFY_TIME,最后修改时间,val=时间戳，到毫秒  VIDEO,视频,  SOURCE,来源,
        /// </summary>
        [JsonProperty("ext_into")]
        public string ExtInto { get; set; }

        /// <summary>
        /// 内容拓展列表,主要存放一些比较长的内容，如文章、帖子等
        /// </summary>
        [JsonProperty("extensions")]
        public List<ContentExtensionForOpenapi> Extensions { get; set; }

        /// <summary>
        /// 外部文章id,外部讲师id
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 内容标记列表,如内容投放城市、推荐等
        /// </summary>
        [JsonProperty("label_list")]
        public List<LabelForOpenapi> LabelList { get; set; }

        /// <summary>
        /// 请求唯一id,UUID生成,外部系统幂等用
        /// </summary>
        [JsonProperty("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 状态枚举:  INIT,初始态,  AUDITING,审核中,  INFOSEC_AUDITING,风控审核中,  ENABLE,有效,  DISABLE,无效,  AUDIT_DENY,审核拒绝
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子标题
        /// </summary>
        [JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
