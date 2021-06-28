using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Bot.Types.BotCommandScopes
{
    /// <summary>
    /// This object represents a bot command
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BotCommandScopeChat : BotCommandScopeBase
    {
        [JsonProperty(Required = Required.Always)]
        public ChatId ChatId { get; }

        public BotCommandScopeChat(ChatId chatId)
            : base("chat")
        {
            ChatId = chatId;
        }
    }
}
