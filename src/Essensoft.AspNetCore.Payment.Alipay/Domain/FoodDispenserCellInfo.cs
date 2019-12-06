using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FoodDispenserCellInfo Data Structure.
    /// </summary>
    public class FoodDispenserCellInfo : AlipayObject
    {
        /// <summary>
        /// 业务状态  空闲：IDLE  预占：FREEZE  占用：OCCUPIED
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 单元格编号
        /// </summary>
        [JsonPropertyName("cell_code")]
        public string CellCode { get; set; }

        /// <summary>
        /// 单元格名称
        /// </summary>
        [JsonPropertyName("cell_name")]
        public string CellName { get; set; }

        /// <summary>
        /// 列数
        /// </summary>
        [JsonPropertyName("column_no")]
        public string ColumnNo { get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        [JsonPropertyName("row_no")]
        public string RowNo { get; set; }
    }
}
