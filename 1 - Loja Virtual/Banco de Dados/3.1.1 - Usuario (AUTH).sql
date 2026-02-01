CREATE OR ALTER PROCEDURE seguranca.AutenticarUsuario (
	@Email			VARCHAR (255)	
)
AS BEGIN
	SET NOCOUNT ON;

	SELECT usu.Email, usu.HashSenha, usu.SaltSenha
		FROM seguranca.Usuario usu
			WHERE usu.Email = @Email
				
	
END
