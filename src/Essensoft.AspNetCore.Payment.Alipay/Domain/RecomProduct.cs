using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecomProduct Data Structure.
    /// </summary>
    public class RecomProduct : AlipayObject
    {
        /// <summary>
        /// 裸价
        /// </summary>
        [JsonPropertyName("base_premium")]
        public long BasePremium { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 保险公司淘宝卖家ID
        /// </summary>
        [JsonPropertyName("company_seller_id")]
        public string CompanySellerId { get; set; }

        /// <summary>
        /// 保险公司淘宝店铺名称
        /// </summary>
        [JsonPropertyName("company_seller_nick")]
        public string CompanySellerNick { get; set; }

        /// <summary>
        /// 保险公司服务电话
        /// </summary>
        [JsonPropertyName("company_service_phone")]
        public string CompanyServicePhone { get; set; }

        /// <summary>
        /// 产品销售单元
        /// </summary>
        [JsonPropertyName("csu_no")]
        public string CsuNo { get; set; }

        /// <summary>
        /// 最大允许购买份数
        /// </summary>
        [JsonPropertyName("max_quan")]
        public long MaxQuan { get; set; }

        /// <summary>
        /// 推荐产品展示名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推荐方案列表
        /// </summary>
        [JsonPropertyName("plans")]
        public RecomPlan Plans { get; set; }

        /// <summary>
        /// 推荐返回保费，单位分
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 推荐产品ID
        /// </summary>
        [JsonPropertyName("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 产品资源项列表，可以平行扩展多个资源项
        /// </summary>
        [JsonPropertyName("resource_list")]
        public List<ProdResource> ResourceList { get; set; }

        /// <summary>
        /// 产品资源项列表
        /// </summary>
        [JsonPropertyName("resources")]
        public ProdResource Resources { get; set; }

        /// <summary>
        /// 按订单维度限购
        /// </summary>
        [JsonPropertyName("restriction_type")]
        public string RestrictionType { get; set; }

        /// <summary>
        /// 保额(单位:分)
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 推荐返回结果对象：1：保险产品，2：保险权益
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
