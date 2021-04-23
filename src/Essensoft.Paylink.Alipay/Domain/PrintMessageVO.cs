using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PrintMessageVO Data Structure.
    /// </summary>
    public class PrintMessageVO : AlipayObject
    {
        /// <summary>
        /// 打印指令类型
        /// </summary>
        [JsonPropertyName("cmd_type")]
        public string CmdType { get; set; }

        /// <summary>
        /// 打印指令内容
        /// </summary>
        [JsonPropertyName("cmds")]
        public string Cmds { get; set; }
    }
}
