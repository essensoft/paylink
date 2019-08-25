using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditContractBorrowCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditContractBorrowCreateModel : AlipayObject
    {
        /// <summary>
        /// 外部类目,样例：图书馆:BOOK
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 扩展字段，目前留空
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 借书时间，yyyy-MM-dd HH:mm:ss格式的时间字符串
        /// </summary>
        [JsonProperty("gmt_borrow")]
        public string GmtBorrow { get; set; }

        /// <summary>
        /// 应还时间，yyyy-MM-dd HH:mm:ss格式的时间字符串
        /// </summary>
        [JsonProperty("gmt_due")]
        public string GmtDue { get; set; }

        /// <summary>
        /// 商户自定义的外部订单号，需要保障唯一性。
        /// </summary>
        [JsonProperty("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 商户入驻芝麻服务后，得到的服务id，在服务入驻后台可看到
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 借的物品列表，包括每个物品的唯一id，物品类型，物品名称。目前type仅支持book：图书
        /// </summary>
        [JsonProperty("subjects_borrowed")]
        public string SubjectsBorrowed { get; set; }
    }
}
