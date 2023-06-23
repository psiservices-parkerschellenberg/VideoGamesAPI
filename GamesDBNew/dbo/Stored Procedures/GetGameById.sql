CREATE PROCEDURE [dbo].[GetGameById]
    @Id INT
AS
BEGIN
    SELECT *
    FROM dbo.GamesNew
    WHERE Id = @Id
END
