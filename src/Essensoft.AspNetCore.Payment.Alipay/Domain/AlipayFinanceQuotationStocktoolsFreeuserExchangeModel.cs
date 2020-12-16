using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationStocktoolsFreeuserExchangeModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationStocktoolsFreeuserExchangeModel : AlipayObject
    {
        /// <summary>
        /// 股票工具供应商机构的配置ID，通常是XXZQ（XX证券），具体值待定。用途：1.确定购买的产品的供应商（用户购买的工具一定是属于某一家供应商的）。2.来源有效性校验。对应的PID与inst_org_id要能一一对应。
        /// </summary>
        [JsonPropertyName("inst_org_id")]
        public string InstOrgId { get; set; }

        /// <summary>
        /// 股票工具的类型。每个机构提供的工具会有特定的类型名称。查询时也需要提供类型才可定位到用户是否已经订阅。
        /// </summary>
        [JsonPropertyName("tool_type")]
        public string ToolType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
