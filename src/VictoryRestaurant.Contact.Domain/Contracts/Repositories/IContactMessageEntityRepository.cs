namespace VictoryRestaurant.Contact.Domain.Contracts.Repositories;

/// <summary> Contract for <see cref="ContactMessageEntity"/> repository. </summary>
public interface IContactMessageEntityRepository
{
    /// <summary> Asynchronous receipt of all <see cref="ContactMessageEntity"/>'s. </summary>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    /// <returns> <see cref="ContactMessageEntity"/>'s collection. </returns>
    public ValueTask<IEnumerable<ContactMessageEntity>> GetAllAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronous first receipt <see cref="ContactMessageEntity"/> by <paramref name="id"/>
    /// or <see langword="default"/>(<see cref="ContactMessageEntity"/>).
    /// </summary>
    /// <param name="id"> Identifier. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    /// <returns> First finded <see cref="ContactMessageEntity"/> or <see langword="default"/>(<see cref="ContactMessageEntity"/>). </returns>
    public ValueTask<ContactMessageEntity?> FirstOrDefaultAsync(Guid id,
        CancellationToken cancellationToken = default);

    /// <summary> Asynchronous create new <see cref="ContactMessageEntity"/>. </summary>
    /// <param name="entity"> Creatable <see cref="ContactMessageEntity"/>. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    /// <returns> Created new <see cref="ContactMessageEntity"/>. </returns>
    public ValueTask<ContactMessageEntity?> CreateAsync(ContactMessageEntity entity,
        CancellationToken cancellationToken = default);

    /// <summary> Asynchronous update <see cref="ContactMessageEntity"/>. </summary>
    /// <param name="entity"> Updatable <see cref="ContactMessageEntity"/>. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    /// <returns> Updated <see cref="ContactMessageEntity"/>. </returns>
    public ValueTask<ContactMessageEntity?> UpdateAsync(ContactMessageEntity entity,
        CancellationToken cancellationToken = default);

    /// <summary> Asynchronous delete <see cref="ContactMessageEntity"/> by <paramref name="id"/>. </summary>
    /// <param name="id"> Identifier. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    public ValueTask DeleteAsync(Guid id,
        CancellationToken cancellationToken = default);
}