using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketCommodityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 热点URL
        /// </summary>
        [JsonPropertyName("app_hot_logo")]
        public string AppHotLogo { get; set; }

        /// <summary>
        /// 插件服务审核备注
        /// </summary>
        [JsonPropertyName("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 授权文件url
        /// </summary>
        [JsonPropertyName("authorization_file")]
        public string AuthorizationFile { get; set; }

        /// <summary>
        /// 插件应用类型
        /// </summary>
        [JsonPropertyName("biz_type_code")]
        public string BizTypeCode { get; set; }

        /// <summary>
        /// CARLIFE("车主服务", "001"),  MEDICALCARE("医疗服务", "003"),  CITYSERVICE("城市服务", "004"),  MOBILE_OPERATOR("运营商服务", "005");
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 服务归属  0-自主开发  1-委托开发者
        /// </summary>
        [JsonPropertyName("commodity_affiliation")]
        public string CommodityAffiliation { get; set; }

        /// <summary>
        /// 服务插件id
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务商联系人
        /// </summary>
        [JsonPropertyName("contactor")]
        public string Contactor { get; set; }

        /// <summary>
        /// 服务创建时间
        /// </summary>
        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 服务logo地址
        /// </summary>
        [JsonPropertyName("log_url")]
        public string LogUrl { get; set; }

        /// <summary>
        /// 移动端服务配置地址
        /// </summary>
        [JsonPropertyName("mobile_visiturl")]
        public string MobileVisiturl { get; set; }

        /// <summary>
        /// 服务创建者名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务商联系人手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// ONLINE-已上架  OFFLINE-待上架  AUDIT-审核中  AUDIT_REJECT-审核拒绝  AUDIT_OFFLINE-已下架
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 0表示BD不可审核   1表示BD可以审核
        /// </summary>
        [JsonPropertyName("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 服务插件相关描述信息
        /// </summary>
        [JsonPropertyName("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// 应用验收说明
        /// </summary>
        [JsonPropertyName("test_detail")]
        public string TestDetail { get; set; }

        /// <summary>
        /// 压力测试报告url
        /// </summary>
        [JsonPropertyName("test_report")]
        public string TestReport { get; set; }

        /// <summary>
        /// 服务插件名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户指南url
        /// </summary>
        [JsonPropertyName("user_guide")]
        public string UserGuide { get; set; }

        /// <summary>
        /// 服务创建者ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
