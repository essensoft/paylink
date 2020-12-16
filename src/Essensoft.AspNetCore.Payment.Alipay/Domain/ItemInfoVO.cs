using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemInfoVO Data Structure.
    /// </summary>
    public class ItemInfoVO : AlipayObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public EduTrainExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 所属一级分类列表
        /// </summary>
        [JsonPropertyName("first_cates")]
        public List<CateInfoVO> FirstCates { get; set; }

        /// <summary>
        /// serviceCode
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 热门
        /// </summary>
        [JsonPropertyName("is_hot")]
        public string IsHot { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonPropertyName("ori_price")]
        public string OriPrice { get; set; }

        /// <summary>
        /// 父元素信息
        /// </summary>
        [JsonPropertyName("p_item_info")]
        public PItemInfoVO PItemInfo { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; }

        /// <summary>
        /// 价格、人均消费
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// scm埋点，前端埋点使用
        /// </summary>
        [JsonPropertyName("scm")]
        public string Scm { get; set; }

        /// <summary>
        /// 所属二级分类列表
        /// </summary>
        [JsonPropertyName("secend_cates")]
        public List<CateInfoVO> SecendCates { get; set; }

        /// <summary>
        /// 来源标识 支付宝：ALIPAY 淘宝：TB 口碑：KB 饿了么：ELM
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 提示信息 如：活动优惠信息列表
        /// </summary>
        [JsonPropertyName("tips")]
        public List<string> Tips { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
