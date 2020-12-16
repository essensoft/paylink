using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseBcMsgSendModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseBcMsgSendModel : AlipayObject
    {
        /// <summary>
        /// BC消息，收到消息的客户端的最低版本号，如收到消息的最低版本低于该字段，怎客户端不会收到消息
        /// </summary>
        [JsonPropertyName("app_min_version")]
        public string AppMinVersion { get; set; }

        /// <summary>
        /// 所属应用ID，目前仅用于统计
        /// </summary>
        [JsonPropertyName("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 业务附加信息字段
        /// </summary>
        [JsonPropertyName("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// BC消息内容的简短描述，如可用与客户端聊天列表盒子上的展示，具体使用方式业务方可根据自身业务决定
        /// </summary>
        [JsonPropertyName("biz_memo")]
        public string BizMemo { get; set; }

        /// <summary>
        /// 业务类型，接入时由社交侧分配
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 消息发送渠道，为空则默认为BUSINESS，枚举： 业务消息：BUSINESS 营销消息：MARKETING
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// BC互动发消息的唯一ID,不可为空，防止消息重复发送，请用reltionType+业务主键控制唯一
        /// </summary>
        [JsonPropertyName("client_msg_id")]
        public string ClientMsgId { get; set; }

        /// <summary>
        /// BC互动，C端帐号，如C端在支付宝内则为支付宝统一用户id
        /// </summary>
        [JsonPropertyName("consumer_user_id")]
        public string ConsumerUserId { get; set; }

        /// <summary>
        /// 消息隐藏方案，默认不隐藏 例如 ：A给B发消息 (空): 不隐藏，A看到一条上行消息，B看到一条下行消息(消息内容完全一样，如果需要两边看到的消息不同，需要发两条消息，一条上行隐藏，一条下行隐藏) (1): 上行隐藏，A给B发消息，A看不到消息，B看到消息 (0): 下行隐藏，A给B发消息，A看到消息，B看不到消息
        /// </summary>
        [JsonPropertyName("hidden_side")]
        public string HiddenSide { get; set; }

        /// <summary>
        /// 消息点击后可跳转的地址,由业务方指定，为整个卡片的点击时间，默认为空，点击无反应
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// BC消息，标记是否已读，默认为未读，设置未读时客户端会有红点或数字提示有未读消息
        /// </summary>
        [JsonPropertyName("mark_read")]
        public bool MarkRead { get; set; }

        /// <summary>
        /// BC互动，B端帐号，为业务方内部标识唯一B端帐号的id，如B端为商家，则为商家唯一ID
        /// </summary>
        [JsonPropertyName("merchant_entity_id")]
        public string MerchantEntityId { get; set; }

        /// <summary>
        /// BC互动消息，业务方指定的消息产生时间
        /// </summary>
        [JsonPropertyName("message_time")]
        public string MessageTime { get; set; }

        /// <summary>
        /// 客户端业务埋点参数，Map<String,String>的json格式，传入值会在客户端拼接成key1=value1^key2=value2的格式计入埋点
        /// </summary>
        [JsonPropertyName("monitor_param_map")]
        public string MonitorParamMap { get; set; }

        /// <summary>
        /// BC消息消息操作类型，为空则为正常消息，有值则表示对已有消息进行特殊操作，此时cliemt_msg_id字段与要操作的原消息对应，枚举： 更新传update 删除传delete
        /// </summary>
        [JsonPropertyName("msg_op_type")]
        public string MsgOpType { get; set; }

        /// <summary>
        /// BC消息，除了主消息外，可以一个附加子文本信息，此字段为该文本信息的文案，如不传则没有此子文本信息
        /// </summary>
        [JsonPropertyName("next_msg_content")]
        public string NextMsgContent { get; set; }

        /// <summary>
        /// 支付宝社交聊天，消息内带push提醒的push信息模型
        /// </summary>
        [JsonPropertyName("notify_param")]
        public NotifyParam NotifyParam { get; set; }

        /// <summary>
        /// BC互动消息的消息发送者id，可能是B端或C端的ID本身，也可能是B端或C端id背后对应的B端操作人id
        /// </summary>
        [JsonPropertyName("receiver_id")]
        public string ReceiverId { get; set; }

        /// <summary>
        /// BC互动消息，发送者类型，标识是B端还是C端，枚举： C端传1，B端传2
        /// </summary>
        [JsonPropertyName("receiver_user_type")]
        public string ReceiverUserType { get; set; }

        /// <summary>
        /// BC互动中的B端类型，每个不同业务对应一个type，在接入时由社交侧开放进行分配，对单个业务来说是固定值
        /// </summary>
        [JsonPropertyName("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// BC互动消息的消息发送者id，可能是B端或C端的ID本身，也可能是B端或C端id背后对应的B端操作人id
        /// </summary>
        [JsonPropertyName("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// BC互动关系id，C端id+B端id+关系类型组成唯一值，调用绑定关系接口返回的sessionId
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// BC互动消息一类数据的模版号，请联系社交pd查看已经支持的模版，并获取模版号
        /// </summary>
        [JsonPropertyName("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// C互动顶部通栏，与模版号对应的具体数据，json格式且与模版号对应
        /// </summary>
        [JsonPropertyName("template_data")]
        public string TemplateData { get; set; }
    }
}
