using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainCourseModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainCourseModifyModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 课程简介
        /// </summary>
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 分类信息(从分类列表接口选取)
        /// </summary>
        [JsonPropertyName("cate_infos")]
        public List<CateInfo> CateInfos { get; set; }

        /// <summary>
        /// 支付宝内部课程id
        /// </summary>
        [JsonPropertyName("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程详情
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商家信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public ShopMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 上课时间
        /// </summary>
        [JsonPropertyName("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 外部课程id
        /// </summary>
        [JsonPropertyName("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 课程主图
        /// </summary>
        [JsonPropertyName("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 场景类型(ONLINE : 线上、OFFLINE : 线下)
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 课程SKU信息
        /// </summary>
        [JsonPropertyName("sku_infos")]
        public List<CourseSKUInfo> SkuInfos { get; set; }

        /// <summary>
        /// 来源(XIAOBAO : 校宝)
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonPropertyName("tag_infos")]
        public List<CourseTagInfo> TagInfos { get; set; }

        /// <summary>
        /// 详情页地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 主视频地址
        /// </summary>
        [JsonPropertyName("video")]
        public string Video { get; set; }
    }
}
