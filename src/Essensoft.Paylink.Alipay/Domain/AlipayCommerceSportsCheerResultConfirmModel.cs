using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsCheerResultConfirmModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsCheerResultConfirmModel : AlipayObject
    {
        /// <summary>
        /// 用户助威记录流水号
        /// </summary>
        [JsonPropertyName("game_serial_number")]
        public string GameSerialNumber { get; set; }

        /// <summary>
        /// 用户是否助威游戏胜利
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 游戏中另一支队伍得分
        /// </summary>
        [JsonPropertyName("other_team_score")]
        public long OtherTeamScore { get; set; }

        /// <summary>
        /// 用户所支持队伍得分
        /// </summary>
        [JsonPropertyName("user_team_score")]
        public long UserTeamScore { get; set; }
    }
}
