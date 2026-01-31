CREATE OR ALTER PROCEDURE seguranca.AutenticarUsuario (
	@Email			VARCHAR (255),
	@HashSenha		VARBINARY(32),
	@SaltSenha		VARBINARY(16)
)
AS BEGIN
	SET NOCOUNT ON;

	SELECT usu.Codigo, usu.Email, usu.HashSenha, usu.SaltSenha
		FROM seguranca.Usuario usu
			WHERE usu.Email = @Email
				AND usu.HashSenha = @HashSenha
				AND usu.SaltSenha = @SaltSenha
				AND usu.Situacao = 1
	
END
