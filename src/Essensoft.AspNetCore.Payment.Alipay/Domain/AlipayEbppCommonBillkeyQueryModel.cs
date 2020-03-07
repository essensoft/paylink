using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommonBillkeyQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppCommonBillkeyQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型缩写：  JF-缴费
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构缩写, 多个出账机构请用分隔符英文逗号(,)隔开（多出账机构传入的上限限制为200个，出账机构支持输入归属机构）
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 子业务类型英文名称:  ELECTRIC-电力  GAS-燃气  WATER-水
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
