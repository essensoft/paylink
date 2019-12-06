using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopSummaryQueryResponse Data Structure.
    /// </summary>
    public class ShopSummaryQueryResponse : AlipayObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [JsonPropertyName("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌名，不填写则默认为其它品牌
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 经营时间
        /// </summary>
        [JsonPropertyName("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 门店类目列表
        /// </summary>
        [JsonPropertyName("category_infos")]
        public List<ShopCategoryInfo> CategoryInfos { get; set; }

        /// <summary>
        /// 城市编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// json 字符串表示额外信息;    order_biz_mode: 点餐营业模式, REGULAR-正餐、LIGHT_FAST-轻快餐;  pre_order: 预点餐服务可用状态, 1-服务可用、0-服务不可用  order: 到店点餐服务可用状态：1-服务可用、0-服务不可用
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 门店是否在客户端显示，T表示显示，F表示隐藏
        /// </summary>
        [JsonPropertyName("is_show")]
        public string IsShow { get; set; }

        /// <summary>
        /// 纬度，只有在query_type=KB_PROMOTER非空
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，只有在query_type=KB_PROMOTER非空
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店首图
        /// </summary>
        [JsonPropertyName("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 主门店名
        /// </summary>
        [JsonPropertyName("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 人均价格。单位是分。例如：2000，表示20元
        /// </summary>
        [JsonPropertyName("per_pay")]
        public string PerPay { get; set; }

        /// <summary>
        /// 图片集，是map转化成的json串，key是图片id,value是图片url
        /// </summary>
        [JsonPropertyName("pic_coll")]
        public string PicColl { get; set; }

        /// <summary>
        /// 省份编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店评论信息
        /// </summary>
        [JsonPropertyName("shop_comment_info")]
        public ShopCommentInfo ShopCommentInfo { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// COMMON（普通门店）、MALL（商圈）
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店状态，OPEN：营业中、PAUSE：暂停营业、FREEZE：已冻结、CLOSE:门店已关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
