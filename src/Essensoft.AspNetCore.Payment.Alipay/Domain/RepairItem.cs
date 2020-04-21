using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RepairItem Data Structure.
    /// </summary>
    public class RepairItem : AlipayObject
    {
        /// <summary>
        /// 配件编码
        /// </summary>
        [JsonPropertyName("part_id")]
        public string PartId { get; set; }

        /// <summary>
        /// 支付类型： SELF_PAY("SELF", "自付"), FREE_PAY("FREE", "免费");
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 维修项价格，单位：分
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// L1("L1", "轻度钣金"), L2("L2", "中度钣金"), L3("L3", "重度钣金"), P1("P1", "半喷"), P2("P2", "全喷"), P3("P3", "补漆"), NONE("none", "无"),
        /// </summary>
        [JsonPropertyName("repair_degree")]
        public string RepairDegree { get; set; }

        /// <summary>
        /// R1("R1","喷漆"),  R2("R2","钣金"),  R3("R3","拆装"),  R4("R4","更换"),  R5("R5","电工"),  R6("R6","机修"),  R7("R7","抛光"),  R8("R8","外修"),
        /// </summary>
        [JsonPropertyName("repair_type")]
        public string RepairType { get; set; }
    }
}
