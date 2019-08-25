using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelPromotionGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelPromotionGetModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁LBS基础设施定义的商圈码列表
        /// </summary>
        [JsonProperty("biz_area_codes")]
        public List<string> BizAreaCodes { get; set; }

        /// <summary>
        /// 多端统一渠道信息，与服务提供方协商分配，为空则默认取appId
        /// </summary>
        [JsonProperty("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 蚂蚁LBS基础设施定义的城市码列表
        /// </summary>
        [JsonProperty("city_codes")]
        public List<string> CityCodes { get; set; }

        /// <summary>
        /// ISO-3166标准三位数据国家码列表
        /// </summary>
        [JsonProperty("country_codes")]
        public List<string> CountryCodes { get; set; }

        /// <summary>
        /// 纬度，double类型，有效区间[-90, 90]
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地理位置反查级别枚举：支持国家（COUNTRY）、城市（CITY）、商圈（BIZ_AREA），表示从指定级别开始向上级反查，直到定位成功。默认：商圈（BIZ_AREA）
        /// </summary>
        [JsonProperty("lbs_reverse_level")]
        public string LbsReverseLevel { get; set; }

        /// <summary>
        /// 经度，double类型，有效区间[-180, 180]
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 分页数，从1开始，默认为1
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，最小为1，默认为3
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 搜索半径，与经纬度配合使用，单独传递无效。单位：米，默认不指定
        /// </summary>
        [JsonProperty("radius")]
        public long Radius { get; set; }

        /// <summary>
        /// 优惠推荐的场景码，通过此字段识别不同的业务场景，不同场景依赖的参数不同，且有不同的推荐策略。可选值：COMMON_RECOMMEND（默认场景，常规推荐，支持区域码等大多数参数）；SHOP_PROMO_LIST（店铺优惠列表，仅且必须接受shop_id参数）。
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 店铺id，当scene_code=SHOP_PROMO_LIST时，此字段必填
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 置顶券id列表，该列表中的券将被置顶返回，顺序与入参顺序一致，如果券状态非法，则默认丢弃
        /// </summary>
        [JsonProperty("top_promotion_ids")]
        public List<string> TopPromotionIds { get; set; }

        /// <summary>
        /// 请求唯一id，只能是大小写字母及数字。不带业务含义，可以由uuid等随机生成，用于唯一标识一笔业务，方便与外部排查问题
        /// </summary>
        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 用户id，与user_id_type配合使用，暂时仅支持集团havanaId和支付宝2088开头的16位数字ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id类型枚举，与user_id配合使用。取值说明：HAVANA为集团havanaId，ALIPAY为支付宝2088开头16位用户id
        /// </summary>
        [JsonProperty("user_id_type")]
        public string UserIdType { get; set; }
    }
}
