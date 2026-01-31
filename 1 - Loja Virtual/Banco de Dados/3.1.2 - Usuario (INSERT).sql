CREATE OR ALTER PROCEDURE seguranca.InserirUsuario (
	@Nome			NVARCHAR(255),
	@Email			VARCHAR (255),
	@HashSenha		VARBINARY(32),
	@SaltSenha		VARBINARY(16)
)
AS BEGIN

	SET NOCOUNT ON;

	INSERT INTO seguranca.Usuario
			(Nome,	Email,	HashSenha,	SaltSenha)
	VALUES	(@Nome, @Email, @HashSenha, @SaltSenha)

	SELECT SCOPE_IDENTITY() AS CodigoUsuario;
END
