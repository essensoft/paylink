using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntiepSceneSendResponse.
    /// </summary>
    public class AlipaySocialAntiepSceneSendResponse : AlipayResponse
    {
        /// <summary>
        /// 上报行为的结果描述
        /// </summary>
        [JsonPropertyName("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 上报行为的处理结果码
        /// </summary>
        [JsonPropertyName("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 上报行为的结果如果是失败时，是否可重试， 如果biz_success=false，则biz_retriable=true时代表需要重试的异常， 如果biz_retriable=false时，则代表不能重试，含义可分为两种：1、不需要重试的异常，比如重试的请求被幂等了、2、或者是即使重试了也成功不了的异常，比如参数缺失、配置缺失等，这种错误需要在验证期间就避免掉，验证无误了再上线！
        /// </summary>
        [JsonPropertyName("biz_retriable")]
        public bool BizRetriable { get; set; }

        /// <summary>
        /// 上报行为的处理结果是否成功，如果biz_success=true，则代表上报成功，如果biz_success=false，需看biz_retriable的值是true代表可重试，biz_retriable为false时则不可重试
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 行为上报所需处理模块的处理结果。 比如：一次行为上报需要处理：统计、任务1、任务2，三个模块，则key为每个模块的标识，value为每个模块的处理结果，value有： 1、success：模块执行结果是否成功，如果success为false，则代表执行失败，不能立即拿到该模块的执行结果，但无需重试，只要外面的success为true，这里会保证最终一致性， 2、code：结果码 3、desc：结果描述
        /// </summary>
        [JsonPropertyName("module_result_map")]
        public string ModuleResultMap { get; set; }
    }
}
