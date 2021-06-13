using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueModifyResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 具体地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域code
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 是否可预定 Y/N  （不传默认可预定）
        /// </summary>
        [JsonPropertyName("bookable")]
        public string Bookable { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 场馆介绍
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 场馆名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 营业时间 开始时间 - 结束时间；
        /// </summary>
        [JsonPropertyName("opening_hours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// 服务商场馆ID
        /// </summary>
        [JsonPropertyName("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("phone")]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 场馆图片链接列表 最多5张
        /// </summary>
        [JsonPropertyName("picture_list")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// poi
        /// </summary>
        [JsonPropertyName("poi")]
        public string Poi { get; set; }

        /// <summary>
        /// 场馆主图海报链接
        /// </summary>
        [JsonPropertyName("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 场馆售卖产品类型集合，逗号隔开 calendar：价格日历 ticket：票券 course: 课程
        /// </summary>
        [JsonPropertyName("product_type_list")]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// 省份code
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 子场馆列表
        /// </summary>
        [JsonPropertyName("sub_venue_list")]
        public List<SubVenueQueryInfo> SubVenueList { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonPropertyName("tag_list")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 交通信息
        /// </summary>
        [JsonPropertyName("traffic")]
        public string Traffic { get; set; }

        /// <summary>
        /// 支付宝场馆ID
        /// </summary>
        [JsonPropertyName("venue_id")]
        public string VenueId { get; set; }

        /// <summary>
        /// 场馆商户pid
        /// </summary>
        [JsonPropertyName("venue_pid")]
        public string VenuePid { get; set; }

        /// <summary>
        /// 场馆状态
        /// </summary>
        [JsonPropertyName("venue_status")]
        public string VenueStatus { get; set; }

        /// <summary>
        /// 场馆类型， 01足球；02篮球；03乒乓球；04羽毛球；05台球；06射箭；07哒哒球；08游泳；09网球；10攀岩；11空手道；12跆拳道；14瑜伽；15搏击；16舞蹈；17艺术体操；18太极；19击剑；20水上运动；21滑雪；22健身；23轮滑；24排球；25门球；00其他运动
        /// </summary>
        [JsonPropertyName("venue_type")]
        public List<string> VenueType { get; set; }
    }
}
