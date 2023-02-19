namespace VictoryRestaurant.Contact.Infrastructure.Context;

/// <summary>
/// A <see cref="ApplicationContext"/> instance represents a session with the database <br/>
/// and can be used to query and save. <br/>
/// </summary>
/// <remarks>
/// Implementation Unit of Work pattern.
/// </remarks>
public sealed class ApplicationContext
{
	public IContactMessageEntityRepository ContactMessages { get; }

	public ApplicationContext(IContactMessageEntityRepository contactMessageEntityRepository)
	{
		ContactMessages = contactMessageEntityRepository;
	}

    /// <summary> Asynchronous create <paramref name="entity"/>. </summary>
    /// <param name="entity"> Creatable entity. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    public async ValueTask<ContactMessageEntity?> AddAsync(
		ContactMessageEntity entity,
		CancellationToken cancellationToken = default)
	{
		var createdMessage = await ContactMessages.CreateAsync(entity, cancellationToken)
			.ConfigureAwait(continueOnCapturedContext: false);

		return createdMessage;
	}

    /// <summary> Asynchronous update <paramref name="entity"/>. </summary>
    /// <param name="entity"> Updatable entity. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    public async ValueTask<ContactMessageEntity?> UpdateAsync(
		ContactMessageEntity entity,
		CancellationToken cancellationToken = default)
	{
		var updatedMessage = await ContactMessages.UpdateAsync(entity, cancellationToken)
			.ConfigureAwait(continueOnCapturedContext: false);

		return updatedMessage;
	}

    /// <summary> Asynchronous remove <paramref name="entity"/>. </summary>
    /// <param name="entity"> Deletable entity. </param>
    /// <param name="cancellationToken"> Asynchronous operation cancellation token. </param>
    public async ValueTask RemoveAsync(
        ContactMessageEntity entity,
        CancellationToken cancellationToken = default)
    {
        await ContactMessages.DeleteAsync(id: entity.Id, cancellationToken)
			.ConfigureAwait(continueOnCapturedContext: false);
    }
}