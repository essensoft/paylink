using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskDirectionalIpprofileQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskDirectionalIpprofileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// IP地址
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

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
        /// IP最大概率经纬度点的纬度。统计ip使用地域出现概率最高的经纬度值，属性描述纬度
        /// </summary>
        [JsonPropertyName("ip_latitude")]
        public string IpLatitude { get; set; }

        /// <summary>
        /// IP最大概率经纬度点的经度。统计ip使用地域出现概率最高的经纬度值，属性描述经度
        /// </summary>
        [JsonPropertyName("ip_longitude")]
        public string IpLongitude { get; set; }

        /// <summary>
        /// 近三个月是否发生过案件,0：否；1：是
        /// </summary>
        [JsonPropertyName("is_case_threemonth")]
        public string IsCaseThreemonth { get; set; }

        /// <summary>
        /// 是否3G/4G等基站类IP,0：否；1：是
        /// </summary>
        [JsonPropertyName("is_cellular_ip")]
        public string IsCellularIp { get; set; }

        /// <summary>
        /// 是否教育网IP,0：否；1：是
        /// </summary>
        [JsonPropertyName("is_edu_ip")]
        public string IsEduIp { get; set; }

        /// <summary>
        /// 是否IDCIP,0：否；1：是
        /// </summary>
        [JsonPropertyName("is_idc_ip")]
        public string IsIdcIp { get; set; }

        /// <summary>
        /// 是否境外IP，0：否；1：是
        /// </summary>
        [JsonPropertyName("is_oversea_ip")]
        public string IsOverseaIp { get; set; }

        /// <summary>
        /// 是否代理IP,0：否；1：是
        /// </summary>
        [JsonPropertyName("is_proxy_ip")]
        public string IsProxyIp { get; set; }

        /// <summary>
        /// 身份证持有人使用当前IP的概率，取值范围：0 ~ 1，值越大概率越大
        /// </summary>
        [JsonPropertyName("net_cert_ratio")]
        public string NetCertRatio { get; set; }

        /// <summary>
        /// 手机号持有人使用当前IP的概率，取值范围：0 ~ 1，值越大概率越大
        /// </summary>
        [JsonPropertyName("net_phone_ratio")]
        public string NetPhoneRatio { get; set; }

        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// IP使用时间类型，枚举类型，如：corp:工作类, life：家庭类, NA：未知
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
        /// IP上周用户数波动指数, 取值范围：0 ~ 1，值越大波动越大
        /// </summary>
        [JsonPropertyName("user_cnt_weekstddev")]
        public string UserCntWeekstddev { get; set; }

        /// <summary>
        /// IP上活跃用户的稳定指数，取值范围：0 ~ 1，越大越稳定
        /// </summary>
        [JsonPropertyName("user_stability")]
        public string UserStability { get; set; }
    }
}
