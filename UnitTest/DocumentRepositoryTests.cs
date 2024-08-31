// using Infrastructure.Repository;
// using Core.Entities;
//
// namespace UnitTest
// {
//     public class DocumentRepositoryTests
//     {
//         [Fact]
//         public async Task GetDocumentByIdAsync_Returns_Correct_Document()
//         {
//             // Arrange
//             var documentRepository = new DocumentRepository();
//             var expectedDocument = new Document
//                 { DocumentId = 1, DocumentTags = new List<Tag> { new Tag{TagId = 1, Documents = } }, AdditionalData = new AdditionalData() };
//             await documentRepository.AddDocumentAsync(expectedDocument);
//
//             // Act
//             var actualDocument = await documentRepository.GetDocumentByIdAsync(expectedDocument.DocumentId);
//
//             // Assert
//             Assert.Single(actualDocument);
//             Assert.Equal(expectedDocument, actualDocument.First());
//         }
//
//         [Fact]
//         public async Task AddDocumentAsync_Adds_Document()
//         {
//             // Arrange
//             var documentRepository = new DocumentRepository();
//             var document = new Document
//                 { DocumentId = 1, DocumentTags = new List<string> { "Test Tag" }, AdditionalData = new AdditionalData() };
//
//             // Act
//             var result = await documentRepository.AddDocumentAsync(document);
//
//             // Assert
//             Assert.True(result);
//             var actualDocument = await documentRepository.GetDocumentByIdAsync(document.DocumentId);
//             Assert.Single(actualDocument);
//             Assert.Equal(document, actualDocument[0]);
//         }
//
//         [Fact]
//         public async Task UpdateDocumentAsync_Updates_Document()
//         {
//             // Arrange
//             var documentRepository = new DocumentRepository();
//             
//             var originalDocument = new Document
//                 { DocumentId = 1, DocumentTags = new List<string> { "Test Tag" }, AdditionalData = new AdditionalData() };
//             
//             await documentRepository.AddDocumentAsync(originalDocument);
//             
//             var updatedDocument = new Document
//             {
//                 DocumentId = 1, DocumentTags = new List<string> { "Test Tag" }, AdditionalData =
//                     new AdditionalData { Optional = "Updated Data", Some = "Updated Data" }
//             };
//
//             // Act
//             var result = await documentRepository.UpdateDocumentAsync(updatedDocument);
//
//             // Assert
//             Assert.True(result);
//             var actualDocument = await documentRepository.GetDocumentByIdAsync(originalDocument.DocumentId);
//             Assert.Single(actualDocument);
//             Assert.Equal(updatedDocument, actualDocument[0]);
//         }
//
//         [Fact]
//         public async Task UpdateDocumentAsync_Returns_False_For_Non_Existent_Document()
//         {
//             // Arrange
//             var documentRepository = new DocumentRepository();
//             var document = new Document
//                 { DocumentId = 1, DocumentTags = new List<string> { "Test Tag" }, AdditionalData = new AdditionalData() };
//
//             // Act
//             var result = await documentRepository.UpdateDocumentAsync(document);
//
//             // Assert
//             Assert.False(result);
//         }
//     }
// }