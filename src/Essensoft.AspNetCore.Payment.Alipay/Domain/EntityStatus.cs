using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EntityStatus Data Structure.
    /// </summary>
    public class EntityStatus : AlipayObject
    {
        /// <summary>
        /// 安卓是否可借
        /// </summary>
        [JsonPropertyName("android_can_borrow")]
        public bool AndroidCanBorrow { get; set; }

        /// <summary>
        /// 安卓可借用个数
        /// </summary>
        [JsonPropertyName("android_can_borrow_cnt")]
        public string AndroidCanBorrowCnt { get; set; }

        /// <summary>
        /// 是否可借
        /// </summary>
        [JsonPropertyName("can_borrow")]
        public bool CanBorrow { get; set; }

        /// <summary>
        /// 可借用个数
        /// </summary>
        [JsonPropertyName("can_borrow_cnt")]
        public string CanBorrowCnt { get; set; }

        /// <summary>
        /// 是否可还 true,false,null(未知)
        /// </summary>
        [JsonPropertyName("can_restore")]
        public bool CanRestore { get; set; }

        /// <summary>
        /// 可还个数(可空),null表示未知,0表示可还0
        /// </summary>
        [JsonPropertyName("can_restore_cnt")]
        public string CanRestoreCnt { get; set; }

        /// <summary>
        /// 苹果是否可借
        /// </summary>
        [JsonPropertyName("ios_can_borrow")]
        public bool IosCanBorrow { get; set; }

        /// <summary>
        /// 苹果可借用个数
        /// </summary>
        [JsonPropertyName("ios_can_borrow_cnt")]
        public string IosCanBorrowCnt { get; set; }

        /// <summary>
        /// 当前是否开业(比如节假日或者临时有事,在固定的营业时间内,但是商户临时歇业了)
        /// </summary>
        [JsonPropertyName("is_opening")]
        public bool IsOpening { get; set; }

        /// <summary>
        /// typec是否可借
        /// </summary>
        [JsonPropertyName("typec_can_borrow")]
        public bool TypecCanBorrow { get; set; }

        /// <summary>
        /// typec可借用个数
        /// </summary>
        [JsonPropertyName("typec_can_borrow_cnt")]
        public string TypecCanBorrowCnt { get; set; }
    }
}
