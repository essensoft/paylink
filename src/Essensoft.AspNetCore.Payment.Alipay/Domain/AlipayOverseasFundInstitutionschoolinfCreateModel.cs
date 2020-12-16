using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasFundInstitutionschoolinfCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasFundInstitutionschoolinfCreateModel : AlipayObject
    {
        /// <summary>
        /// 必填，必须是行业属性代码表中存在的最细分类的记录。
        /// </summary>
        [JsonPropertyName("attr_code")]
        public string AttrCode { get; set; }

        /// <summary>
        /// 必填，必须是行政区划表中存在的记录，但不能选100000。
        /// </summary>
        [JsonPropertyName("bussess_adr")]
        public string BussessAdr { get; set; }

        /// <summary>
        /// 城市的国家编码（国家统计局出版的行政区划代码 http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/）
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 必填，字母代码，必须是国别/地区代码表中存在的记录。如果100、200、300项下的任何一项，则常驻国家地区应为中国CHN。如果经济类型选择400，则常驻国家地区为外国、中国港澳台地区或国际组（IOS）。
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 交易主体---02-金融机构 03-中资机构 04-外资机构
        /// </summary>
        [JsonPropertyName("cust_type")]
        public string CustType { get; set; }

        /// <summary>
        /// 申报方式--因银行只能通过银行版为企业开通网上申报并打印初始密码等信息，故银行版接口导入程序仅对此项进行格式检查，不改变银行版中单位基本情况表的申报方式。
        /// </summary>
        [JsonPropertyName("declare_type")]
        public string DeclareType { get; set; }

        /// <summary>
        /// 区县的国家编码（国家统计局出版的行政区划代码 http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/）
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 经济类型代码,必须是经济类型代码表中存在的最细分类的记录
        /// </summary>
        [JsonPropertyName("economy_type_code")]
        public string EconomyTypeCode { get; set; }

        /// <summary>
        /// 扩展字段格式为：json
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 字母代码，必须是国别/地区代码表中存在的记录；  外方投资者国别不能选择中国。  如果经济类型为200项下，则外方投资者国别中至少有港澳台之一，不能为空；  如果经济类型选择300项下，则外方投资者国别中不能为空，至少一项为外国（中国大陆及港澳台除外）；  如果经济类型选择400，外方投资者国别必须为空。
        /// </summary>
        [JsonPropertyName("investment_country_code_one")]
        public string InvestmentCountryCodeOne { get; set; }

        /// <summary>
        /// 是否特殊经济区内企业,N-非特殊经济区内企业 Y-特殊经济区内企业
        /// </summary>
        [JsonPropertyName("is_special_economic_zone")]
        public string IsSpecialEconomicZone { get; set; }

        /// <summary>
        /// ISV公司名称
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// ISV的联系方式
        /// </summary>
        [JsonPropertyName("isv_phone")]
        public string IsvPhone { get; set; }

        /// <summary>
        /// isv请求号
        /// </summary>
        [JsonPropertyName("isv_request_no")]
        public string IsvRequestNo { get; set; }

        /// <summary>
        /// 学校联系人姓名
        /// </summary>
        [JsonPropertyName("link_man_name")]
        public string LinkManName { get; set; }

        /// <summary>
        /// 学校联系电话
        /// </summary>
        [JsonPropertyName("link_phone")]
        public string LinkPhone { get; set; }

        /// <summary>
        /// 组织机构英文名称和单位地址（英文）两个字段的长度加总不能超过130个字符
        /// </summary>
        [JsonPropertyName("office_adr_en")]
        public string OfficeAdrEn { get; set; }

        /// <summary>
        /// 英文名称可填特殊机构代码赋码通知书上载明名称，不应包含全角字符。
        /// </summary>
        [JsonPropertyName("org_name_en")]
        public string OrgNameEn { get; set; }

        /// <summary>
        /// 机关/事业单位/企业/社会团体/军队武警、境外机构、驻华使领馆等特殊机构/其他组织机构，见机构类型代码表 本列填写CODE码
        /// </summary>
        [JsonPropertyName("org_type")]
        public string OrgType { get; set; }

        /// <summary>
        /// 省份的国家编码（国家统计局出版的行政区划代码 http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/）
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 开户描述信息
        /// </summary>
        [JsonPropertyName("remark_info")]
        public string RemarkInfo { get; set; }

        /// <summary>
        /// 学校详细地址
        /// </summary>
        [JsonPropertyName("school_address")]
        public string SchoolAddress { get; set; }

        /// <summary>
        /// 学校所在的国家编码ISO2位标准
        /// </summary>
        [JsonPropertyName("school_country")]
        public string SchoolCountry { get; set; }

        /// <summary>
        /// 学校英文名称
        /// </summary>
        [JsonPropertyName("school_en_name")]
        public string SchoolEnName { get; set; }

        /// <summary>
        /// 学校的校徽或logo，在学校展示页面作为学校的标识。该字段为图片的链接地址，只支持png或jpg图片格式，图片高度为108，宽度为108 ，不大于20k。 注意：此链接要求公网可以访问，否则无法正常展示。
        /// </summary>
        [JsonPropertyName("school_icon")]
        public string SchoolIcon { get; set; }

        /// <summary>
        /// 如果填写了school_icon参数，则此字段不能为空。目前只支持png和jpg两种格式
        /// </summary>
        [JsonPropertyName("school_icon_type")]
        public string SchoolIconType { get; set; }

        /// <summary>
        /// 行业类别标识符
        /// </summary>
        [JsonPropertyName("school_mcc")]
        public string SchoolMcc { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校签约支付宝教育缴费支付宝pid
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学校(机构)标识码（由教育部按照国家标准及编码规则编制，可以在教育局官网查询）
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 学校的类型： 1：代表托儿所； 2：代表幼儿园；3：代表小学；4：代表初中；5：代表高中；6:大学;9：国际。10：涉外培训机构。 如果学校兼有多种属性，可以连写，比如： 45：代表兼有初中部高中部；34：代表兼有小学部初中部；
        /// </summary>
        [JsonPropertyName("school_type")]
        public string SchoolType { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [JsonPropertyName("school_zipcode")]
        public string SchoolZipcode { get; set; }

        /// <summary>
        /// 如果“是否特殊经济区内企业”选择“否”，则本项选择“一般贸易区”或“自由贸易试验区（非特殊监管）”；  如果“是否特殊经济区内企业”选择“是”，且企业为非自由贸易试验区的特殊经济区内企业，本项选择“保税区”、“出口加工区”、“保税物流中心B型”、“保税物流园区”、“钻石交易所”、“保税港区”、“综合保税区”、“跨境工业园区”、“保税物流中心A型”、“出口监管仓库”、“进口保税仓库”、或“其他”；  如果“是否特殊经济区内企业”选择“是”，且企业为自由贸易试验区的特殊经济区内企业，本项选择“自由贸易试验区（特殊监管）”。  注：是否企业为自由贸易试验区的特殊经济区内企业，人工判断
        /// </summary>
        [JsonPropertyName("special_economic_zone_company_type")]
        public string SpecialEconomicZoneCompanyType { get; set; }

        /// <summary>
        /// 交易用eMail
        /// </summary>
        [JsonPropertyName("trans_email")]
        public string TransEmail { get; set; }
    }
}
