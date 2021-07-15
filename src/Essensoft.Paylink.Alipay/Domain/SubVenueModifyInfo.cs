using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SubVenueModifyInfo Data Structure.
    /// </summary>
    public class SubVenueModifyInfo : AlipayObject
    {
        /// <summary>
        /// 入场要求
        /// </summary>
        [JsonPropertyName("admission_requirement")]
        public string AdmissionRequirement { get; set; }

        /// <summary>
        /// 公告
        /// </summary>
        [JsonPropertyName("announcement")]
        public string Announcement { get; set; }

        /// <summary>
        /// 是否可预定 Y/N （不传默认为可预定）
        /// </summary>
        [JsonPropertyName("bookable")]
        public string Bookable { get; set; }

        /// <summary>
        /// 场馆介绍
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 器材租赁信息
        /// </summary>
        [JsonPropertyName("equipment_rental")]
        public string EquipmentRental { get; set; }

        /// <summary>
        /// 场馆设置：1地板、2灯光、3淋浴、4餐饮、5WiFi ,6更衣室
        /// </summary>
        [JsonPropertyName("facility_list")]
        public List<long> FacilityList { get; set; }

        /// <summary>
        /// 场馆名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 营业时间，不传用主场馆的
        /// </summary>
        [JsonPropertyName("opening_hours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// 操作类型：1. 新入驻，2.修改已入驻
        /// </summary>
        [JsonPropertyName("opt_type")]
        public string OptType { get; set; }

        /// <summary>
        /// 服务商场馆ID
        /// </summary>
        [JsonPropertyName("out_sub_venue_id")]
        public string OutSubVenueId { get; set; }

        /// <summary>
        /// 收款方支付宝账户(payment_method为account或空值时必传)
        /// </summary>
        [JsonPropertyName("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款方式  account：通过支付宝账号收款  smid：通过smid收款
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 收款方式（间连/直连）
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 联系电话，多个逗号隔开，不传用主场馆的
        /// </summary>
        [JsonPropertyName("phone")]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 场馆图片编码列表 最多5张，逗号隔开 图片要求参考场馆主图
        /// </summary>
        [JsonPropertyName("picture_list")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// 场馆主图海报图片的Base64编码 （注：1.图片的格式必须是jpg的；2.图片大小不超过125KB；3.非Data URI格式，请直接填写原文件的base64编码）
        /// </summary>
        [JsonPropertyName("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 场馆售卖产品类型集合，逗号隔开 calendar：价格日历 ticket：票券 course: 课程
        /// </summary>
        [JsonPropertyName("product_type_list")]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// 促销信息
        /// </summary>
        [JsonPropertyName("promotion")]
        public string Promotion { get; set; }

        /// <summary>
        /// 变更状态，online/offline
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝场馆ID，新入驻可不传，修改已入驻必传
        /// </summary>
        [JsonPropertyName("sub_venue_id")]
        public string SubVenueId { get; set; }

        /// <summary>
        /// 子场馆pid(payment_method为smid时必传)
        /// </summary>
        [JsonPropertyName("sub_venue_pid")]
        public string SubVenuePid { get; set; }

        /// <summary>
        /// 子场馆商户二级smid（payment_method为smid时必传）
        /// </summary>
        [JsonPropertyName("sub_venue_smid")]
        public string SubVenueSmid { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonPropertyName("tag_list")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 培训信息
        /// </summary>
        [JsonPropertyName("training")]
        public string Training { get; set; }

        /// <summary>
        /// 场馆类型， 01足球；02篮球；03乒乓球；04羽毛球；05台球；06射箭；07哒哒球；08游泳；09网球；10攀岩；11空手道；12跆拳道；14瑜伽；15搏击；16舞蹈；17艺术体操；18太极；19击剑；20水上运动；21滑雪；22健身；23轮滑；24排球；25门球；00其他运动
        /// </summary>
        [JsonPropertyName("venue_type")]
        public string VenueType { get; set; }

        /// <summary>
        /// 会员卡信息
        /// </summary>
        [JsonPropertyName("vip")]
        public string Vip { get; set; }
    }
}
