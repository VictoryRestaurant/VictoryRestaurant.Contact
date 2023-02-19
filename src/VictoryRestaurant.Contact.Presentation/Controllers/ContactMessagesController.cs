namespace VictoryRestaurant.Contact.Presentation.Controllers;

/// <summary> Controller for work with <see cref="ContactMessageEntity"/>'s. </summary>
[Route(template: "api/contact-messages")]
[Produces(contentType: "application/json")]
[ApiController]
public sealed class ContactMessagesController : ControllerBase
{

}