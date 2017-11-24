using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ProductProvider Data Structure.
    /// </summary>
    public class ProductProvider : AlipayObject
    {
        /// <summary>
        /// 卡代英文名称 备注:淘宝交易为空
        /// </summary>
        [JsonProperty("agency")]
        public string Agency { get; set; }

        /// <summary>
        /// 卡代中文名称 备注：淘宝交易为空
        /// </summary>
        [JsonProperty("agency_name")]
        public string AgencyName { get; set; }

        /// <summary>
        /// 业务 类型
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 充值产品主表ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 子运营商英文名称 备注:淘宝交易为空
        /// </summary>
        [JsonProperty("sub_operator")]
        public string SubOperator { get; set; }

        /// <summary>
        /// 子运营商中文名称 ,如浙江移动
        /// </summary>
        [JsonProperty("sub_operator_name")]
        public string SubOperatorName { get; set; }
    }
}
