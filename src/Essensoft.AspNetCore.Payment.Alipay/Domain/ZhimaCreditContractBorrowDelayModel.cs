using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditContractBorrowDelayModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditContractBorrowDelayModel : AlipayObject
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
        /// 商户的外部订单号
        /// </summary>
        [JsonProperty("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 商户入驻芝麻服务后，得到的服务id，在服务入驻后台可看到
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 延期的物品列表，包括每本书的唯一id，物品类型，物品名称，以及该物品原本所属的外部订单号
        /// </summary>
        [JsonProperty("subjects_delayed")]
        public string SubjectsDelayed { get; set; }
    }
}
