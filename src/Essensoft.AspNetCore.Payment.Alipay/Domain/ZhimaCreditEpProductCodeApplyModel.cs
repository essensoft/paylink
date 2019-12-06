using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpProductCodeApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpProductCodeApplyModel : AlipayObject
    {
        /// <summary>
        /// 申请业务描述
        /// </summary>
        [JsonPropertyName("apply_desc")]
        public string ApplyDesc { get; set; }

        /// <summary>
        /// 申码数量，1-100
        /// </summary>
        [JsonPropertyName("code_num")]
        public long CodeNum { get; set; }

        /// <summary>
        /// 商户一次调用唯一标识，便于后续核对
        /// </summary>
        [JsonPropertyName("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// 聚沙塔定义的产品列表，对接前需要芝麻同学业务同步给商户，列表按逗号分隔，比如同时签约浦发银行和南京银行产品，传入:101_1001_spdb,101_1001_njcb
        /// </summary>
        [JsonPropertyName("product_list")]
        public string ProductList { get; set; }
    }
}
