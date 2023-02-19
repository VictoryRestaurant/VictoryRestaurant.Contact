namespace VictoryRestaurant.Contact.Domain.Entities;

/// <summary> Contact message entity. </summary>
public sealed class ContactMessageEntity
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

    /// <summary> Message author. </summary>
    public string? Name { get; set; }

    /// <summary> Contact email. </summary>
    public string? Email { get; set; }

    /// <summary> Phone number. </summary>
    public string? Phone { get; set; }

    /// <summary> Message body. </summary>
    public string? Message { get; set; }
}