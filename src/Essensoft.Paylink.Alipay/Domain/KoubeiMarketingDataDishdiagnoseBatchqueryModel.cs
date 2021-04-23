using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataDishdiagnoseBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataDishdiagnoseBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询菜品类型： *001：明星菜品； *002：潜力菜品； *003：其他菜品（除明星菜品和潜力菜品之外的其他一律作为其他菜品 编号为003）。 *999：查询所有菜品9。 说明：具体值可通过<a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.data.dishdiagnosetype.batchquery">koubei.marketing.data.dishdiagnosetype.batchquery</a>接口查询获得，同时此接口会返回类型及说明。
        /// </summary>
        [JsonPropertyName("item_diagnose_type")]
        public string ItemDiagnoseType { get; set; }

        /// <summary>
        /// 从第一页开始，默认值1
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，不填时默认值为 50。 注意：page_size * page_no 最多为300条，超过后将不再返回数据。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询数据时间，最新为 T-1 即上一日数据。最大保留30天，时间格式为：YYYYMMDD。如20170103。
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }
    }
}
