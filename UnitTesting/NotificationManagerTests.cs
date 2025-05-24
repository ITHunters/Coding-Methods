using CleanCodeMethods.Services;
using Moq;
using NotificationService;
using NotificationService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanCodeMethods.UnitTesting
{
    internal class NotificationManagerTests
    {
        [Fact]
        public void Notify_ShouldCallSendMessage_AndReturnExpectedResult()
        {
        //    // Arrange
        //    var message = new EmailDTO("to@test.com", "from@test.com", "Hello", "Test body","sdsd");

        //    var mockService = new Mock<INotification<EmailDTO>>();
        //    object value1 = mockService.Setup(s => s.SendMessage(message)).Returns("Email Sent");

        //    var manager = new NotificationManager<EmailDTO>(mockService.Object);

        //    // Act
        //    var result = manager.Notify(message);

        //    // Assert
        //    object value = Assert.Equal("Email Sent", result);
        //    mockService.Verify(s => s.SendMessage(message), Times.Once);
        }
    }
}
