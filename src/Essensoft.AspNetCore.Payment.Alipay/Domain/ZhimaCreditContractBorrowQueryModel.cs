using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditContractBorrowQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditContractBorrowQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部类目,样例：图书馆:BOOK
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 扩展字段，目前留空
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 商户自定义的外部订单号
        /// </summary>
        [JsonPropertyName("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 商户入驻芝麻服务后，得到的服务id，在服务入驻后台可看到
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
