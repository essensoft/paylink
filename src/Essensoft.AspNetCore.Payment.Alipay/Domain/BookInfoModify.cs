using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BookInfoModify Data Structure.
    /// </summary>
    public class BookInfoModify : AlipayObject
    {
        /// <summary>
        /// 订座桌台位置。如LOBBY表示大厅；如BOX表示包厢。
        /// </summary>
        [JsonPropertyName("book_table_position")]
        public string BookTablePosition { get; set; }

        /// <summary>
        /// 订座确认超时时间。标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("book_timeout")]
        public string BookTimeout { get; set; }
    }
}
