using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderSignModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderSignModel : AlipayObject
    {
        /// <summary>
        /// 主营类目 风控需要字段
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 到期类型:  LONG_TERM_EFFECT 长期 SHORT_TERM_EFFECT 短期
        /// </summary>
        [JsonPropertyName("due_type")]
        public string DueType { get; set; }

        /// <summary>
        /// 来源应用
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 预期失效日期 格式：yyyy-MM-dd HH:mm:ss 短期到期类型：必须传入失效时间 长期到期类型：忽略传入的失效时间
        /// </summary>
        [JsonPropertyName("inactive_datetime")]
        public string InactiveDatetime { get; set; }

        /// <summary>
        /// 行业 风控与合约中心需要场景字段
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 订购渠道
        /// </summary>
        [JsonPropertyName("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 订购编码
        /// </summary>
        [JsonPropertyName("ordered_system_code")]
        public string OrderedSystemCode { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [JsonPropertyName("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 商家支付宝账号
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺类型： 个人店铺：personal  企业店铺：ent
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 签约场景： 千牛侧花呗签约场景：TAOBAO_TRADE 风控需要场景字段
        /// </summary>
        [JsonPropertyName("sign_scene")]
        public string SignScene { get; set; }
    }
}
