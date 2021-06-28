using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Bot.Types.BotCommandScopes
{
    /// <summary>
    /// This object represents a bot command
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BotCommandScopeAllPrivateChats : BotCommandScopeBase
    {
        public BotCommandScopeAllPrivateChats()
            : base("all_private_chats")
        {

        }
    }
}
