using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Bot.Types.BotCommandScopes
{
    /// <summary>
    /// This object represents a bot command
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BotCommandScopeAllGroupChats : BotCommandScopeBase
    {
        public BotCommandScopeAllGroupChats()
            : base("all_group_chats")
        {

        }
    }
}
