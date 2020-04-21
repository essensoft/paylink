using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentAnalyzeResponse.
    /// </summary>
    public class AlipaySecurityRiskContentAnalyzeResponse : AlipayResponse
    {
        /// <summary>
        /// 内容ID，用于查询异步识别结果时作为查询ID
        /// </summary>
        [JsonPropertyName("app_scene_data_id")]
        public string AppSceneDataId { get; set; }

        /// <summary>
        /// 内容安全同步检测返回的事件id，用于异步获取检测结果
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 命中结果详情
        /// </summary>
        [JsonPropertyName("hit_detect_items")]
        public List<InfoSecHitDetectItem> HitDetectItems { get; set; }

        /// <summary>
        /// 是否需要进行异步查询的标志位    need: 需要等待60秒之后进行异步查询  no_need: 不需要，已经同步返回结果
        /// </summary>
        [JsonPropertyName("need_query")]
        public string NeedQuery { get; set; }

        /// <summary>
        /// PASSED("数据识别通过，可以在网站上正常显示")    REJECTED("被拒绝的数据，比如内容出现违禁词；不能出现在我们网站上")    CC("CC表示用户发表数据后，提示成功，自己能看到这条消息，但其它人接收不到本条消息或看不见这条消息。")    DELETE("删除数据, 为了不扩大化数据的传播，删除历史已经发出去的数据。")    REPLACE("替换部分词为 ***")    WARNING("提示数据，表示内容存在可疑，提示用户操作")    RECOVER("恢复数据，将误判断的内容，恢复回来")
        /// </summary>
        [JsonPropertyName("result_action")]
        public string ResultAction { get; set; }
    }
}
