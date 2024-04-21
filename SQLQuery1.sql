CREATE PROC insert_melodie
@IdMelodie varchar(50),
@path varchar(50),
@playlist int
AS
	INSERT INTO Melodie(IdMelodie,path,playlist)
	VALUES (@IdMelodie,@path,@playlist)