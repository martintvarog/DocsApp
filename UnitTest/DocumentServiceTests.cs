using Core.Entities;
using Core.Infrastructure;
using Infrastructure.DocumentService;
using Moq;

namespace UnitTest
{
    public class DocumentServiceTests
    {
        private readonly Mock<IDocumentRepository> _documentRepositoryMock = new();
        private readonly DocumentService _documentService;

        public DocumentServiceTests()
        {
            _documentService = new DocumentService(_documentRepositoryMock.Object);
        }

        [Fact]
        public async Task GetDocumentByIdAsync_Calls_GetDocumentByIdAsync_On_Repository()
        {
            // Arrange
            var expectedId = "1";

            // Act
            await _documentService.GetDocumentByIdAsync(expectedId);

            // Assert
            _documentRepositoryMock.Verify(r => r.GetDocumentByIdAsync(expectedId), Times.Once());
        }

        [Fact]
        public async Task AddDocumentAsync_Calls_AddDocumentAsync_On_Repository()
        {
            // Arrange
            var document = new Document("1", new List<string> {"Test Tag"}, new Data());

            // Act
            await _documentService.AddDocumentAsync(document);

            // Assert
            _documentRepositoryMock.Verify(r => r.AddDocumentAsync(document), Times.Once());
        }

        [Fact]
        public async Task UpdateDocumentAsync_Calls_UpdateDocumentAsync_On_Repository()
        {
            // Arrange
            var document = new Document("1", new List<string> {"Test Tag"}, new Data());

            // Act
            await _documentService.UpdateDocumentAsync(document);

            // Assert
            _documentRepositoryMock.Verify(r => r.UpdateDocumentAsync(document), Times.Once());
        }
    }
}