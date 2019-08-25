using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantshopCommentResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantshopCommentResult : AlipayObject
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 评论时间格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 评论用户的头像url，记录用户评价时头像完整路径
        /// </summary>
        [JsonProperty("face")]
        public string Face { get; set; }

        /// <summary>
        /// 评论晒图，多个逗号分隔。使用车主平台接口上传图片地址。
        /// </summary>
        [JsonProperty("imgs")]
        public string Imgs { get; set; }

        /// <summary>
        /// 评论用户的昵称
        /// </summary>
        [JsonProperty("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 车主平台订单编号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [JsonProperty("reply")]
        public string Reply { get; set; }

        /// <summary>
        /// 回复时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("reply_time")]
        public string ReplyTime { get; set; }

        /// <summary>
        /// 评分， 两位小数
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }

        /// <summary>
        /// 车主平台门店编码
        /// </summary>
        [JsonProperty("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 评论用户支付宝uid
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 评论的用户名称，敏感数据脱敏处理。
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
