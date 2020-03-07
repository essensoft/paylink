using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskIpprofileQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskIpprofileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// IP上用户活跃度分值（分值越高活跃度越高）
        /// </summary>
        [JsonPropertyName("ip_active_score")]
        public string IpActiveScore { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// IP对应AS描述
        /// </summary>
        [JsonPropertyName("ip_as_name")]
        public string IpAsName { get; set; }

        /// <summary>
        /// ip对应AS号
        /// </summary>
        [JsonPropertyName("ip_asn")]
        public string IpAsn { get; set; }

        /// <summary>
        /// IP归属运营商所属市
        /// </summary>
        [JsonPropertyName("ip_carrier_city")]
        public string IpCarrierCity { get; set; }

        /// <summary>
        /// IP归属运营商所属区县
        /// </summary>
        [JsonPropertyName("ip_carrier_district")]
        public string IpCarrierDistrict { get; set; }

        /// <summary>
        /// IP归属运营商所属省
        /// </summary>
        [JsonPropertyName("ip_carrier_province")]
        public string IpCarrierProvince { get; set; }

        /// <summary>
        /// 真实使用地所在市
        /// </summary>
        [JsonPropertyName("ip_gps_city")]
        public string IpGpsCity { get; set; }

        /// <summary>
        /// 真实使用地所在区县
        /// </summary>
        [JsonPropertyName("ip_gps_district")]
        public string IpGpsDistrict { get; set; }

        /// <summary>
        /// 真实使用地所在省
        /// </summary>
        [JsonPropertyName("ip_gps_province")]
        public string IpGpsProvince { get; set; }

        /// <summary>
        /// IP最大概率经纬度点的纬度
        /// </summary>
        [JsonPropertyName("ip_latitude")]
        public string IpLatitude { get; set; }

        /// <summary>
        /// IP最大概率经纬度点的经度
        /// </summary>
        [JsonPropertyName("ip_longitude")]
        public string IpLongitude { get; set; }

        /// <summary>
        /// IP所属网段
        /// </summary>
        [JsonPropertyName("ip_net_id")]
        public string IpNetId { get; set; }

        /// <summary>
        /// IP非人操作分值（分值越高非人概率越高）
        /// </summary>
        [JsonPropertyName("ip_not_human_score")]
        public string IpNotHumanScore { get; set; }

        /// <summary>
        /// IP运营商名称
        /// </summary>
        [JsonPropertyName("ip_opt_desc")]
        public string IpOptDesc { get; set; }

        /// <summary>
        /// 近三个月是否发生过案件
        /// </summary>
        [JsonPropertyName("is_case_threemonth")]
        public string IsCaseThreemonth { get; set; }

        /// <summary>
        /// 是否3G/4G等基站类IP
        /// </summary>
        [JsonPropertyName("is_cellular_ip")]
        public string IsCellularIp { get; set; }

        /// <summary>
        /// 是否教育网IP
        /// </summary>
        [JsonPropertyName("is_edu_ip")]
        public string IsEduIp { get; set; }

        /// <summary>
        /// 是否IDCIP
        /// </summary>
        [JsonPropertyName("is_idc_ip")]
        public string IsIdcIp { get; set; }

        /// <summary>
        /// 是否境外IP
        /// </summary>
        [JsonPropertyName("is_oversea_ip")]
        public string IsOverseaIp { get; set; }

        /// <summary>
        /// 是否代理IP
        /// </summary>
        [JsonPropertyName("is_proxy_ip")]
        public string IsProxyIp { get; set; }

        /// <summary>
        /// 自然人主体使用当前IP的概率
        /// </summary>
        [JsonPropertyName("net_cert_ratio")]
        public string NetCertRatio { get; set; }

        /// <summary>
        /// 该城市使用当前IP的概率
        /// </summary>
        [JsonPropertyName("net_city_ratio")]
        public string NetCityRatio { get; set; }

        /// <summary>
        /// 该区使用当前IP的概率
        /// </summary>
        [JsonPropertyName("net_district_ratio")]
        public string NetDistrictRatio { get; set; }

        /// <summary>
        /// 手机号持有人使用当前IP的概率
        /// </summary>
        [JsonPropertyName("net_phone_ratio")]
        public string NetPhoneRatio { get; set; }

        /// <summary>
        /// 用户使用当前IP的概率综合分
        /// </summary>
        [JsonPropertyName("net_ratio_norm")]
        public string NetRatioNorm { get; set; }

        /// <summary>
        /// 风险码，比如 r_ip_004 表示 ip近期不活跃，r_ip_005表示ip较新，r_ip_006表示ip上聚集多个设备，r_ip_007表示设备分布异常；
        /// </summary>
        [JsonPropertyName("riskcode")]
        public List<string> Riskcode { get; set; }

        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// IP使用时间类型
        /// </summary>
        [JsonPropertyName("usage_time_type")]
        public string UsageTimeType { get; set; }

        /// <summary>
        /// IP上近半年的活跃用户数
        /// </summary>
        [JsonPropertyName("user_cnt_halfyear")]
        public string UserCntHalfyear { get; set; }

        /// <summary>
        /// IP上周活跃平均用户数
        /// </summary>
        [JsonPropertyName("user_cnt_weekavg")]
        public string UserCntWeekavg { get; set; }

        /// <summary>
        /// IP上周用户数波动指数
        /// </summary>
        [JsonPropertyName("user_cnt_weekstddev")]
        public string UserCntWeekstddev { get; set; }

        /// <summary>
        /// IP上活跃用户的稳定指数
        /// </summary>
        [JsonPropertyName("user_stability")]
        public string UserStability { get; set; }
    }
}
