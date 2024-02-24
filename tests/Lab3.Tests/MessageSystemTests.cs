using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Loggings;
using Itmo.ObjectOrientedProgramming.Lab3.Results;
using Itmo.ObjectOrientedProgramming.Lab3.Tests.Mock;
using Itmo.ObjectOrientedProgramming.Lab3.Topics;
using Itmo.ObjectOrientedProgramming.Lab3.Users;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;
public class MessageSystemTests
{
    [Fact]
    public void NotReadStatus()
    {
        var message = new Message("BBC", "Do you love BBC?", new Priority(1));
        IDictionary<Message, bool> messages = new Dictionary<Message, bool>();
        var user = new User();
        var addresse = new AdresseeUser(user);
        var topic = new Topic("BBCTOpic", addresse);
        topic.SendMessage(message);
        var logger = new ConsoleLogger();
        var loggingAdressee = new Logging(addresse, logger);
        loggingAdressee.SendMessage(message);
        foreach (KeyValuePair<Message, bool> messageit in messages)
        {
            Assert.False(messageit.Value);
        }
    }

    [Fact]
    public void ReadStatus()
    {
        var message = new Message("gaspacho2004", "baku", new Priority(5));
        IDictionary<Message, bool> messages = new Dictionary<Message, bool>();
        var user = new User();
        var addresse = new AdresseeUser(user);
        var topic = new Topic("BallTop", addresse);
        topic.SendMessage(message);
        var logger = new ConsoleLogger();
        var loggingAddressee = new Logging(addresse, logger);
        loggingAddressee.SendMessage(message);
        foreach (Message messageit in messages.Keys)
        {
            user.MessageHasBeenRead(messageit);
        }

        foreach (KeyValuePair<Message, bool> messageit in messages)
        {
            Assert.True(messageit.Value);
        }
    }

    [Fact]
    public void ReadStatusException()
    {
        // Arrange
        var message = new Message("gaspacho2004", "baku", new Priority(5));
        var user = new User();
        var addressee = new AdresseeUser(user);
        var topic = new Topic("BallTop", addressee);

        // Act
        topic.SendMessage(message);

        // Assert
        Assert.Equal(user.MessageHasBeenRead(message), new WasRead());
    }

    [Fact]
    public void Filterring()
    {
        // Arrange
        var message = new Message("gaspacho2004", "baku", new Priority(5));
        var mock = new FilteringMock();
        IAddressee addressee = new AdresseeProxy(6, mock);
        var topic = new Topic("BallTop", addressee);

        // Act
        topic.SendMessage(message);

        // Assert
        Assert.Equal(0, mock.FilteringCount);
    }

    [Fact]
    public void Logging()
    {
        // Arrange
        var message = new Message("gaspacho2004", "baku", new Priority(5));
        var mock = new LoggingMock();
        var user = new User();
        var userAddressee = new AdresseeUser(user);
        IAddressee addressee = new Logging(userAddressee, mock);
        var topic = new Topic("BallTop", addressee);

        // Act
        topic.SendMessage(message);

        // Assert
        Assert.Equal(1, mock.LoggingCount);
    }

    [Fact]
    public void SendMessageToMessenger()
    {
        // Arrange
        var message = new Message("gaspacho2004", "baku", new Priority(5));
        var mock = new MessengerMock();
        var messengerAddressee = new AdresseeMessenger(mock);
        var topic = new Topic("BallTop", messengerAddressee);

        // Act
        topic.SendMessage(message);

        // Assert
        Assert.Equal(1, mock.Count);
    }
}