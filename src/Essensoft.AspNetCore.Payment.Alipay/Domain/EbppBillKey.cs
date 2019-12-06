using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EbppBillKey Data Structure.
    /// </summary>
    public class EbppBillKey : AlipayObject
    {
        /// <summary>
        /// 户号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型缩写:  JF-缴费
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构缩写
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 脱敏的户主姓名
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 子业务类型英文名称:  ELECTRIC-电力  GAS-燃气  WATER-水
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
