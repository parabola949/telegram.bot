using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Requests.Abstractions;

namespace Telegram.Bot.Types.BotCommandScopes
{
    /// <summary>
    /// This object represents a bot command
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BotCommandScopeChatMember : BotCommandScopeBase
    {
        [JsonProperty(Required = Required.Always)]
        public ChatId ChatId { get; }

        [JsonProperty(Required = Required.Always)]
        public long UserId { get; }

        public BotCommandScopeChatMember(ChatId chatId, long userId)
            : base("chat_member")
        {
            ChatId = chatId;
            UserId = userId;
        }
    }
}
