# Geospatial-Recommender
A geospatial-based recommender system via social media to support people suffering from dementia. The application allows for potential collaborators to enter their level of support and interact with social media streams.

The application was developed using WPF and XAML.

## Installation 
Download the project and run it on Visual Studio as normal. Ensure you have at least .NET Framework 4.7.2 to run the application on your machine. 

You would need to create your own account in each of the social media platforms to enable the messaging feature.

## Example

### Sign Up 
The sign up window for a potential collaborator to enter their details and level of support.

![Example](screenshots/Screenshot%202.png)

### Messaging
The messaging window for a user to send a message to collabators for assistance.

![Example](screenshots/Screenshot%203.png)

## Limitations
Currently the app allows for a person to sign up as a collaborator. Any user that wants to reach out to collaborator(s) can send a message via Discord or Instagram.

The data is stored temporarily in `CollaboratorDB.cs` which simulates a database for storing collaborator info.

The map feature has not been integrated into the app yet. 

The application has not been fully tested.

## License
The application is under the MIT License.
