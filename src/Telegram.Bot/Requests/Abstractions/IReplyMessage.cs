namespace Telegram.Bot.Requests.Abstractions
{
    /// <summary>
    /// Represents a message that is a reply to another message
    /// </summary>
    public interface IReplyMessage
    {
        /// <summary>
        /// Optional. If the message is a reply, ID of the original message
        /// </summary>
        int? ReplyToMessageId { get; set; }

        /// <summary>
        /// Optional. Pass True, if the message should be sent even if the specified replied-to message is not found
        /// </summary>
        bool? AllowSendingWithoutReply { get; set; }
    }
}
