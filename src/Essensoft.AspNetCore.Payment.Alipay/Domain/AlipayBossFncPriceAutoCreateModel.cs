using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncPriceAutoCreateModel Data Structure.
    /// </summary>
    public class AlipayBossFncPriceAutoCreateModel : AlipayObject
    {
        /// <summary>
        /// 系统名称/开放平台appId
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务单元编码，内部使用
        /// </summary>
        [JsonPropertyName("biz_unit_code")]
        public string BizUnitCode { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("commodity_code")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 商品版本
        /// </summary>
        [JsonPropertyName("commodity_version")]
        public string CommodityVersion { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人域账号
        /// </summary>
        [JsonPropertyName("creator_nm")]
        public string CreatorNm { get; set; }

        /// <summary>
        /// 价格价格失效时间(格式：yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonPropertyName("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 价格生效时间(格式：yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonPropertyName("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 所属机构，目前未ZL6或者ZL7
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 价格申请说明，解释申请原因备注等信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务号，系统根据该字段进行接口幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 价格名称
        /// </summary>
        [JsonPropertyName("price_name")]
        public string PriceName { get; set; }

        /// <summary>
        /// 价格来源
        /// </summary>
        [JsonPropertyName("price_origin")]
        public string PriceOrigin { get; set; }

        /// <summary>
        /// 价格模板ID
        /// </summary>
        [JsonPropertyName("price_tpl_id")]
        public string PriceTplId { get; set; }

        /// <summary>
        /// 价格模板版本，不传默认取最新版本
        /// </summary>
        [JsonPropertyName("price_tpl_version")]
        public string PriceTplVersion { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
