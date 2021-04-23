using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// EduTradeExtInfo Data Structure.
    /// </summary>
    public class EduTradeExtInfo : AlipayObject
    {
        /// <summary>
        /// 课程描述信息
        /// </summary>
        [JsonPropertyName("course_desc")]
        public string CourseDesc { get; set; }

        /// <summary>
        /// 课程图片地址
        /// </summary>
        [JsonPropertyName("course_img_url")]
        public string CourseImgUrl { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [JsonPropertyName("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程标签
        /// </summary>
        [JsonPropertyName("course_tag")]
        public string CourseTag { get; set; }

        /// <summary>
        /// 课程原价，单位元，两位小数
        /// </summary>
        [JsonPropertyName("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 外部课程编号
        /// </summary>
        [JsonPropertyName("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 课程单价，单位元，两位小数
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 门店图片地址
        /// </summary>
        [JsonPropertyName("shop_img_url")]
        public string ShopImgUrl { get; set; }

        /// <summary>
        /// 店铺别名
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店可跳转地址
        /// </summary>
        [JsonPropertyName("shop_url")]
        public string ShopUrl { get; set; }
    }
}
