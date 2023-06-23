CREATE PROCEDURE [dbo].[DeleteGameById]
    @Id INT
AS
BEGIN
    DELETE FROM GamesNew
    WHERE Id = @Id;
END;
