using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantshopCommentResult Data Structure.
    /// </summary>
    public class MerchantshopCommentResult : AlipayObject
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 评论时间格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 评论用户的头像url，记录用户评价时头像完整路径
        /// </summary>
        [JsonPropertyName("face")]
        public string Face { get; set; }

        /// <summary>
        /// 评论晒图，多个逗号分隔。使用车主平台接口上传图片地址。
        /// </summary>
        [JsonPropertyName("imgs")]
        public string Imgs { get; set; }

        /// <summary>
        /// 评论用户的昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 车主平台订单编号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [JsonPropertyName("reply")]
        public string Reply { get; set; }

        /// <summary>
        /// 回复时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("reply_time")]
        public string ReplyTime { get; set; }

        /// <summary>
        /// 评分， 两位小数
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 车主平台门店编码
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 评论用户支付宝uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 评论的用户名称，敏感数据脱敏处理。
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
